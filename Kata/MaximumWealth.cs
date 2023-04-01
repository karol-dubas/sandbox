namespace Kata;

// https://leetcode.com/problems/richest-customer-wealth/

public partial class KataTests
{
	private static IEnumerable<object[]> GetData()
	{
		var list = new List<(int[][] balances, int result)>()
		{
			(new[]
			{
				new[]{ 1, 2, 3 },
				new[]{ 3, 2, 1 },
			}, 6),
			(new[]
			{
				new[]{ 1, 5 },
				new[]{ 7, 3 },
				new[]{ 3, 5 },
			}, 10),
			(new[]
			{
				new[]{ 2, 8, 7 },
				new[]{ 7, 1, 3 },
				new[]{ 1, 9, 5 },
			}, 17),
		};

		return list.Select(t => new object[] { t.balances, t.result });
	}
	
	[TestCaseSource(nameof(GetData))]
	public void MaximumWealth(int[][] accounts, int expected)
	{
		// Act
		int result = Kata.MaximumWealth(accounts);
		
		// Assert
		Assert.That(expected, Is.EqualTo(result));
	}
}

public partial class Kata
{
	public static int MaximumWealth(int[][] accounts)
	{
		int max = 0;
		
		foreach (int[] acc in accounts)
		{
			int sum = acc.Sum();

			if (sum > max)
				max = sum;
		}

		return max;
	}
}
