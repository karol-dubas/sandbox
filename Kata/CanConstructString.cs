namespace Kata;

public partial class KataTests
{
	[TestCase("a", "b", ExpectedResult = false)]
	[TestCase("aa", "ab", ExpectedResult = false)]
	[TestCase("aa", "aab", ExpectedResult = true)]
	[TestCase("a", "a", ExpectedResult = true)]
	[TestCase("tset", "test", ExpectedResult = true)]
	public bool CanConstruct(string ransomNote, string magazine)
	{
		return Kata.CanConstruct(ransomNote, magazine);
	}
}

public partial class Kata
{
	/// <summary>
	/// Determines whether a string can be created from another string value .
	/// </summary>
	/// <returns>
	/// True if <paramref name="ransomNote"/> can be constructed by using
	/// the letters from <paramref name="magazine"/> and false otherwise.
	/// </returns>
	public static bool CanConstruct(string ransomNote, string magazine)
	{
		var dict = new Dictionary<char, int>();

		foreach (char c in magazine)
		{
			if (!dict.ContainsKey(c))
				dict.Add(c, 1);
			else
				dict[c]++;
		}

		foreach (char c in ransomNote)
		{
			dict.TryGetValue(c, out int value);

			if (value == 0)
				return false;
			
			dict[c]--;
		}

		return true;
	}
}