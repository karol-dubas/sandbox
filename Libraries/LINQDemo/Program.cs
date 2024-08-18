using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace LINQ;

public class Program
{
	private static readonly IReadOnlyList<Person> People = PeopleFactory.GetPeople(1_000);

	private static void Main()
	{
		GetData();
		ProjectData();
		DivideData();
		OrderData();
		DataSetOperation();
		DataVerification();
		GroupDataWithOperations();
	}

	private static void GetData()
	{
		// First - pierwszy, jak nic to exception
		var first = People.First();
		HandleException(() => People.First(p => p.Id == -1)); // Exception, bo nie ma takiego
		
		// FirstOrDefault - pierwszy, jak nic to default
		var firstOrDefault = People.FirstOrDefault(p => p.Id == -1);

		// Last - działa jak First, tylko szuka od końca, jak nie znajdzie żadnego to exception
		var last = People.Last();
		HandleException(() => People.Last(p => p.Id == -1)); // Exception, bo nie ma takiego
		
		// LastOrDefault - jak nie znajdzie to default
		var lastOrDefault = People.LastOrDefault(p => p.Id == -1);
		
		// Single - tylko jeden element, jak więcej lub brak to exception
		var single = People.Single(p => p.Id == 1);
		HandleException(() => People.Single(p => p.Id == -1)); // Exception, bo nie ma takiego
		HandleException(() => People.Single(p => p.Id == 1 || p.Id == 2)); // Exception, bo więcej jak 1 element
		
		// SingleOrDefault - tylko jeden element, jak więcej to exception, jak brak to default
		HandleException(() => People.Single(p => p.Id == -1)); // Exception, bo nie ma takiego
		HandleException(() => People.Single()); // Exception, bo więcej jak 1 element
	}

	private static void ProjectData()
	{
		var names = People.Select(p => p.FirstName);

		// Projekcja na nowy obiekt (tu typ anonimowy, ale może być klasa np. DTO)
		var dto = People.Select(p => new
		{
			p.Id,
			p.Balance
		});

		// Spłaszczenie IEnumerable<List<string>> do IEnumerable<string>
		var notes = People.SelectMany(p => p.Notes);
	}

	private static void DivideData()
	{
		// Take/TakeLast - weź x pierwszych/ostatnich elementów
		var first5 = People.Take(5);
		var last5 = People.TakeLast(5);

		// Skip/SkipLast - pominie pierwsze/ostatnie x elementów, odwrotnie do Take
		var skip = People.Skip(5);
		var skipLast = People.SkipLast(5);

		// TakeWhile - będzie pobierać elementy, aż spotka false i przestanie,
		// działa inaczej niż Where, bo where działa do końca
		var takeWhile = People.TakeWhile(a => a.Balance > 50);
	}

	private static void OrderData()
	{
		// Zwraca IOrderedEnumerable<>, dzięki temu możemy nasstępnie użyć
		// ThenBy/ThenByDescending, jako 2 kryterium sortowania (gdy pojawią się 2 takie same wartości)
		var orderBy = People.OrderBy(a => a.Balance);
		var thenBy = orderBy.ThenByDescending(a => a.DateOfBirth);
	}

	private static void DataSetOperation()
	{
		string[] setA = new[] { "A", "A", "B" };
		string[] setB = new[] { "A", "B", "C" };
		
		// Distinct - wydobycie unikalnych wartości z kolekcji, jeśli jakieś są powielone
		var distinct = setA.Distinct();

		// DistinctBy - tak samo jak Distinct, tyko po danej wartości
		var distinctBy = People.DistinctBy(p => p.Gender);

		// Union - łączy dwa zbiory w jeden zbiór, jeśli elementy w dwóch zbiorach się pokrywają
		// to nie będą duplikowane, tylko pominięte
		var union = setA.Union(setB);

		// Intersect - łączy dwa zbiory w jeden zbiór, wynikiem jest część wspólna obu zbiorów,
		// czyli elementy, które się pokrywają w obu zbiorach
		var intersect = setA.Intersect(setB);

		// Except - A Except B, to będzie zbiór A z odjętymi elementami, które pokrywają się ze zbiorem B,
		// czyli od A odejmowany jest Intersect
		var except = setB.Except(setA);
	}

	private static void DataVerification()
	{
		// All - sprawdza czy wszystkie elementy spełniają warunek, zwraca bool
		bool all2 = People.All(p => p.Balance > 0);

		// Any - sprawdza, czy chociaż 1 element spełnia warunek
		bool any = People.Any(p => p.Notes.Count == 3);
		
		// Bez predykaty sprawdza, czy istnieje chociaż 1 element na liście
		bool any2 = People.Any();
	}

	private static void GroupDataWithOperations()
	{
		// GroupBy() grupuje dane po danym kluczu (rabi coś podobnego do dictionary)
		var groupBy = People.GroupBy(p => p.Gender);

		foreach (var group in groupBy)
		{
			int sum = group.Sum(p => p.Balance);
			double average = group.Average(p => p.Balance);
			int min = group.Min(p => p.Balance);
			int max = group.Max(p => p.Balance);
		}
	}

	private static void HandleException<T>(Func<T> func)
	{
		try
		{
			func();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
