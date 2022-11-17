using System;

namespace const_readonly_static
{
    public class StaticMembers
    {
        public int Field;

        // Pole static od const różni się tym,
        // że static można zmieniać, ale działają tak samo
        public static int StaticField;

        // Pole static może być też readonly
        public static readonly int StaticReadonlyField = 1;

        public void Method() 
        {
            // W zwykłej metodzie można odwołać się do wszystkich elementów
            Field = 1;
            StaticField = 1;
            StaticMethod();
        }
        public static void StaticMethod() 
        {
            // W metodach statycznych można używać tylko statycznych elementów
            //Field = 1;
            //Method();
            StaticField = 1;
        }

        // Wywoła się TYLKO RAZ jak zwykły konstruktor podczas tworzenia obiektu,
        // albo podczas użycia elementu statycznego (niejawnie stworzy się niedostępny obiekt)
        static StaticMembers()
        {
            // Konstruktor statyczny może ustawiać tylko statyczne elementy
            //Field = 2;

            // static readonly tylko w statycznym konstruktorze, albo przy inicjalizacji
            StaticReadonlyField = 2;
        }

        public StaticMembers()
        {
            //StaticReadonlyField = 2;
            Field = 2;
        }
    }

    // A static class can contain: static variables, static methods, static properties,
    // static operators, static events, and static constructors.
    // Klasa 'static' wymusza, aby wszystkie elementy były statyczne,
    // nie można po niej dziedziczyć (sealed) i nie może dziedziczyć
    public static class StaticClass
    {
        // W klasie statycznej nie można tworzyć instancji obiektów (wszystko musi być static)
        //int i = 2;
        //StaticMembers sm = new();

        //int Field;
        public static int Field;
        const int Field2 = 1;

        //void Method() { }
        public static void StaticMethod() { }

        // Nie może posiadać konstruktora do tworzenia obiektów, nie ma takiego domyślnie
        //public StaticClass() { }

        // Tylko konstruktor statyczny może być użyty w klasie statycznej,
        // który jest wywoływany podczas niejawnego utworzenia obiektu,
        // czyli w momencie odwołania się pierwszy raz do jakiegoś elementu
        // np. StaticClass.StaticMethod()
        static StaticClass()
        {
            Field = 2;
        }
    }

    class StaticTest
    {
        //StaticMembers instance = new();

        public StaticTest()
        {
            // static działa jak const, tylko można tą wartość mieniać (const to niejawnie static)

            // Do zwykłych elementów zwykłej klasy dostajemy się przez obiekt
            //instance.Method();
            //instance.Field = 1;

            // Do żadnego elementu static i const nie możemy dostać się przez obiekt, a przez klasę.
            // Wartości te są wspólne dla wszystkich instancji/obiektów tej klasy
            //instance.StaticField;
            //instance.StaticMethod();
            StaticMembers.StaticMethod();
            StaticClass.StaticMethod();
            StaticClass.Field = 1;

            // Nie można utworzyc obiektu statycznej klasy,
            // niejawnie tworzony jest obiekt, bez dostępu do konstruktora (musi być bezargumentowy)
            //StaticClass instance = new StaticClass();
        }
    }
}
