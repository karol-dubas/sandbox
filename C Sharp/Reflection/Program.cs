using System;
using System.Reflection;

namespace Reflection
{
	internal class Program
	{
		private static void Main()
		{
			var person = new Person
			{
				FirstName = "Karol",
				LastName = "Dubas",
			};

			Display(person);
		}

		private static void Display(object obj)
		{
			var type = obj.GetType();
			var properties = type.GetProperties();

			foreach (var property in properties)
			{
				object propValue = property.GetValue(obj);
				var propType = propValue.GetType();

				if ( /*propType.IsPrimitive ||*/ propType == typeof(string))
				{
					var displayPropertyAttribute = property.GetCustomAttribute<DisplayPropertyAttribute>();

					if (displayPropertyAttribute is not null)
						Console.WriteLine($"{displayPropertyAttribute.DisplayName}: {propValue}");

					Console.WriteLine($"{property.Name}: {propValue}");
				}
			}
		}
	}
}
