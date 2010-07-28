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
	public class MatchResult : Entity<int>
	{
		public IEnumerable<Player> AwayPlayers { get; private set; }

		public IEnumerable<Player> HomePlayers { get; private set; }

		public Map Map { get; set; }

		public Winner Winner { get; set; }
	}
}
