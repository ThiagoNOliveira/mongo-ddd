using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Infrastructure
{
	public class Entity
	{
		public string Id { get; set; }
		
		public Entity()
		{
		}

		public override bool Equals(object obj)
		{
			if (obj is Entity)
			{
				var temp = (Entity)obj;

				return !string.IsNullOrEmpty(this.Id) && !string.IsNullOrEmpty(temp.Id) && temp.Id == this.Id;
			}
			else
				return false;
		}
		public override int GetHashCode()
		{
			return this.Id.GetHashCode();
		}
	}
}
