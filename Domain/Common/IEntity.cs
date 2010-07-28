using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLeagueTracker.Domain.Common
{
	public interface IEntity { }

	public interface IEntity<T> : IEntity
	{
		T Id { get; }
	}
}
