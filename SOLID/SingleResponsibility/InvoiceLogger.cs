using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    // Ta klasa jest odpowiedzialna tylko za wyświetlanie faktury,
    // więc jeśli będzie taka potrzeba to robimy to w tej klasie i nie naruszamy SRP
    public class InvoiceLogger
    {
        private readonly Invoice _invoice;

        public InvoiceLogger(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void Display()
        {
            Console.WriteLine($"Vendor: {_invoice.Vendor}");
            Console.WriteLine($"Vendee: {_invoice.Vendee}");
            Console.WriteLine($"Total: {_invoice.Total}");
        }
    }
}
