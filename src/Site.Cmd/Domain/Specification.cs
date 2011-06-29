using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public interface Specification<Entity>
	{
		bool IsSatisfiedBy(Entity data);
	}
	public interface AggregateSpecification<Repository, Entity>
	{
		bool IsSatisfiedBy(Repository repo, Entity data);
	}
}
