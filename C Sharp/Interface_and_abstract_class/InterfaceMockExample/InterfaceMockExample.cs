using System;

namespace Interface_and_abstract_class.InterfaceMockExample
{
	public class InterfaceMockExample
	{
		public InterfaceMockExample()
		{
			var repository = new PersonRepository();

			repository.UserDatabase = new UserDatabase();
			var user = repository.GetById(1);
			Console.WriteLine(user.Name); // Karol

			repository.UserDatabase = new UserDatabaseMock();
			var mockUser = repository.GetById(-1); // Nieważne co podamy, dostaniemy ten sam obiekt
			Console.WriteLine(mockUser.Name); // mock
		}
	}
}
