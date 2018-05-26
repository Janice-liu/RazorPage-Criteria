using System;
using System.Linq;
using System.Linq.Expressions;

namespace RazorPage
{
	public abstract class Criteria<T> : Criteria, ICriteria<T>, ICriteriaPool<T>
	{
		private IQueryable<T> _source;

		internal ICriteriaPool<T> self => this;
		protected virtual bool OnEarlyBreak() => false;

		protected virtual void OnCollecting() { }
		protected virtual void OnCollected() { }
		protected abstract void OnCollect(ICriteriaPool<T> pool);

		IQueryable<T> ICriteria<T>.Filter(IQueryable<T> source)
		{
			_source = source;
			OnCollecting();
			if (!OnEarlyBreak())
				OnCollect(self);
			OnCollected();
			return _source;
		}
		
		ICriteriaPool<T> ICriteriaPool<T>.Add(Expression<Func<T, bool>> predicate)
		{
			_source = _source.Where(predicate); return this;
		}
		ICriteriaPool<T> ICriteriaPool<T>.Add(Expression<Func<T, bool>> predicate, bool @if)
			=> @if ? ((ICriteriaPool<T>)this).Add(predicate) : this;

		ICriteriaPool<T> ICriteriaPool<T>.With(Action<ICriteriaPool<T>> pipe) { pipe(this); return this; }
	}
}
