using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site.Cmd.Domain;

namespace Site.Cmd.Infrastructure
{
	public interface SitePersistanceRepository : PersistanceRepository<Cmd.Domain.Site>
	{
		IList<Domain.Site> GetByDomain(DomainName name);
	}
}
