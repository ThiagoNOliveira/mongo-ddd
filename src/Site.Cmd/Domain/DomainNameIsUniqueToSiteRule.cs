using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public class DomainNameIsUniqueToSiteRule : Specification<DomainName>
	{
		public bool IsSatisfiedBy(DomainName data)
		{
			throw new NotImplementedException();
		}
	}
}
