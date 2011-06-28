using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public class Site : PersistanceRoot<Site>
	{
		public string Name { get; private set; }
		public IList<DomainName> Domains { get; private set; }

		public Site()
		{
		}

		public void ChangeName(string name)
		{
			//potential name check here. 
			this.Name = name;
		}

		public void AddDomain(DomainName domain)
		{

		}

		public bool CanAddDomain(DomainName domain)
		{
			return new DomainNameIsUniqueToSiteRule().IsSatisfiedBy(domain);
		}
	}
}
