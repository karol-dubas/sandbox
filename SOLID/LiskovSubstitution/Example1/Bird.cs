using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Example1
{
    public class Bird : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Bird is eating");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
}
