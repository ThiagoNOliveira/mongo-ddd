using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDD.Domain
{
	public interface Specification<T>
	{
		bool IsSatisfiedBy(T data);
	}
}
