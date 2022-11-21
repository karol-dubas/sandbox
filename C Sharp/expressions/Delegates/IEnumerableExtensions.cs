using System;
using System.Collections.Generic;

namespace expressions.Delegates
{
	public static class IEnumerableExtensions
	{
		// Func to delegata (wyrażenie lambda, które tu przychodzi), przyjmuje typ generyczny i zwraca bool
		public static TItem GetFirstOrDefault<TItem>(this IEnumerable<TItem> items, Func<TItem, bool> func)
		{
			foreach (var item in items)
			{
				// Tutaj dla każdego elementu jest uruchamiana metoda, która została tu przesłana jako delegat (Func).
				// W tym przypadku szukamy elementu na liście. Jeżeli element z listy się pokrywa z szukanym to delegat
				// zwraca true i wchodzimy do if'a i zwracamy szukany element. Jak zwróci false to szukamy dalej.
				if (func(item))
					return item;
			}

			// Jak nic nie znajdzie to zwracamy null, bo FirstOrDefault.
			return default;
		}
	}
}