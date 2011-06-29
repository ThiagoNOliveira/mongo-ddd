using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;

namespace Site.Cmd.Infrastructure
{
	public class Mappings
	{
		public static void Initialize()
		{
			BsonClassMap.RegisterClassMap<Entity>(cm =>
			{
				cm.AutoMap();
				cm.IdMemberMap.SetRepresentation(BsonType.ObjectId);
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
