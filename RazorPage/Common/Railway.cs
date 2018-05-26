using System;

namespace RazorPage
{
	public static class Railway
	{
		public static Func<T, CmdResult<V>> Apply<T, V>(Func<T, CmdResult<V>> f) => x => f(x);
		public static Func<T, CmdResult<T>> Apply<T>(Func<T, CmdResult<T>> f) => x => f(x);
		public static Func<T, CmdResult<T>> Apply<T>(Action<T> f) => f.Tee().Switch();
		public static Func<T, CmdResult<V>> Apply<T, V>(Func<T, V> f) => f.Switch();
		public static Func<T, CmdResult<T>> Apply<T>(Func<T, T> f) => f.Switch();
		public static Func<T, CmdResult<V>> OnSuccess<T, U, V>(this Func<T, CmdResult<U>> f, Func<U, CmdResult<V>> onSuccess) => f.Compose(onSuccess.Bind());
		public static Func<T, CmdResult<V>> OnSuccess<T, U, V>(this Func<T, CmdResult<U>> f, Func<U, V> onSuccess) => f.Compose(onSuccess.Switch().Bind());
		public static Func<T, CmdResult<V>> OnSuccess<T, V>(this Func<T, CmdResult<V>> f, Action<V> onSuccess) => f.Compose(onSuccess.Tee().Switch().Bind());
		public static Func<T, CmdResult<V>> OnFailure<T, V>(this Func<T, CmdResult<V>> f, Action<string> onFailure) => f.Compose(Unit<V>().DoubleMap(onFailure.Tee()));
		private static Func<T, T> Unit<T>() => t => t;
	}
}
