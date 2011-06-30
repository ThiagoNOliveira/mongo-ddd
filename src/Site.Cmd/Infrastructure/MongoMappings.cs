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
				cm.MapIdField("id"); //readonly field (kind of)
				cm.IdMemberMap.SetRepresentation(BsonType.ObjectId); //will autocreate new objectid for new ones
			}); 

			BsonClassMap.RegisterClassMap<DomainName>(cm =>
			{
				cm.MapField("domain");
			});
			
			BsonClassMap.RegisterClassMap<Domain.Site>(cm =>
			{
				cm.AutoMap(); //automaps public elements
				cm.SetDiscriminator("Site"); //inherits from entity, need a descriminator
				cm.MapField("domains"); //private field to map.
			});
		}
	}
}
