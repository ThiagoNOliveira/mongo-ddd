using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site.Cmd.Infrastructure;

namespace Site.Cmd.Domain
{
	public class Site : Entity
	{
		IList<DomainName> domains;

		public string Name { get; set; }
		public IEnumerable<DomainName> Domains { get { return domains; } }

		public Site()
		{
			domains = new List<DomainName>();
		}

		public void AddDomain(DomainName domain)
		{
			if (!this.Domains.Contains(domain))
				domains.Add(domain);
		}
		public void RemoveDomain(DomainName domain)
		{
			if (this.Domains.Contains(domain))
				domains.Remove(domain);
		}
		
		public override string ToString()
		{
			return this.Name;
		}
	}
}
