using System.Collections.Generic;
using OpenClose.Class;

namespace OpenClose
{
	internal class Program
	{
		// Zasada otwartego zamkniętego mówi że elementy jak np. klasy i moduły
		// (zbiór klas pełniący jedną funkcję) powinny być otwarte na rozszerzenie i zamknięte na modyfikacje
		
		// Basically, we should strive to write a code that doesn’t
		// require modification every time a customer changes its request. 
		
		private static void Main(string[] args)
		{
			new Class.Class();
			new Module.Module();
		}
	}
}
