using System;

namespace expressions.Events
{
    public class SampleClass
    {
        public SampleClass(Person person1)
        {
            // Przekazany tu obiekt person1 ma zmienioną nazwę, a event spowodował wywołanie
            // metod z klasy Example1, które tam do niego zostały podpięte
            person1.Name = "person1";

            var person2 = new Person();
            person2.NameChanged += Person2_NameChanged;
            person2.Name = "person2";
        }

        private void Person2_NameChanged(object sender, NameChangedEventArgs e)
        {
            Console.WriteLine($"Person2 name was changed from '{e.OldName}' to '{e.NewName}'");
        }
    }
}