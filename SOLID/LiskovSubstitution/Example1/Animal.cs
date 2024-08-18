using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Example1
{
    public abstract class Animal
    {
        public abstract void Eat();

        // Nie możemy umieścić tu takiej metody, bo kot nie może latać
        // public abstract void Fly();
    }
}
