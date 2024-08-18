using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Printer2 : IPrinter, IScanner
    {
        // Ta drukarka nie ma możliwości wysyłania fax, więc interfejs IPrinter musi zostać rozbity na mniejsze
        ///public void Fax(object content) { }

        public void PrintColor(object content)
        {
            Console.WriteLine("Printer2 printing color");
        }

        public void PrintMono(object content)
        {
            Console.WriteLine("Printer2 printing mono");
        }

        public void Scan(object content)
        {
            Console.WriteLine("Printer2 scanning");
        }
    }
}
