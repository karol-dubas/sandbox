namespace Kata;

public partial class KataTests
{
	[TestCase(0, 1)]
	[TestCase(1, 1)]
	[TestCase(2, 2)]
	[TestCase(5, 120)]
	[TestCase(10, 3628800)]
	public void Factorial(int n, int expected)
	{
		// Act
		long result = Kata.Factorial(n);
		long result2 = Kata.RecursiveFactorial(n);
		
		// Assert
		Assert.That(expected, Is.EqualTo(result));
		Assert.That(expected, Is.EqualTo(result));
	}
}

public partial class Kata
{
	public static long RecursiveFactorial(int n)
	{
		return n == 0 ? 1 : n * RecursiveFactorial(n - 1);
	}

	public static long Factorial(int n)
	{
		if (n == 0)
			return 1;
		
		long value = n;

		while (--n > 1)
		{
			value *= n;
		}
		
		return value;
	}
}