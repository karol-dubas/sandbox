namespace Kata;

// https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/

public partial class KataTests
{
	private static IEnumerable<object[]> GetMatrix()
	{
		var list = new List<(int[][] mat, int k, int[] expected)>
		{
			(new[]
			{
				new[] { 1, 1, 0, 0, 0 },
				new[] { 1, 1, 1, 1, 0 },
				new[] { 1, 0, 0, 0, 0 },
				new[] { 1, 1, 0, 0, 0 },
				new[] { 1, 1, 1, 1, 1 }
			}, 3, new[] { 2, 0, 3 }),
			(new[]
			{
				new[] { 1, 0, 0, 0 },
				new[] { 1, 1, 1, 1 },
				new[] { 1, 0, 0, 0 },
				new[] { 1, 0, 0, 0 },
			}, 2, new[] { 0, 2 })
		};

		return list.Select(t => new object[] { t.mat, t.k, t.expected });
	}

	[TestCaseSource(nameof(GetMatrix))]
	public void KWeakestRows(int[][] mat, int k, int[] expected)
	{
		// Act
		int[] result = Kata.KWeakestRows(mat, k);

		// Assert
		Assert.That(expected, Is.EqualTo(result));
	}
}

public partial class Kata
{
	public static int[] KWeakestRows(int[][] mat, int k)
	{
		var indexWithOnesCount = new Dictionary<int, int>();
		
		for (int i = 0; i < mat.Length; i++)
		{
			int j = 0;
			
			while (mat[i].Length > j && mat[i][j] == 1)
				j++;

			indexWithOnesCount.Add(i, j);
		}

		return indexWithOnesCount
			.OrderBy(kvp => kvp.Value)
			.Take(k)
			.Select(kvp => kvp.Key)
			.ToArray();
	}
}
