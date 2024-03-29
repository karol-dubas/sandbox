﻿using System;

namespace generics
{
    public class CommonGeneric
    {
        public CommonGeneric()
        {
            var x1 = new GenericClass<string, int>();
            x1.Write("test");

            var x2 = new GenericClass<Random, double>();
            x2.Property = 6.9D;
        }

        private void GenericMethod<T>(T obj) where T : class
        {
            Console.WriteLine(obj);
        }
    }
}