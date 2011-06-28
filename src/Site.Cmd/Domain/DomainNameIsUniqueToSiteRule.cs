using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public class DomainNameIsUniqueToSiteRule : Specification<SiteRepository>
	{
		public bool IsSatisfiedBy(SiteRepository data)
		{
			throw new NotImplementedException();
		}
	}
}
