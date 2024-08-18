using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Invoice
    {
        public IEnumerable<LineItem> LineItems { get; set; }
        public string Vendor { get; set; } // sprzedawca
        public string Vendee { get; set; } // kupujący
        public float Total { get; set; }

        public Invoice(IEnumerable<LineItem> lineItems, string vendor, string vendee)
        {
            LineItems = lineItems;
            Vendor = vendor;
            Vendee = vendee;
            Total = CalculateTotal();
        }

        private float CalculateTotal()
        {
            float total = 0;

            foreach (var item in LineItems)
            {
                total += item.Price * item.Count * (1 + item.TaxRate);
            }

            return total;
        }

        // Chcę dodawać możliwość wyświetlania faktury w konsoli i zapisywania do pliku,
        // ale będę mieć takie odpowiedzialności w klasie:
        // 1. Przechowywanie danych
        // 2. Logowanie do konsoli
        // 3. Zapis do pdf
        // mając 3 odpowiedzialności klasy, mamy 3 powody do zmiany,
        // np. chcemy zmienić wyświetlanie faktury, to musimy zmienić klasę Invoice

        // Tworzę osobne klasy do tego celu.

        ///public void Display() { }
        ///public void SaveToPdf() { }

        // Takie inne częste odpowiedzialności to np.: walidacja, powiadamianie, zapis (baza, plik...), logika biznesowa
    }
}
