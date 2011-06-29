using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using Site.Cmd.Domain;


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
			return this.collection.FindOneByIdAs<T>(id);
		}
		public void Save(T data)
		{
			collection.Save(data.ToBsonDocument());
		}
		public void Delete(string id)
		{
			collection.Remove(Query.EQ("Id", id));
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

