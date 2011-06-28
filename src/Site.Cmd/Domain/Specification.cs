using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public interface Specification<T>
	{
		bool IsSatisfiedBy(T data);
	}
}
