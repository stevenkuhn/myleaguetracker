#region License
// 
// Author: Steven Kuhn <email@stevenkuhn.net>
// Copyright (c) 2010, Steven Kuhn.
// 
// Licensed under the Apache License, Version 2.0.
// See the file LICENSE for details.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLeagueTracker.Domain.Common;

namespace MyLeagueTracker.Domain.Model
{
	public class Season : Entity<Guid>
	{
		private Season() { }

		public string Name { get; set; }

		public IEnumerable<Team> Teams { get; private set; }

		public Team CreateTeam(string name)
		{
			throw new NotImplementedException();
		}

		public void RemoveTeam(string name)
		{
			throw new NotImplementedException();
		}
	}
}
