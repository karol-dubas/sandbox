using System.Text;

namespace Kata;

public partial class KataTests
{
	[TestCase(1, ExpectedResult = "1")]
	[TestCase(52, ExpectedResult = "52")]
	[TestCase(98, ExpectedResult = "98")]
	[TestCase(3, ExpectedResult = "fizz")]
	[TestCase(9, ExpectedResult = "fizz")]
	[TestCase(5, ExpectedResult = "buzz")]
	[TestCase(50, ExpectedResult = "buzz")]
	[TestCase(15, ExpectedResult = "fizz buzz")]
	[TestCase(45, ExpectedResult = "fizz buzz")]
	public string FizzBuzz(int number)
	{
		return Kata.FizzBuzz(number);
	}
}

public partial class Kata
{
	public static string FizzBuzz(int number)
	{
		if (number % 3 == 0 && number % 5 == 0)
			return "fizz buzz";

		if (number % 3 == 0)
			return "fizz";
		
		if (number % 5 == 0)
			return "buzz";

		return number.ToString();
	}

	public static string FizzBuzz2(int number)
	{
		StringBuilder sb = new();

		if (number % 3 == 0)
			sb.Append("fizz");
		if (number % 5 == 0)
			sb.Append(" buzz");

		if (sb.Length == 0)
			sb.Append(number);

		return sb.ToString().Trim();
	}
}
