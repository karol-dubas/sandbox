using System;

namespace generics
{
    public class GenericInterface
    {
        public GenericInterface()
        {
            IPoint<int> point = new Point(1, 1);
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);
        }
    }
}