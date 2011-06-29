using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site.Cmd.Domain;

namespace Site.Cmd.Infrastructure
{
	public interface SitePersistance : Persistance<Domain.Site>
	{
		Domain.Site GetByDomain(DomainName name);
	}
}
