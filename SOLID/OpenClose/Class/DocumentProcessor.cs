using System.Collections.Generic;

namespace OpenClose.Class
{
    public class DocumentProcessor
    {
        private readonly Dictionary<DocumentType, IDocumentSaver> _savers = new();

        // Tu można zarejestrować wszystkie klasy za pomocą refleksji zamiast tej metody.
        public void RegisterSaver(IDocumentSaver saver)
        {
            _savers.Add(saver.SaveTo, saver);
        }
        
        // Możemy stworzyć taką metodę.
        // public void SaveToPdf() { }

        // Ale teraz chcemy rozszerzyć tą klasę o możliwość zapisywania 
        // plików do formatu txt, dodając tutaj kolejną metodę.

        // public void SaveToTxt() { }

        // Za każdym razem, kiedy rozszerzymy tą klasę o nowy rodzaj zapisu, to złamiemy OCP,
        // bo musimy zmodyfikować tą klasę aby dodać nową funkcjonalność.
        // Klasa ta też by łamała SRP, bo ta nie służy ona do zapisów.
        
        // Możemy utworzyć tutaj jedną metodę Save().
        // Teraz klasa DocumentProcessor nie zmieni swojego kodu, jeśli będziemy chcieli
        // dodać nową możliwość zapisu, czyli jest zamknięta na modyfikacje (nie dodajemy tu nowych metod)
        // i otwarta na rozszerzenie (możemy dodawać inne możliwości zapisu).
        public void Save(Document document, DocumentType saveTo)
        {
            var saver = _savers[saveTo];
            saver.Save(document);
        }
    }
}
