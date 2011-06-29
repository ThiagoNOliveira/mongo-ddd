using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Site.Cmd.Infrastructure;
using System.Configuration;

namespace Site.Cmd
{
	public class Injection
	{
		private static IUnityContainer container = null;
		private static readonly object padlock = new object();

		private static IUnityContainer Container
		{
			get
			{
				if (container == null)
				{
					lock (padlock)
					{
						container = new UnityContainer();
						container.RegisterType<SitePersistance, MongoSitePersistance>(new InjectionConstructor(new MongoContext(), ConfigurationManager.AppSettings[Constants.Config_MongoDatabase]));
					}
				}
				return container;
			}
		}

		public static T Resolve<T>()
		{
			return Container.Resolve<T>();
		}
	}
}
