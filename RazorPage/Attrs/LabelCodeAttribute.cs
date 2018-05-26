using System;

namespace RazorPage
{
	public class LabelCodeAttribute : Attribute
	{
		public LabelCodeAttribute(string code)
		{
			Code = code;
		}
		public string Code { get; }
	}
}
