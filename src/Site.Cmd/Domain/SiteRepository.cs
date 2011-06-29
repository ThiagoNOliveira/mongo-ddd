using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public class SiteRepository
	{
		Repository<Site> repo;
		
		public SiteRepository(Repository<Site> repo)
		{
			this.repo = repo;
		}
		
		public void AddSite(Site site)
		{
			var uniqueRule = new DomainNameIsUniqueToSiteRule();
			if (uniqueRule.IsSatisfiedBy(this, site))
				repo.Save(site);
			else
				throw new SiteDomainIsAlreadyTakenFailure(uniqueRule.CausedByDomain, site);
		}

		public Site GetSiteByDomain(DomainName name)
		{
			throw new NotImplementedException();
		}
	}
}
