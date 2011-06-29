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
			
		}

		public bool GetSiteByDomain(DomainName name)
		{
			throw new NotImplementedException();
		}
	}
}
