using System.Collections.Generic;

namespace OpenClose.Class
{
	public class Document
	{
		public Document(string name, string text)
		{
			Name = name;
			Text = text;
		}

		public string Name { get; }
		public string Text { get; }
	}
}
