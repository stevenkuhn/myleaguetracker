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
	public class Team : Entity<Guid>
	{
		private Team() { } 

		public string Name { get; set; }

		public IEnumerable<Player> Players { get; private set; }

		public int Losses { get; private set; }

		public int Ties { get; private set; }

		public int Wins { get; private set; }

		public void AddPlayer(Player player)
		{
			throw new NotImplementedException();
		}

		public void RemovePlayer(Player player)
		{
			throw new NotImplementedException();
		}

		public void AwardPoints(Match match)
		{
			throw new NotImplementedException();
		}
	}
}
