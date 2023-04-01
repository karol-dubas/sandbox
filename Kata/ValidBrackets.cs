namespace Kata;

public partial class KataTests
{
	[TestCase("a {([<>])}", ExpectedResult = true)]
	[TestCase("", ExpectedResult = true)]
	[TestCase("{})()", ExpectedResult = false)]
	[TestCase("(>", ExpectedResult = false)]
	[TestCase("(", ExpectedResult = false)]
	[TestCase(null, ExpectedResult = false)]
	public bool ValidBrackets(string input)
	{
		return Kata.ValidBrackets(input);
	}
}

public partial class Kata
{
	/// <summary>
	/// Checks if each opening bracket in the string has a closing counterpart.
	/// </summary>
	/// <returns>True if each opened bracked has closed counterpart, otherwise false.</returns>
	public static bool ValidBrackets(string input)
	{
		if (input is null)
			return false;

		var brackets = new Dictionary<char, char>
		{
			{ '<', '>' },
			{ '(', ')' },
			{ '[', ']' },
			{ '{', '}' }
		};

		Stack<char> openedBrackets = new();

		foreach (char c in input)
		{
			bool isOpeningBracket = brackets.ContainsKey(c);
			if (isOpeningBracket)
			{
				openedBrackets.Push(c);
				continue;
			}

			bool isClosingBracket = brackets.ContainsValue(c);
			if (!isClosingBracket)
				continue;

			if (!openedBrackets.Any())
				return false;

			var kvp = brackets.First(b => b.Value == c);

			bool lastEqualsCurrent = openedBrackets.Pop() == kvp.Key;
			if (!lastEqualsCurrent)
				return false;
		}

		return !openedBrackets.Any();
	}
}
