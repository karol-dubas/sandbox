using System;

namespace AutoMapper_examples
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }

    internal class UserDto
    {
        public string FullName { get; set; }
        public long Age { get; set; }
        public string Gender { get; set; }
        public int PropToIgnore { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Imię i nazwisko: {FullName}");
            Console.WriteLine($"Płeć: {Gender}");
            Console.WriteLine($"Wiek: {Age}");
        }
    }
}