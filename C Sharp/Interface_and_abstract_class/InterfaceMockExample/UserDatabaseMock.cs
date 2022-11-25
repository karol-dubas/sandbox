namespace Interface_and_abstract_class.InterfaceMockExample
{
	public class UserDatabaseMock : IUserDatabase
	{
		public User Get(int id)
		{
			return new User(0, "mock");
		}
	}
}
