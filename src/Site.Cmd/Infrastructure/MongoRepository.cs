using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;


namespace Site.Cmd.Infrastructure
{
	public class MongoRepository<T> where T : PersistanceRoot<T>
	{
		protected MongoContext context;
		protected MongoCollection collection;

		public MongoRepository(MongoContext repo, string collectionName)
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
			collection.Remove(Query.EQ("_id", id));
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

