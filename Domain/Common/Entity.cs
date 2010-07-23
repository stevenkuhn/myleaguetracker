using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLeagueTracker.Domain.Common
{
	public abstract class Entity<T> : ObjectBase, IEntity<T>
	{
		public T Id { get; private set; }
	}
}
