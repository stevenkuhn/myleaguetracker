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
	public class Match : Entity<Guid>
	{
		public Team AwayTeam { get; set; }

		public Team HomeTeam { get; set; }

		public IEnumerable<Map> Maps { get; private set; }

		public IEnumerable<MatchResult> Results { get; private set; }

		public DateTime ScheduledDate { get; set; }

		public Winner Winner
		{
			get { throw new NotImplementedException(); }
		}

		public MatchResult CreateResult(Map map)
		{
			throw new NotImplementedException();
		}

		public void RemoveResult(Map map)
		{
			throw new NotImplementedException();
		}

		public void ApproveResults()
		{
			throw new NotImplementedException();
		}
	}
}
