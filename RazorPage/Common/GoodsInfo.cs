using Zebra;
using Zebra.Archetypes;

namespace RazorPage
{
	using M = GoodsInfo;
	using S = System.String;

	public class GoodsInfo : Pentad<M, S, S, S, S, S>
	{
		public static M Of(S name, S brand, S model, S spec)
			=> new M(name, brand, model, spec, S.Empty);
		public static M Of(S name, S brand, S model, S spec, S sku)
			=> new M(name, brand, model, spec, sku);

		public GoodsInfo() : this(S.Empty, S.Empty, S.Empty, S.Empty, S.Empty) { }
		private GoodsInfo(S name, S brand, S model, S spec, S sku) 
			: base(name, brand, model, spec, sku) { }

		protected override M OnNew(IPentad<S, S, S, S, S> tvp)
			=> new M(tvp.V1, tvp.V2, tvp.V3, tvp.V4, tvp.V5);

		public S Name => f1;
		public S Brand => f2;
		public S Model => f3;
		public S Spec => f4;
		public S Sku => f5;

		public override S ToString() => ToTvp();
	}
}
