using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    public class Tuples
    {
        public Tuples()
        {
            (double, int) t1 = (4.1, 2);
            Console.WriteLine($"Tuple with elements {t1.Item1}, {t1.Item2}");

            (int Age, double Weight) t2 = (22, 185);
            Console.WriteLine($"Tuple with elements {t2.Age}, {t2.Weight}");
            Console.WriteLine(t2.ToString());


            int[] array = new[] { 4, 7, 9 };
            var limits = FindMinMax(array);
            Console.WriteLine($"Limits of [{string.Join(" ", array)}] are {limits.min} and {limits.max}");
            // Output:
            // Limits of [4 7 9] are 4 and 9

            int[] array2 = new[] { -9, 0, 67, 100 };
            (int minimum, int maximum) = FindMinMax(array2);
            Console.WriteLine($"Limits of [{string.Join(" ", array2)}] are {minimum} and {maximum}");
            // Output:
            // Limits of [-9 0 67 100] are -9 and 100

            (int min, int max) FindMinMax(int[] input)
            {
                if (input is null || input.Length == 0)
                {
                    throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
                }

                int min = int.MaxValue;
                int max = int.MinValue;
                foreach (int i in input)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                    if (i > max)
                    {
                        max = i;
                    }
                }
                return (min, max);
            }
        }
    }
}
