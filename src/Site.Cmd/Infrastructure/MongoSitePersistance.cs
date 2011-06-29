using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site.Cmd.Domain;
using MongoDB.Driver.Builders;

namespace Site.Cmd.Infrastructure
{
	public class MongoSitePersistance : MongoPersistance<Domain.Site>, SitePersistance
	{
		public MongoSitePersistance(MongoContext context, string collectionName)
			: base(context, collectionName)
		{
		}

		public Domain.Site GetByDomain(DomainName domain)
		{
			return this.Find(Query.In("Domains", domain.ToString())).FirstOrDefault();
		}
	}
}
