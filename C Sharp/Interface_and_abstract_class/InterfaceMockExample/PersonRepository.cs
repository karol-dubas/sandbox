namespace Interface_and_abstract_class.InterfaceMockExample
{
	public class PersonRepository
	{
		public IUserDatabase UserDatabase { get; set; }

		public User GetById(int userId)
		{
			return UserDatabase.Get(userId);
		}
	}
}
