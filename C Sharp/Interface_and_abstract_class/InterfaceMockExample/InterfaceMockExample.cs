using System;

namespace Interface_and_abstract_class.InterfaceMockExample
{
	public class InterfaceMockExample
	{
		public InterfaceMockExample()
		{
			var service = new PersonRepository();

			service.UserDatabase = new UserDatabase();
			var user = service.GetById(1);
			Console.WriteLine(user.Name); // Karol

			service.UserDatabase = new MockUserDatabase();
			var mockUser = service.GetById(-1); // Nieważne co podamy, dostaniemy ten sam obiekt
			Console.WriteLine(mockUser.Name); // mock
		}
	}
}
