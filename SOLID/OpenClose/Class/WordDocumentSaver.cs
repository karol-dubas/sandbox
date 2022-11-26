using System;

namespace OpenClose.Class
{
	public class WordDocumentSaver : IDocumentSaver
	{
		public DocumentType SaveTo => DocumentType.Word;
		public void Save(Document document)
		{
			Console.WriteLine($"Saving '{document.Name}' to word...");
		}
	}
}
