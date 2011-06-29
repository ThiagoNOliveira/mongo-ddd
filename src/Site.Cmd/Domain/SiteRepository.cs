using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site.Cmd.Infrastructure;

namespace Site.Cmd.Domain
{
	public class SiteRepository
	{
		SitePersistance repo;

		public SiteRepository(SitePersistance repo)
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
			return repo.GetByDomain(name);
		}
	}
}
