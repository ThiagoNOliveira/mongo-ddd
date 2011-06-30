using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public class SiteDomainIsAlreadyTakenFailure : SpecificationException
	{
		public SiteDomainIsAlreadyTakenFailure() :
			base("Failed to create site because one of its domain names is already taken by another site")
		{
		}
		public SiteDomainIsAlreadyTakenFailure(DomainName domain, Site site)
			: base(string.Format("Failed to create site {1} because the domain name {0} is already taken by another site.", site, domain))
		{

		}
	}

	public class SpecificationException : Exception
	{
		public SpecificationException()
			: base()
		{
		}
		public SpecificationException(string message)
			: base(message)
		{
		}
	}
}
