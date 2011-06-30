using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using Site.Cmd.Domain;
using System.Reflection;


namespace Site.Cmd.Infrastructure
{
	public class MongoPersistance<T> where T : Entity
	{
		protected MongoContext context;
		protected MongoCollection collection;

		public MongoPersistance(MongoContext repo, string collectionName)
		{
			this.context = repo;
			this.collection = this.context.Collection<T>(collectionName);
		}

		public T GetById(string id)
		{
			return this.collection.FindOneByIdAs<T>(new BsonObjectId(id));
		}
		public void Save(T data)
		{
			var bson = data.ToBsonDocument();
			collection.Save(bson);
			
			//crazy id setter hack.
			var type = typeof(Entity);
			var field = type.GetField("id", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance); 
			var objId = bson.GetElement("_id").Value.AsObjectId;
			field.SetValue(data, objId.ToString());
		}
		public void Delete(string id)
		{
			collection.Remove(Query.EQ("_id", new BsonObjectId(id)));
		}
		public void Delete(T data)
		{
			this.Delete(data.Id);
		}
		public IList<T> FindAll()
		{
			return collection.FindAllAs<T>().ToList();
		}
		public IList<T> Find(IMongoQuery query)
		{
			return collection.FindAs<T>(query).ToList();
		}
	}
}

