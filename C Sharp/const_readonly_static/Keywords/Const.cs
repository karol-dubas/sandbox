using System.Collections.Generic;

namespace const_readonly_static
{
    // 'const' i 'readonly' służą do deklarowania zmiennych niemodyfikowalnych
    class Const
    {
        // Wartość const jest przypisywana w czasie kompilacji,
        // więc można ją ustawić tylko w deklaracji
        public const int ConstField1 = 1;

        // Pole 'const' nie może być 'static', bo const również jest
        // "polem klasy" jak static, a nie obiektu.
        // const są static, tylko niejawnie
        ///static const int Field2 = 1;

        // Do const mogę przypisać typ wartościowy, 
        // i typ referenycjny = null, wyjątkiem jest string
        ///const List<int> list = new();
        const List<int> list = null;
        const string str1 = "test";

        public Const()
        {
            // Tylko w deklaracji
            //ConstField = 2;
        }
    }

    class ConstTest
    {
        Const instance = new();

        public ConstTest()
        {
            // const to nie pole obiektu, podobnie jak static, tylko pole klasy
            _ = Const.ConstField1;
            //_ = instance.Field1;
        }
    }
}
