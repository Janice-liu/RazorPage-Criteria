using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Zebra;

namespace RazorPage
{
	public interface IIdentityGetter<PK> where PK : IEquatable<PK> { PK ID { get; } }
	public interface IIdentitySetter<PK> where PK : IEquatable<PK> { PK ID { set; } }


	public interface IEntity : IEntity<long> { }
	public interface IEntity<PK> : IIdentityGetter<PK>, IIdentitySetter<PK> where PK : IEquatable<PK> { }

	partial class extRazorPage
	{
		public static T Fetch<T>(this IQueryable<T> me, Expression<Func<T, bool>> predicate)
			=> me.Ensure(q => Queryable.FirstOrDefault(q, predicate));

		public static T Fetch<T>(this IEnumerable<T> me, Func<T, bool> predicate)
			=> me.Ensure(q => q.FirstOrDefault(predicate));

		public static T Fetch<T, K>(this IQueryable<T> me, K id) where T : IIdentityGetter<K> where K : IEquatable<K>
			=> me.Ensure(q => q.FirstOrDefault(x => x.ID.Equals(id)));

		public static T Fetch<T, K>(this IEnumerable<T> me, K id) where T : IIdentityGetter<K> where K : IEquatable<K>
			=> me.Ensure(q => q.FirstOrDefault(x => x.ID.Equals(id)));
	}
}
