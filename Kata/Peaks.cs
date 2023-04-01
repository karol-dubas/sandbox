namespace Kata;

// https://www.codewars.com/kata/5279f6fe5ab7f447890006a7/train/csharp

public partial class KataTests
{
	[TestCase(new[] { -3, 7, 18, -2, 4, 4, 5, -2, 19, 10, 9, 3, 3, 7, 2, 0, 4, 3, 1 }, new[] { 2, 6, 8, 13, 16 },
		new[] { 18, 5, 19, 7, 4 })]
	[TestCase(new[] { 10, 9, 1, 1, 4, 4, 1, 5, -5, 19, 19, 16, 5, 4, 10, 7, 12, -2 }, new[] { 4, 7, 9, 14, 16 },
		new[] { 4, 5, 19, 10, 12 })]
	[TestCase(new[] { 1, 2, 3, 6, 4, 1, 2, 3, 2, 1 }, new[] { 3, 7 }, new[] { 6, 3 })]
	[TestCase(new[] { 3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 3 }, new[] { 3, 7 }, new[] { 6, 3 })]
	[TestCase(new[] { 3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 2, 2, 1 }, new[] { 3, 7, 10 }, new[] { 6, 3, 2 })]
	[TestCase(new[] { 2, 1, 3, 1, 2, 2, 2, 2, 1 }, new[] { 2, 4 }, new[] { 3, 2 })]
	[TestCase(new[] { 2, 1, 3, 1, 2, 2, 2, 2 }, new[] { 2 }, new[] { 3 })]
	[TestCase(new[] { -2, -5, 5, 16, 4 }, new[] { 3 }, new[] { 16 })]
	public void GetPeaks(int[] array, int[] position, int[] peak)
	{
		// Arrange
		var expected = new Dictionary<string, List<int>>
		{
			["pos"] = position.ToList(),
			["peaks"] = peak.ToList()
		};

		// Act
		var actual = Kata.GetPeaks(array);

		// Assert
		Assert.That(actual, Is.EqualTo(expected));
	}
}

public partial class Kata
{
	public static Dictionary<string, List<int>> GetPeaks(int[] arr)
	{
		var result = new Dictionary<string, List<int>>
		{
			["pos"] = new(),
			["peaks"] = new()
		};

		for (int i = 1; i <= arr.Length - 2; i++)
		{
			// Peak found
			if (arr[i - 1] < arr[i] && arr[i + 1] < arr[i])
			{
				result["pos"].Add(i);
				result["peaks"].Add(arr[i]);
			}
			// Possible plateau peak found
			else if (arr[i - 1] == arr[i] && i - 2 >= 0)
			{
				if (arr[i - 2] >= arr[i])
					continue;

				int next = i + 1;

				// Take next number if equals previous
				while (arr[i] == arr[next] && next < arr.Length - 1)
					next++;

				if (arr[i] > arr[next])
				{
					result["pos"].Add(i - 1);
					result["peaks"].Add(arr[i]);
				}

				i = --next;
			}
		}

		return result;
	}
}
