using expressions.Events;
using System;

namespace expressions.Events
{
    public class EventDemo
    {
        public EventDemo()
        {
            // delegaty - https://www.youtube.com/watch?v=DKVGiJAhNrU
            // eventy - https://youtu.be/LQObNWAPzeI

            var person1 = new Person();

            // Metody podpinane do obiektu, zostaną wywołane podczas
            // użycia 'NameChanged(this, args)' w klasie Person.

            // Można podpinać na 2 sposoby.
            //person1.NameChanged += new NameChanged(PrintChange);
            person1.NameChanged += PrintChange;
            person1.NameChanged += SendEmail;
            person1.NameChanged -= SendEmail;
            person1.NameChanged += SendEmail;
            //person1.NameChanged = null;

            new SampleClass(person1);

            person1.Name = "Karol";
            person1.Name = "Maciek";
        }

        // Każda metoda musi zwracać i przyjmować takie same typy jak przy deklaracji delegatu.
        private static void PrintChange(object sender, NameChangedEventArgs e)
        {
            Console.WriteLine($"Person1 name was changed from '{e.OldName}' to '{e.NewName}'");
        }

        private static void SendEmail(object sender, NameChangedEventArgs e)
        {
            Console.WriteLine("Email sent");
        }
    }
}