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
			//can perform any new site business rules

			SaveSite(site);
		}

		public void UpdateSite(Site site)
		{
			//can perform any modify only business rules

			SaveSite(site);
		}

		private void SaveSite(Site site)
		{
			//generic save site rules
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

		public Site FindById(string id)
		{
			return repo.GetById(id);
		}

		public void RemoveSite(Site site)
		{
			repo.Delete(site.Id);
		}
	}
}
