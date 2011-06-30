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

				var existing = repo.FindById(site.Id);
				site.AddDomain(new DomainName("www.helloworld.com"));
				repo.AddSite(site);
				//var existing = repo.GetSiteByDomain(new DomainName("www.helloworld.com"));

				repo.RemoveSite(site);

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
