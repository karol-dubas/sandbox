using System;
using System.Collections.Generic;

namespace Extensions
{
    // Extension methods używamy, gdy:
    // 1. Chcemy rozszerzyć dostarczone biblioteki, do których nie mamy dostępu, a nie chcemy po nich dziedziczyć i tworzyć nowych typów.
    // 2. Nie chcemy tworzyć project_dependencies w klasie, np. klasa Person to encja, nie chcę do niej dodawać metody, która dodaje tą osobę
    //      do bazy, tylko tworzę person.SaveChangesToDb(connString), jako extension, dzięki czemu klasa Person nic nie wie od bazie danych.
    // 3. Chcemy, aby klasy miały wspólne metody, ale nie mają one wspólnej bazy, w takim wypadku trzeba utowrzyć interfejs,
    //      i go rozszerzyć za pomocą extension, dzięki czemu, każda klasa, która implementuje taki interfejs ma dostęp
    //      do takich metod rozszerzeń (jak np. LINQ na IEnumerable<>).

    // Gdy jest taka możliwość, to tworzę zwykłe metody
    class Program
    {
        static void Main(string[] args)
        {
            // Extension methods are static methods,
            // but they're called as if they were instance methods on the extended type. 
            bool result = 10.IsGreaterThan(9);
            bool result2 = IsGreaterThan(10, 11);

            var list = new List<int> { 1, 2, 3 };
            list.AddZero();

            "wtf".WriteLine();
            
            // The only difference between a regular static method and an extension
            // method is that the first parameter of the extension method specifies
            // the type that it is going to operator on, preceded by the 'this' keyword
            Extensions.IsGreaterThan(10, 9);
        }

        static bool IsGreaterThan(int val1, int val2)
        {
            return val1 > val2;
        }
    }

    // To define an extension method, first of all, define a static class.
    static class Extensions
    {
        // An extension method is actually a special kind of static method defined in a static class.
        
        // The first parameter of the extension method specifies the type on
        //      which the extension method is applicable, preceded with the this modifier.
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static void AddZero(this List<int> i)
        {
            i.Add(0);
        }

        public static void WriteLine(this string s)
        {
            Console.WriteLine(s);
        }
    }
}
