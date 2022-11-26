namespace OpenClose.Class
{
	public class Class
	{
		public Class()
		{
			var dp = new DocumentProcessor();
			dp.RegisterSaver(new PdfDocumentSaver());
			dp.RegisterSaver(new TxtDocumentSaver());
			dp.RegisterSaver(new WordDocumentSaver());
			
			var document = new Document("OCP", "sample");
			
			dp.Save(document, DocumentType.Pdf);
			dp.Save(document, DocumentType.Txt);
			dp.Save(document, DocumentType.Word);
		}
	}
}
