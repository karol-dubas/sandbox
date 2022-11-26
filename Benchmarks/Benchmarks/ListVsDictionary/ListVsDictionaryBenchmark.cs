using BenchmarkDotNet.Attributes;

namespace Benchmarks.Benchmarks.ListVsDictionary;

[MemoryDiagnoser]
public class ListVsDictionaryBenchmark
{
	private People _people;

	[GlobalSetup]
	public void BeforeBenchmark()
	{
		_people = new People();
	}

	[Benchmark]
	public Person Linear_Array_First()
	{
		return LinearSerch(_people.ArrayWhereFirst);
	}

	[Benchmark]
	public Person Linear_Array_Middle()
	{
		return LinearSerch(_people.ArrayWhereMiddle);
	}

	[Benchmark]
	public Person Linear_Array_Last()
	{
		return LinearSerch(_people.ArrayWhereLast);
	}

	[Benchmark]
	public Person List_First()
	{
		return _people.ListWhereFirst.Find(p => p.Id == _people.WantedId);
	}

	[Benchmark]
	public Person List_Middle()
	{
		return _people.ListWhereMiddle.Find(p => p.Id == _people.WantedId);
	}

	[Benchmark]
	public Person List_Last()
	{
		return _people.ListWhereLast.Find(p => p.Id == _people.WantedId);
	}

	[Benchmark]
	public Person Dictionary_First()
	{
		return _people.DictionaryWhereFirst[_people.WantedId];
	}

	[Benchmark]
	public Person Dictionary_Middle()
	{
		return _people.DictionaryWhereMiddle[_people.WantedId];
	}

	[Benchmark]
	public Person Dictionary_Last()
	{
		return _people.DictionaryWhereLast[_people.WantedId];
	}

	private Person LinearSerch(Person[] people)
	{
		for (int i = 0; i < people.Length; i++)
		{
			if (people[i].Id == _people.WantedId)
				return people[i];
		}

		return null;
	}
}
