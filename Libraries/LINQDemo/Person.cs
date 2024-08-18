using System;
using System.Collections.Generic;
using Bogus.DataSets;
using Gender = Bogus.DataSets.Name.Gender;

namespace LINQ;

public class Person
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public Gender Gender { get; set; }
	public DateOnly DateOfBirth { get; set; }
	public int Balance { get; set; }
	public Address Address { get; set; }
	public List<string> Notes { get; set; }
}