using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site.Cmd.Infrastructure;

namespace Site.Cmd.Domain
{
	public class Site : Entity
	{
		IList<DomainName> _Domains;

		public string Name { get; set; }
		public IEnumerable<DomainName> Domains { get { return _Domains; } }

		public Site()
		{
			_Domains = new List<DomainName>();
		}

		public void AddDomain(DomainName domain)
		{
			if (!this.Domains.Contains(domain))
				_Domains.Add(domain);
		}
		public void RemoveDomain(DomainName domain)
		{
			if (this.Domains.Contains(domain))
				_Domains.Remove(domain);
		}
	}
}
