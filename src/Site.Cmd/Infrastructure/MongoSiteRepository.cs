using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site.Cmd.Domain;

namespace Site.Cmd.Infrastructure
{
	public class MongoSiteRepository : MongoRepository<Domain.Site>, SitePersistanceRepository
	{
		public MongoSiteRepository(MongoContext context, string collectionName)
			: base(context, collectionName)
		{
		}

		public IList<Domain.Site> GetByDomain(DomainName domain)
		{
			throw new NotImplementedException();
		}
	}
}
