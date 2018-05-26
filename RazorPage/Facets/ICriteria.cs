using System;
using System.Collections.Generic;
using System.Linq;

namespace RazorPage
{
	public interface ICriteria
	{
		// Marker
	}

	public interface ICriteria<T> : ICriteria
	{
		IQueryable<T> Filter(IQueryable<T> source);
	}

	partial class extRazorPage
    {
		public static IQueryable<T> ApplyTo<T>(this ICriteria<T> me, Func<IQueryable<T>> source)
			=> me.ApplyTo(source());

		public static IQueryable<T> ApplyTo<T>(this ICriteria<T> me, IQueryable<T> source)
			=> me.Filter(source);

		public static IEnumerable<T> ApplyTo<T>(this ICriteria<T> me, IEnumerable<T> source)
			=> me.ApplyTo(source.AsQueryable());
	}
}
