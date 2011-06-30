using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public class Entity
	{
		private string id;
		public string Id { get { return this.id; } }

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
