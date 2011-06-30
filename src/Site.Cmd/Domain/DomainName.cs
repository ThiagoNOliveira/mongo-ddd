using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public class DomainName : ValueObject
	{
		private string domain; //not truely immutable, but this is so we can serialize/deserialize it.
		public string Domain { get { return domain; } }

		public DomainName(string domain)
		{
			this.domain = domain;
		}

		public override string ToString()
		{
			return this.Domain;
		}
	}
}
