﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Example1
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat is eating");
        }

        ///public override void Fly() { }
    }
}