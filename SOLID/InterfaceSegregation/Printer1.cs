using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Printer1 : IPrinter, IFax, IScanner
    {
        public void Fax(object content)
        {
            Console.WriteLine("Printer1 sending fax");
        }

        public void PrintColor(object content)
        {
            Console.WriteLine("Printer1 printing color");
        }

        public void PrintMono(object content)
        {
            Console.WriteLine("Printer1 printing mono");
        }

        public void Scan(object content)
        {
            Console.WriteLine("Printer1 scanning");
        }
    }
}
