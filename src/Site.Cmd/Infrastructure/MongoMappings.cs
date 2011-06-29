using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using Site.Cmd.Domain;

namespace Site.Cmd.Infrastructure
{
	public class MongoMappings
	{
		public static void Initialize()
		{
			BsonClassMap.RegisterClassMap<Entity>(cm =>
			{
				cm.MapIdProperty(o => o.Id);
				cm.IdMemberMap.SetRepresentation(BsonType.ObjectId);
			}); 

			BsonClassMap.RegisterClassMap<DomainName>(cm =>
			{
				cm.MapProperty(o=>o.Domain);
			});
			
			BsonClassMap.RegisterClassMap<Domain.Site>(cm =>
			{
				cm.AutoMap();
				cm.SetDiscriminator("Site");
				cm.MapField("_Domains");
			});
		}
	}
}
