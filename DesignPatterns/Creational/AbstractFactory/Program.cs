using System;
using AbstractFactory.Factories;

namespace AbstractFactory;

internal class Program
{
    // If something is created in the same way in many places, it makes sense to use one of the
    // factory patterns.

    private static void Main()
    {
        IFormatFactory randomFactory = Random.Shared.Next(2) == 1 ? new XmlFactory() : new JsonFactory();
        var converter = new ArrayConverter(randomFactory);

        int[] values = { 1, 2, 3 };
        string result = converter.Create(values);
        Console.WriteLine(result);
    }
}