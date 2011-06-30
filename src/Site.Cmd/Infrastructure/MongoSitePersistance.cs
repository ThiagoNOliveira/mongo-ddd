using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site.Cmd.Domain;
using MongoDB.Driver.Builders;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;

namespace Site.Cmd.Infrastructure
{
	public class MongoSitePersistance : MongoPersistance<Domain.Site>, SitePersistance
	{
		public MongoSitePersistance(MongoContext context)
			: base(context, Constants.Mongo_Collection_Site)
		{
		}

		public Domain.Site GetByDomain(DomainName domain)
		{
			return this.Find(Query.In("domains", new BsonValue[] { domain.ToBson() })).FirstOrDefault();
		}
	}
}
