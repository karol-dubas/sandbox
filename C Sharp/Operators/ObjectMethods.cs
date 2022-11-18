using System;

namespace Operators
{
    // Każda klasa domyślnie i niejawnie tak dziedziczy po 'object'
    internal class ObjectMethods : object
    {
        public ObjectMethods()
        {
            // object zawiera metody np. Equals(), GetHashCode(), GetType(), ToString() itd.
            var car1 = new Car { Brand = "Ford", Type = "Mustang", HorsePower = 500 };
            var car2 = new Car { Brand = "Ford", Type = "Mustang", HorsePower = 500 };
            var car3 = new Car { Brand = "Fiat", Type = "Multipla", HorsePower = 90 };
            var car4 = car3;

            // Wartości HashCode 1 i 2 będą różne, bo są to różne miejsca w pamięci/inne obiekty
            Console.WriteLine(car1.GetHashCode());
            Console.WriteLine(car2.GetHashCode());
            
            // 3 i 4 wskazują na to samo miejsce w pamięci, więc HashCode będzie taki sam
            Console.WriteLine(car3.GetHashCode());
            Console.WriteLine(car4.GetHashCode());

            // Equals domyślnie działa jak porównanie HashCode, jeśli wskazuje na to samo miejsce w pamięci to true, inaczej false
            Console.WriteLine(car1.Equals(car2)); // false
            Console.WriteLine(car3.Equals(car4)); // true
        }
    }
}