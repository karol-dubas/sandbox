using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Bogus.DataSets;
using Gender = Bogus.DataSets.Name.Gender;

namespace LINQ;

public static class PeopleFactory
{
	public static List<Person> GetPeople(int count)
	{
		return new Faker<Person>()
			.RuleFor(p => p.Id, f => f.IndexFaker)
			.RuleFor(p => p.FirstName, (f, p) => f.Name.FirstName(p.Gender))
			.RuleFor(p => p.LastName, (f, p) => f.Name.LastName(p.Gender))
			.RuleFor(p => p.Gender, f => f.PickRandom<Gender>())
			.RuleFor(p => p.DateOfBirth, f => f.Date.BetweenDateOnly(
				DateOnly.FromDateTime(DateTime.Now.AddYears(-90)),
				DateOnly.FromDateTime(DateTime.Now)))
			.RuleFor(p => p.Balance, f => f.Random.Int(0, 1_000))
			.RuleFor(p => p.Address, f => new Address
			{
				Country = f.Address.Country(),
				City = f.Address.City(),
				ZipCode = f.Address.ZipCode(),
				StreetName = f.Address.StreetName(),
				BuildingNumber = f.Address.BuildingNumber()
			})
			.RuleFor(p => p.Notes, f => Enumerable.Range(0, Random.Shared.Next(3))
				.Select(_ => f.Lorem.Sentence(Random.Shared.Next(3, 10)))
				.ToList())
			.Generate(count);
	}
}
