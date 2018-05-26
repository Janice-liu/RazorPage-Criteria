using Zebra;

namespace RazorPage
{
	public class SeqText : Zebra.Archetypes.Duad<SeqText, int, string>
	{
		public SeqText() : this(0, string.Empty) { }
		private SeqText(int seq, string text) : base(seq, text.Ensure()) { }

		protected override SeqText OnNew(IDuad<string, string> tvp)
			=> new SeqText(tvp.V1.ToInt32(), tvp.V2);

		public int Seq => f1;
		public string Text => f2;
	}
}
