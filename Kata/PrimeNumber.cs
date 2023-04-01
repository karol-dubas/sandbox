namespace Kata;

public partial class KataTests
{
	[TestCase(2, ExpectedResult = true)]
	[TestCase(3, ExpectedResult = true)]
	[TestCase(283, ExpectedResult = true)]
	[TestCase(2137, ExpectedResult = true)]
	[TestCase(7919, ExpectedResult = true)]
	[TestCase(1, ExpectedResult = false)]
	[TestCase(4, ExpectedResult = false)]
	[TestCase(7969, ExpectedResult = false)]
	public bool IsPrimeNumber(int number)
	{
		return Kata.IsPrimeNumber(number);
	}
}

public partial class Kata
{
	public static bool IsPrimeNumber(int number)
	{
		if (number == 1)
			return false;
		
		if (number == 2)
			return true;

		if (number % 2 == 0)
			return false;

		int squareRoot = (int)Math.Floor(Math.Sqrt(number));

		for (int i = 3; i < squareRoot; i += 2)
		{
			if (number % i == 0)
				return false;
		}

		return true;
	}
}
