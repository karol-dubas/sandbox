using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Interfaces
{
    public interface IPrinter
    {
        void PrintMono(object content);
        void PrintColor(object content);
    }
}
