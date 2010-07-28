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
