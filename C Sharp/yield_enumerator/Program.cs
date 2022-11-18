using System;
using System.Collections.Generic;

namespace yield_enumerator
{
    class Program
    {
        static IEnumerable<int> GetData()
        {
            Console.WriteLine("GetData start");
            var result = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"result.Add({i})");
                result.Add(i);
            }

            Console.WriteLine("GetData end");
            return result;
        }

        static IEnumerable<int> GetYieldedData()
        {
            Console.WriteLine("GetYieldedData start");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"yield return {i}");
                yield return i;
            }

            // Kod poniżej i tak się nie wykona przez przerwanie iteracji w Main
            Console.WriteLine("GetYieldedData end");
            yield break; // W tym przypadku niepotrzebne
        }

        static void Main()
        {
            GetData(); // Metoda zostaje normalnie wywołana
            GetYieldedData(); // Metoda nie zostaje wywołana, dopóki nie iterujemy po elementach

            Console.WriteLine("\nMain GetData foreach start");
            foreach (int item in GetData())
            {
                Console.WriteLine($"Main foreach: {item}");
            }

            // Teraz zostaje wywołana
            Console.WriteLine("\nMain GetYieldedData foreach start");
            foreach (int item in GetYieldedData())
            {
                // Po każdym yield return wraca do tego foreach
                Console.WriteLine($"Main foreach: {item}");

                // Przerwie wykonanie GetYieldedData i przestanie zwracać elementy,
                // a lista zwróciłaby wszystkie elementy
                if (item > 2)
                {
                    break;
                }
            }
        }
    }
}
