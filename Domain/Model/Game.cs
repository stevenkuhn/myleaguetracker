using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLeagueTracker.Domain.Common;

namespace MyLeagueTracker.Domain.Model
{
	public class Game : Entity<Guid>
	{
		public string Name { get; set; }
	}
}
