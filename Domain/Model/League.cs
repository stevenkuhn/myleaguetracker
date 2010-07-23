using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLeagueTracker.Domain.Common;

namespace MyLeagueTracker.Domain.Model
{
	public class League : Entity<Guid>
	{
		private League() { }

		public League(Game game, string name)
		{
			throw new NotImplementedException();
		}

		public string Name { get; set; }

		public IEnumerable<Season> Seasons { get; private set; }

		public Game Game { get; private set; }

		public Season CreateSeason(string name)
		{
			throw new NotImplementedException();
		}

		public void RemoveSeason(Season season)
		{
			throw new NotImplementedException();
		}
	}
}
