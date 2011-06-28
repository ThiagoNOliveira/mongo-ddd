using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DDD.Persistance;

namespace DDD.Domain
{
	public class Site : PersistanceRoot<Site>
	{
		public string Name { get; set; }
		public IList<string> Domains { get; private set; }

		public Site()
		{
		}
	}
}
