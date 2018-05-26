using System;
using System.Collections.Generic;
using System.Linq;
using RazorPage.Archetypes;

namespace RazorPage
{
	partial class extRazorPage
    {
		//public static IQueryable<T> PageBy<T, C>(this IQueryable<T> me, C criteria) where C : IPagination
		//	=> me.Skip((criteria.PageIndex - 1) * criteria.PageSize).Take(criteria.PageSize);

		//public static IEnumerable<T> PageBy<T, C>(this IEnumerable<T> me, C criteria) where C : IPagination
		//	=> criteria.PageIndex > 0 ? me.Skip((criteria.PageIndex - 1) * criteria.PageSize).Take(criteria.PageSize) : me;

		public static IEnumerable<T> FilterBy<T>(this IQueryable<T> me, Criteria<T> criteria) where T : IEntity
			=> me.FilterBy<T, long>(criteria);

		public static IEnumerable<T> FilterBy<T, PK>(this IQueryable<T> me, Criteria<T> criteria)
			where T : IEntity<PK>
			where PK : IEquatable<PK>
			=> criteria.ApplyTo(me);

	}
}
