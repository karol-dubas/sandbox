using System;

namespace generics.Common;

public class Book : IEntity
{
	public Guid Id { get; set; }
	public string Title { get; set; }
}
