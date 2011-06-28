using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public class ValueObject<T>
	{
		public override bool Equals(object obj)
		{
			throw new NotImplementedException("compare all public properties");
		}
		public override int GetHashCode()
		{
			throw new NotImplementedException("hash all public properties");
		}
	}
}
