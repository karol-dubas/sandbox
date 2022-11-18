using System;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? int1 = null;
            int int2 = 1;
            int? int3 = 2;

            // int1.Value property:
            // https://stackoverflow.com/questions/5405865/c-sharp-nullable-types-and-the-value-property

            Console.WriteLine(int1); // null
            Console.WriteLine(int2); // 1

            if (int3.HasValue)
            {
                Console.WriteLine(int3.Value); // 2
            }

            // Typy referencyjne domyślnie są nullable (C# 8.0+)
            string? string1 = null;
            Person? p1 = null;

            string string2 = null;
            Person p2 = null;
        }
    }

    class Person { }
}
