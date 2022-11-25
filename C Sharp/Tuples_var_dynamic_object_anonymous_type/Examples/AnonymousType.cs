using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuples_var_dynamic_object_anonymous_type.Examples
{
    internal class AnonymousType
    {
        public AnonymousType()
        {
            // In C#, an anonymous type is a type (class) without any name that can contain public read-only properties only.
            // It cannot contain other members, such as fields, methods, events, etc.

            // The implicitly typed variable var is used to hold the reference of anonymous types.

            var person = new
            {
                FirstName = "Karol",
                LastName = "Dubas",
                Gender = 'M',
                Age = 21
            };

            IList<Student> studentList = new List<Student>() {
                new Student() { Id = 1, Name = "John", Age = 18 },
                new Student() { Id = 2, Name = "Steve",  Age = 21 },
                new Student() { Id = 3, Name = "Bill",  Age = 18 },
                new Student() { Id = 4, Name = "Ram" , Age = 20  },
                new Student() { Id = 5, Name = "Ron" , Age = 22 }
            };

            var oldestStudent = studentList
                .Select(s => new // Zamiana na typ anonimowy, bez podawania nazw prop
                {
                    s.Age,
                    StudentName = s.Name 
                }) 
                //.Select(s => new { Age = s.Age, Name = s.Name }) // Można dać nazwy prop, jeśli chemy inne
                .OrderByDescending(a => a.Age) // Sortuje już po typie anonimowym
                .FirstOrDefault();

            Console.WriteLine($"The oldest student is {oldestStudent.StudentName}, they are {oldestStudent.Age} years old");

            // Internally, all the anonymous types are directly derived from the System.Object class.
            // The compiler generates a class with some auto-generated name and applies the appropriate type to each property based on the value expression.
        }
    }
}