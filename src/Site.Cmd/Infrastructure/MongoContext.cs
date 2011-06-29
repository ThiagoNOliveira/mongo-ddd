using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using System.Configuration;

namespace Site.Cmd.Infrastructure
{
	public class MongoContext
	{
		public MongoServer Server {get; private set;}
		public MongoDatabase Database {get; private set;}
		
		public MongoContext()
		{
			var con = ConfigurationManager.ConnectionStrings[Constants.Config_MongoConnection];
			if (con == null)
				throw new ArgumentException("Cannot initialize connection. Check connection string configuration.");

			Server = MongoServer.Create(con.ConnectionString);
			Database = Server.GetDatabase(ConfigurationManager.AppSettings[Constants.Config_MongoDatabase]);
		}
		public MongoContext(MongoServer server, MongoDatabase database)
		{
			this.Server = server;
			this.Database = database;
		}

		public MongoCollection<TRoot> Collection<TRoot>(string collection)
		{
			return Database.GetCollection<TRoot>(collection);
		}
	}
}
