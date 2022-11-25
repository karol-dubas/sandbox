using System;

namespace DependencyInversion
{
	public class UserManager
	{
		// Dostarczenie niskopoziomowego modułu do tego wysokopoziomowego modułu realizowane
		// jest w tym przypadku przez dependency injection -> constructor injection
		private readonly ILogger _logger;
		public UserManager(ILogger logger)
		{
			_logger = logger;
		}
		
		public void Login(string email, string password)
		{
			Console.WriteLine("Logging in...");

			// Bez dependency inversion trzeba utworzyć takie silne powiązanie.
			// Moduł wysokopoziomowy UserManager jest zależny od niskopoziomowego modułu loggera.
			// Chcąc wybrać sposób w jaki logujemy dane trzeba zmienić implementację UserManager.
			var consoleLogger = new ConsoleLogger();
			consoleLogger.Log($"User with email: {email} logged in");

			// Ta klasa nie powinna mieć wpływu na to, w jaki sposób logujemy dane.
			// W taki sposób odwracamy zależność, implementacja zależy od abstrakcji.
			_logger.Log($"User with email: {email} logged in");
		}
	}
}