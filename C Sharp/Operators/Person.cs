using System;

namespace Operators
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Hi, I'm {Name}");
            Console.WriteLine($"I'm {Age} yo");
        }
    }
}
