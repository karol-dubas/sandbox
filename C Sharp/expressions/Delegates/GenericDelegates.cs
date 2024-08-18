using System;

namespace expressions.Delegates
{
	public class GenericDelegates
	{
		public GenericDelegates()
		{
			// Przyjmuje wartości i nic nie zwraca
			Action action = Console.WriteLine;
			action();

			// Przyjmuje wartości i zwraca bool
			Predicate<int> predicate = x => x > 10;
			bool greaterThan10 = predicate(11);

			// Przyjmuje wartości i zwraca dowolny typ
			Func<int, int> func = x => x * x;
			int square = func(5);
		}
	}
}
