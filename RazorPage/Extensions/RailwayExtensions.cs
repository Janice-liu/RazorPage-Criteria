using System;

namespace RazorPage
{
	public static class RailwayExtensions
	{
		public static Func<T1, T3> Compose<T1, T2, T3>(this Func<T1, T2> g, Func<T2, T3> f) => x => f(g(x));
		public static Func<T, CmdResult<V>> Switch<T, V>(this Func<T, V> f) => x => CmdResult.Success(f(x));
		public static Func<CmdResult<T>, CmdResult<V>> Bind<T, V>(this Func<T, CmdResult<V>> f)
		{
			return x =>
			{
				if (x.IsFailure)
				{
					return CmdResult.Fail<V>(x.Message);
				}
				return f(x.Data);
			};
		}
		public static Func<T, CmdResult<V>> TryCatch<T, V>(this Func<T, CmdResult<V>> f)
		{
			return x =>
			{
				try
				{
					return f(x);
				}
				catch (Exception exc)
				{
					return CmdResult.Fail<V>(exc.Message);
				}
			};
		}
		public static Func<T, T> Tee<T>(this Action<T> f)
		{
			return x =>
			{
				f(x);
				return x;
			};
		}
		public static Func<CmdResult<T>, CmdResult<V>> DoubleMap<T, V>(this Func<T, V> success, Func<string, string> failure)
		{
			return x =>
			{
				if (x.IsFailure)
				{
					return CmdResult.Fail<V>(failure(x.Message));
				}
				return CmdResult.Success(success(x.Data));
			};
		}
	}
}
