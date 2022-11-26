using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Module
{
    class Circle : IShape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; set; }

        public void Render()
        {
            Console.WriteLine("Rendering circle");
        }
    }
}
