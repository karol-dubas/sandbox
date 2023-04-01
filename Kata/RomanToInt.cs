namespace Kata;

// 

public partial class KataTests
{
	[TestCase("III", 3)]
	[TestCase("LVIII", 58)]
	[TestCase("MCMXCIV", 1994)]
	public void RomanToInt(string s, int expected)
	{
		// Act
		int result = Kata.RomanToInt2(s);

		// Assert
		Assert.That(expected, Is.EqualTo(result));
	}
}

public partial class Kata
{
	/// <summary>
	/// Translates Roman string to integer value.
	/// </summary>
	/// <param name="s">Roman string.</param>
	/// <returns>Integer value.</returns>
	public static int RomanToInt(string s)
	{
		// s.length range [1, 15]
		// s is a valid roman numeral in the range [1, 3999].

		var numerals = new Dictionary<char, int>()
		{
			['I'] = 1,
			['V'] = 5,
			['X'] = 10,
			['L'] = 50,
			['C'] = 100,
			['D'] = 500,
			['M'] = 1000,
		};

		var subtractions = new Dictionary<string, int>()
		{
			["IV"] = 4,
			["IX"] = 9,
			["XL"] = 40,
			["XC"] = 90,
			["CD"] = 400,
			["CM"] = 900,
		};

		int value = 0;

		char[] array = s.ToCharArray();

		for (int i = 0; i < array.Length; i++)
		{
			int next = i + 1;
			if (next < array.Length)
			{
				string str = string.Concat(array[i], array[next]);

				if (subtractions.ContainsKey(str))
				{
					value += subtractions[str];
					i++;
					continue;
				}
			}

			value += numerals[array[i]];
		}

		return value;
	}

	// The numbers are arranged from largest to smallest,
	// so if there is a larger number after the smaller one,
	// subtract the smaller one from the value
	public static int RomanToInt2(string s)
	{
		var numerals = new Dictionary<char, int>()
		{
			['I'] = 1,
			['V'] = 5,
			['X'] = 10,
			['L'] = 50,
			['C'] = 100,
			['D'] = 500,
			['M'] = 1000,
		};
		
		int value = 0;

		for (int i = 0; i < s.Length; i++)
		{
			char current = s[i];
			
			if (i + 1 != s.Length)
			{
				char next = s[i + 1];
				
				if (numerals[current] < numerals[next])
				{
					value -= numerals[current];
					continue;
				}
			}

			value += numerals[current];
		}
		
		return value;
	}
}
