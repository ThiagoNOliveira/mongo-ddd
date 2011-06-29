using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Infrastructure
{
	public interface Persistance<T> where T : Entity<T>
	{
		T GetById(string id);
		void Save(T data);
		void Delete(string id);
		IList<T> FindAll();
	}
}
