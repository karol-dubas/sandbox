namespace OpenClose.Class
{
    public interface IDocumentSaver
    {
        DocumentType SaveTo { get; }
        void Save(Document document);
    }
}