using System;

namespace OpenClose.Class
{
    public class PdfDocumentSaver : IDocumentSaver
    {
        public DocumentType SaveTo => DocumentType.Pdf;

        public void Save(Document document)
        {
            Console.WriteLine($"Saving '{document.Name}' to pdf...");
        }
    }
}
