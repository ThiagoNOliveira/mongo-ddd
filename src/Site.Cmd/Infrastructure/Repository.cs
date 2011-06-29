using System;
using System.Collections.Generic;

namespace Site.Cmd
{
	public interface Repository<T>
	{
		T GetById(string id);
		void Save(T data);
		void Delete(string id);
		IList<T> FindAll();
		//IList<T> Find(IMongoQuery query)
	}
}

