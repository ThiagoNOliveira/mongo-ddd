using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site.Cmd.Infrastructure;

namespace Site.Cmd.Domain
{
	public class Site : PersistanceEntity<Site>
	{
		public string Name { get; private set; }
		public IList<DomainName> Domains { get; private set; }

		public Site()
		{
			this.Domains = new List<DomainName>();
		}

		public void ChangeName(string name)
		{
			//potential name check here. 
			this.Name = name;
		}

		public void AddDomain(DomainName domain)
		{
			if (!this.Domains.Contains(domain))
				this.Domains.Add(domain);
		}
		public void RemoveDomain(DomainName domain)
		{
			if (this.Domains.Contains(domain))
				this.Domains.Remove(domain);
		}
	}
}
