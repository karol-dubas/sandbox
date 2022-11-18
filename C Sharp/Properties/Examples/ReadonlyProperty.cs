using System;

namespace Properties
{
	public class ReadonlyProperty
	{
		public string Name
		{
			get => "Karol";
		}

		// When you want to define a default property as a method
		// of other properties you can use expression body notation.
		public string Name2 => "Karol";

		// To property ma backing field
		public int Age { get; } = 20;

		// Żeby tak zrobić
		public string Name3 { get; } = name;
		// to pole 'name' musi być static, bo tworzony jest backing field

		public ReadonlyProperty()
		{
			// Te property nie mają backing fields ani settera, dlatego nie można im tu przypisać wartości
			// Name = "new name";
			// Name2 = "new name";

			// To property ma readonly backing field, a 'Name' i 'Name2' ich nie mają.
			// To przypisze temu ukrytemu readonly backing field, jak zwykłemy polu readonly (można w konstruktorze)
			Age = 21;

			TrySet();
		}

		public void TrySet()
		{
			// Nie można poza konstruktorem
			// Age = 22;
		}
		
		// readonly field vs property { get; }

		// This field can only be initialized/assigned in a constructor and it's value can't change for the lifetime of the class.
		private static readonly string name = "Karol";
		
		// A normal readonly property does not guarantee to return the same value every time it is called.
		// The value can change throughout the lifetime of the class. For example:
		// This will return a different number everytime you call it. (Yes, this is a terrible abuse of properties).
		public int RandomNumber => new Random().Next(10);
	}
}
