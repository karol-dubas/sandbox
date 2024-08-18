using System;

namespace generics.Common
{
	public class User : IEntity
	{
		public User(Guid id, string name)
		{
			Id = id;
			Name = name;
		}
		
		public Guid Id { get; set; }
		public string Name { get; set; }
	}
}
