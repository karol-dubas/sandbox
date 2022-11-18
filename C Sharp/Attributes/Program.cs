using System;

namespace Attributes
{
    [Help("class")]
    class Program
    {
        // Tylko na metody i klasy
        //[Help("test")]
        public int Property { get; set; }
        
        [Help("method")]
        static void Main() { }
    }

    // Jak property nie ma w konstruktorze atrybutu, to trzeba ręcznie wpisać
    // np. jak tu Message = "..."
    [DebugInfo(1, "Karol", "03-03-2021", Message = "Jakiś błąd")]
    class TestClass
    {
    }
}
