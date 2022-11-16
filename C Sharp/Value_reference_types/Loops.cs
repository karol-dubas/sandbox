using System.Collections.Generic;

namespace Value_reference_types;

public class Loops
{
	public Loops()
	{
		var people = new List<Person>()
		{
			new Person("Karol"),
			new Person("Antoni"),
			new Person("Remigiusz"),
		};
		
		For(people); // zmiana na Jan
		ForEach(people); // zmiana na Mariusz
	}
	
	private void For(List<Person> people)
	{
		for (int i = 0; i < people.Count; i++)
		{
			people[i].FirstName = "Jan";
		}
	}
	
	private void ForEach(List<Person> people)
	{
		foreach (var person in people)
		{
			person.FirstName = "Mariusz";
		}
	}
}
