using System;

namespace OpenClose.Class
{
    public class TxtDocumentSaver : IDocumentSaver
    {
        public DocumentType SaveTo => DocumentType.Txt;
        
        public void Save(Document document)
        {
            Console.WriteLine($"Saving '{document.Name}' to txt...");
        }
    }
}
