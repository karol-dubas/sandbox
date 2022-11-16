using System;

namespace Value_reference_types
{
    public class Person
    {
        public string FirstName { get; set; }

        public Person(string firstName)
        {
            this.FirstName = firstName;
        }

        public void PrintName()
        {
            Console.WriteLine($"Imię to: {FirstName}");
        }
    }
}
