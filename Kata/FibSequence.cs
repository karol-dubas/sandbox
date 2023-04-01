namespace Kata;

public partial class KataTests
{
	[TestCase(0, 0)]
	[TestCase(1, 1)]
	[TestCase(2, 1)]
	[TestCase(3, 2)]
	[TestCase(4, 3)]
	[TestCase(10, 55)]
	[TestCase(15, 610)]
	[TestCase(30, 832040)]
	public void Fib(int input, int expected)
	{
		// Act
		int result = Kata.Fib(input);
		int recursiveResult = Kata.RecursiveFib(input);

		// Assert
		Assert.That(expected, Is.EqualTo(result));
		Assert.That(expected, Is.EqualTo(recursiveResult));
	}
}

public partial class Kata
{
	public static int Fib(int input)
	{
		if (input < 2)
			return input;

		int prev = 1;
		int curr = 1;

		for (int i = 2; i < input; i++)
		{
			int temp = curr;
			curr += prev;
			prev = temp;
		}

		return curr;
	}

	public static int RecursiveFib(int input)
	{
		if (input < 2)
			return input;

		int prev = RecursiveFib(input - 2);
		int curr = RecursiveFib(input - 1);

		return prev + curr;
	}
}