using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Site.Cmd.Domain;

namespace Site.Cmd
{
	class Program
	{
		static void Main(string[] args)
		{
			var repo = Injection.Resolve<SiteRepository>();
		}
	}
}
