using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures
{
    class Program
    {
        static void Main()
        {
            // Collections diagram with examples:
            // https://akivamu.github.io/c-collections

            BasicDataStructures();
            IEnumerator_IEnumerable();
            IEnumerable_IQueryable();
        }

        private static void BasicDataStructures()
        {
            int[] array = new int[10];
            string[] daysOfTheWeek = { "pon", "wt", "sr", "czw", "pt", "so", "nd" };
            int[,] array2 = new int[2, 3]; //2 rows, 3 columns, matrix
            int[][] array3 = new int[3][]; // jagged array
            ArrayList arrayList = new ArrayList(); //lista z wszystkimi typami, wolniejsza, niegeneryczna
            List<int> list = new List<int>();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();
        }

        private static void IEnumerator_IEnumerable()
        {
            // Basically, all collections implement IEnumerable.
            // Tablica implementuje IEnumerable, dlatego można po niej iterować pętlami
            int[] array = new int[] { 1, 2, 3 };

            // Jeśli chcę iterować po jakimś zbiorze to używam 'enumeration'
            // Kolekcja musi implementować IEnumerable, aby użyć jej w foreach
            foreach (int number in array)
            {
                Console.WriteLine($"foreach: {number}");
            }

            // foreach jest kompilowany do takiej postaci:
            var enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"enumerator: {enumerator.Current}");
            }
        }

        private static void IEnumerable_IQueryable()
        {
            // IQueryable implementuje IEnumerable

            // Jeśli pobieram dane z bazy do IEnumerable, to pobierana jest cała tabela i później dane są filtrowane tutaj.
            // Używając IQueryable dane są foltrowane po stronie bazy danych.
        }
    }
}
