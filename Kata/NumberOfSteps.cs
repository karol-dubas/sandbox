namespace Kata;

// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/

public partial class KataTests
{
	[TestCase(0, ExpectedResult = 0)]
	[TestCase(8, ExpectedResult = 4)]
	[TestCase(14, ExpectedResult = 6)]
	[TestCase(123, ExpectedResult = 12)]
	public int NumberOfSteps(int num)
	{
		return Kata.NumberOfSteps(num);
	}
}

public partial class Kata
{
	public static int NumberOfSteps(int num)
	{
		if (num == 0)
			return 0;
		
		int count = -1;

		while (num > 0)
		{
			count = num % 2 == 0 ? count + 1 : count + 2;
			num /= 2;
		}

		return count;
	}
}
