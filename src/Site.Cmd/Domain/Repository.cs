using System;
using System.Collections.Generic;
using Site.Cmd.Infrastructure;

namespace Site.Cmd.Domain
{
	public interface Repository<T> where T : PersistanceEntity<T>
	{
		T GetById(string id);
		void Save(T data);
		void Delete(string id);
		IList<T> FindAll();
	}
}

