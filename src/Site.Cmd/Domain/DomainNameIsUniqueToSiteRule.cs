using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public class DomainNameIsUniqueToSiteRule : AggregateSpecification<SiteRepository, Site>
	{
		public DomainName CausedByDomain { get; private set; }

		public bool IsSatisfiedBy(SiteRepository repo, Site data)
		{
			foreach (var domain in data.Domains)
			{
				var site = repo.GetSiteByDomain(domain);
				if (site != null && site != data)
				{
					this.CausedByDomain = domain;
					return false;
				}
			}

			return true;
		}
	}
}
