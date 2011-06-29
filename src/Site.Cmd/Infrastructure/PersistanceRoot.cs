using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace Site.Cmd.Infrastructure
{
	public class PersistanceRoot<T>
	{
		public string Id { get; private set; }
		
		public PersistanceRoot()
		{
			if (string.IsNullOrEmpty(this.Id) || this.Id == ObjectId.Empty.ToString())
				this.Id = ObjectId.GenerateNewId().ToString();
		}

		public override bool Equals(object obj)
		{
			if (obj is PersistanceRoot<T>)
			{
				var temp = (PersistanceRoot<T>)obj;

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
