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
			try
			{
				Infrastructure.MongoMappings.Initialize();

				var repo = Injection.Resolve<SiteRepository>();
				var site = new Domain.Site();
				site.Name = "This is a test site";
				site.AddDomain(new DomainName("www.helloworld.com"));
				repo.AddSite(site);

				var site2 = new Domain.Site();
				site2.Name = "This is a test site";
				site2.AddDomain(new DomainName("www.helloworld.com"));
				repo.AddSite(site2);

				var existing = repo.FindById(site.Id);
				//var existing = repo.GetSiteByDomain(new DomainName("www.helloworld.com"));

				repo.RemoveSite(site);

				repo.RemoveSite(site2);

			}
			catch (SpecificationException ex)
			{
				Console.WriteLine("Broken specification: " + ex.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}			
		}

		static void Create()
		{
		}

		static void Get()
		{
		}
	}
}
