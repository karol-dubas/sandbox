using System;

namespace Operators
{
    internal class EqualsDifference
    {
        public EqualsDifference()
        {
            // Domyślnie == i Equals() wykonują to samo, przyjmuje się, że:
            // == porównuje referencje obiektów,
            // a Equals() ich wartości

            // W przypadku string zawsze porównywana jest wartość (pattern matching)
            string str1 = "test";
            string str2 = str1;
            string str3 = "test";

            Console.WriteLine(str1.Equals(str2)); // true
            Console.WriteLine(str1.Equals(str3)); // true
            Console.WriteLine(str1 == str2); // true
            Console.WriteLine(str1 == str3); // true

            // Typy prymitywne/wartościowe są domyślnie porównywane matematycznie
            int int1 = 10;
            int int2 = 10;

            Console.WriteLine(int1 == int2); // true
            Console.WriteLine(int1.Equals(int2)); // true

            // Typy referencyjne domyślnie porównywane są po referencji, bo nie wiadomo jak je porównać
            Person person1 = new("Karol", 22);
            Person person2 = new("Karol", 22);

            Console.WriteLine(person1 == person2); // false
            Console.WriteLine(person1.Equals(person2)); // false

            // Jeśli mają tę samą referencję, to domyślnie będzie 'true'
            Person person3 = person1;
            Console.WriteLine(person1 == person3); // true
            Console.WriteLine(person1.Equals(person3)); // true

            // == to operator C#, powinien porównywać obiekty technicznie, jak np. sprawdzać czy referencje są takie same,
            // Equals() to nadpisana metoda (OOP), powinna porównywać obiekty tak jak człowiek, poprzez znaczenie/związki.
            // Microsoft preferuje dokładnie takie użycie:
            object str4 = new string("test");
            object str5 = new string("test");
            Console.WriteLine(str4 == str5); // false, bo inne referencje
            Console.WriteLine(str4.Equals(str5)); // true, bo wartość taka sama

            object obj1 = null;
            object obj2 = null;
            
            // Equals() w przypadku null wyrzuci exception
            // Console.WriteLine(obj1.Equals(obj2));

            Console.WriteLine(obj1 == obj2); // true, bo oba nie mają wartości na stercie
        }
    }
}