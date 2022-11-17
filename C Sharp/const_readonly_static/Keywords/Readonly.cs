using System.Collections.Generic;

namespace const_readonly_static
{
    // 'const' i 'readonly' służą do deklarowania zmiennych niemodyfikowalnych.
    // Wartości 'readonly' raz przypisanej nie można zmienić
    // (chyba, że zainicjalizowaną, zmienić w konstruktorze)
    class Readonly
    {
        // Można przypisać wartość w deklaracji pola
        public readonly int ReadonlyField1 = 1;
        public readonly int ReadonlyField2;

        // Można przypisać typ referencyjny (do const nie)
        readonly List<int> _list = new() { 1, 2, 3 };

        public Readonly()
        {
            // Readonly można też przypisać w konstruktorze,
            // bo const, tylko w deklaracji
            ReadonlyField1 = 2;
            ReadonlyField2 = 2;
        }

        public void Method()
        {
            // Nie można przypisać w metodzie
            //ReadonlyField2 = 2;

            // Ale można coś dodać do listy
            _list.Add(3);

            // Za to tak jak wyżej z polem, nie moża zmienić obiektu
            ///_list = new List<int>();
        }
    }

    class ReadonlyTest
    {
        Readonly _instance = new();

        public ReadonlyTest()
        {
            // Pole 'readonly' to zwykłe niemodyfikowalne pole
            _ = _instance.ReadonlyField1;
            //instance.ReadonlyField1 = 2;

            // To nie pole klasy, jak static, tylko obiektu
            //_ = Readonly.ReadonlyField1;

            _instance.Method();
        }
    }
}
