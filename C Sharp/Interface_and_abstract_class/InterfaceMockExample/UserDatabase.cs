using System.Collections.Generic;
using System.Linq;

namespace Interface_and_abstract_class.InterfaceMockExample
{
	public class UserDatabase : IUserDatabase
	{
		private List<User> _users = new List<User>()
		{
			new User(1, "Karol"),
			new User(2, "Adam"),
			new User(3, "Stanisław"),
		};
		
		public User Get(int id)
		{
			return _users.First(u => u.Id == id);
		}
	}
}
