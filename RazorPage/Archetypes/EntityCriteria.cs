using System;
using System.Collections.Generic;
using System.Linq;
using Zebra;

namespace RazorPage
{
	public abstract class EntityCriteria<T> : EntityCriteria<T, long> where T : class, IEntity<long> { }
	public abstract class EntityCriteria<T, PK> : Criteria<T>, IEntityCriteria<T, PK>
		where T : class, IEntity<PK> where PK : IEquatable<PK>
	{
		public PK ID { get; set; }
		public IList<PK> IDs { get; set; }

		protected override bool OnEarlyBreak()
		{
			self.Add(x => ((IIdentityGetter<PK>)x).ID.Equals(ID), ID.IsTruthy())
				.Add(x => IDs.ToList().Contains(((IIdentityGetter<PK>)x).ID), IDs.IsTangible());
			return ID.IsTruthy() || IDs.IsTangible();
		}
		
	}
}
