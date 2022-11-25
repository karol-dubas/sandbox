using System;
using System.IO;

namespace DependencyInversion
{
	internal class Program
	{
		// Moduł wysokopoziomowy - UserManager
		// Moduły niskopoziomowe - implementacje ILogger 
		
		// Inwersja zależności służy do łączenia modułów oprogramowania, wszystkie zależności
		// wysokopoziomowych i niskopoziomowych modułów zostają odwrócone.

		// Moduły wysokiego poziomu nie powinny zależeć od modułów niskiego poziomu,
		// nie powinny być zależne od szczegółów implementacji modułów niskopoziomowych.
		
		// Moduły niskiego i wysokiego poziomu powinny zależeć od abstrakcji.

		private static void Main(string[] args)
		{
			var sw = GetWriter();
			var userManager = new UserManager(new FileLogger(sw));
			userManager.Login("test@test.com", "password");
		}

		private static StreamWriter GetWriter()
		{
			string path = @$"{Environment.CurrentDirectory}\logs.txt";
			using var sw = new StreamWriter(path);
			return sw;
		}
	}
}
