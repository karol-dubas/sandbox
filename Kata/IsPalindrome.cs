namespace Kata;

public partial class KataTests
{
	[TestCase("test", false)]
	[TestCase(" oko", true)] // trim spaces
	[TestCase("Anna ", true)] // upper/lower case
	[TestCase(" Kamil Ślimak ", true)]
	[TestCase("", false)]
	[TestCase(" ", false)]
	[TestCase(null, false)]
	public void IsPalindrome(string s, bool expected)
	{
		// Act
		bool result = Kata.IsPalindrome(s);
		bool result2 = Kata.IsPalindrome2(s);

		// Assert
		Assert.That(expected, Is.EqualTo(result));
		Assert.That(expected, Is.EqualTo(result2));
	}
}

public partial class Kata
{
    public static bool IsPalindrome(string s)
    {
	    if (string.IsNullOrWhiteSpace(s))
		    return false;

	    s = s.Replace(" ", string.Empty)
		    .ToLower();

	    return s == new string(s.ToCharArray().Reverse().ToArray());
    }

    public static bool IsPalindrome2(string s)
    {
	    if (s is null)
		    return false;
	    
	    int half = s.Length / 2;
	    for (int i = 0; i < half; i++)
	    {
	    	if (s[i] != s[^(i + 1)])
	    		return false;
	    }
	    
	    return true;
    }
}
