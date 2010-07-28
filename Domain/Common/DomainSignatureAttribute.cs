#region License
// 
// Originally from S#arp Architechture (http://www.sharparchitecture.net/).
// Source code at http://github.com/codai/Sharp-Architecture.
// Licensed under the New BSD License from Codai, Inc.
// Copyright (c) 2009, Codai, Inc.
//
// Modified by Steven Kuhn <email@stevenkuhn.net>.
// Copyright (c) 2010, Steven Kuhn.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLeagueTracker.Domain.Common
{
	/// <summary>
	/// Facilitates indicating which property(s) describe the unique signature of an 
	/// entity.  See Entity.GetTypeSpecificSignatureProperties() for when this is leveraged.
	/// </summary>
	/// <remarks>
	/// This is intended for use with <see cref="Entity" />.  It may NOT be used on a <see cref="ValueObject"/>.
	/// </remarks>
	[Serializable]
	public class DomainSignatureAttribute : Attribute { }
}
