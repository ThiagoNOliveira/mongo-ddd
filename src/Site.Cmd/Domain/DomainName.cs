﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Site.Cmd.Domain
{
	public class DomainName : ValueObject<DomainName>
	{
		private readonly string _domain;
		public string Domain { get { return _domain; } }

		public DomainName(string domain)
		{
			_domain = domain;
		}
	}
}
