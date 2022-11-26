using Kata.Models;

namespace Kata;

public class KataTests
{
    [TestCase(new[] { 1, 1, 2, 3, 1, 2, 3, 4 }, new[] { 1, 3 }, ExpectedResult = new[] { 2, 2, 4 })]
	[TestCase(new[] { 1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8 }, new[] { 1, 3, 4, 2 }, ExpectedResult = new[] { 5, 6, 7, 8 })]
	[TestCase(new int[] { }, new[] { 2, 2, 4, 3 }, ExpectedResult = new int[] { })]
	public static int[] RemoveFromList(int[] values, int[] valuestoRemove)
	{
		return Kata.RemoveFromList(values, valuestoRemove);
	}

	[TestCase(-1, ExpectedResult = 0)]
	[TestCase(1, ExpectedResult = 0)]
	[TestCase(10, ExpectedResult = 23)]
	public int Multiples(int input)
    {
        return Kata.Multiples(input);
	}

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

    [TestCase(new[] { 7 }, ExpectedResult = 7)]
    [TestCase(new[] { 0 }, ExpectedResult = 0)]
    [TestCase(new[] { 1, 1, 2 }, ExpectedResult = 2)]
    [TestCase(new[] { 0, 1, 0, 1, 0 }, ExpectedResult = 0)]
    [TestCase(new[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 }, ExpectedResult = 4)]
    [TestCase(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }, ExpectedResult = 5)]
    public int FindOddInt(int[] input)
    {
        return Kata.FindOddInt(input);
    }

    [TestCase("Welcome", ExpectedResult = "emocleW")]
    [TestCase("Hey fellow warriors", ExpectedResult = "Hey wollef sroirraw")]
    [TestCase("This is a test", ExpectedResult = "This is a test")]
    [TestCase("This is another test", ExpectedResult = "This is rehtona test")]
    [TestCase("You are almost to the last test", ExpectedResult = "You are tsomla to the last test")]
    [TestCase("Just kidding there is still one more", ExpectedResult = "Just gniddik ereht is llits one more")]
    public static string SpinWords(string input)
    {
        return Kata.SpinWords(input);
    }

    [TestCase(16, ExpectedResult = 7)]
    [TestCase(456, ExpectedResult = 6)]
    [TestCase(493193, ExpectedResult = 2)]
    public int DigitalRoot(int input)
    {
        return Kata.DigitalRoot(input);
    }

    [TestCase(new[] { 1, 2 }, new[] { 1 }, ExpectedResult = new[] { 2 })]
    [TestCase(new[] { 1, 2, 2 }, new[] { 1 }, ExpectedResult = new[] { 2, 2 })]
    [TestCase(new[] { 1, 2, 2 }, new[] { 2 }, ExpectedResult = new[] { 1 })]
    [TestCase(new[] { 1, 2, 2 }, new int[0], ExpectedResult = new[] { 1, 2, 2 })]
    [TestCase(new int[0], new[] { 1, 2 }, ExpectedResult = new int[0])]
    [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2 }, ExpectedResult =  new[] { 3 })]
    public int[] ArrayDiff(int[] input1, int[] input2)
    {
        return Kata.ArrayDiff(input1, input2);
    }

    [TestCase(new[] { int.MaxValue, 0, 1 }, ExpectedResult = 0)]
    [TestCase(new[] { 2, 6, 8, -10, 3 }, ExpectedResult = 3)]
    [TestCase(new[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 }, ExpectedResult = 206847684)]
    public static int FindOutlier(int[] input)
    {
        return Kata.FindOutlier(input);
    }

    [Test]
    public void MoveZeroes()
    {
        Assert.That(Kata.MoveZeroes(new[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }), Is.EqualTo(new[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }));
    }

    [TestCase(0, ExpectedResult = "00:00:00")]
    [TestCase(5, ExpectedResult = "00:00:05")]
    [TestCase(60, ExpectedResult = "00:01:00")]
    [TestCase(86399, ExpectedResult = "23:59:59")]
    [TestCase(359999, ExpectedResult = "99:59:59")]
    public string HumanReadableTest(int input)
    {
        return Kata.GetReadableTime(input);
    }

    [TestCase(255, 255, 255, ExpectedResult = "FFFFFF")]
    [TestCase(255, 255, 300, ExpectedResult = "FFFFFF")]
    [TestCase(0, 0, 0, ExpectedResult = "000000")]
    [TestCase(148, 0, 211, ExpectedResult = "9400D3")]
    [TestCase(148, -20, 211, ExpectedResult = "9400D3")]
    [TestCase(148, -20, 211, ExpectedResult = "9400D3")] // Handle negative numbers
    [TestCase(144, 195, 212, ExpectedResult = "90C3D4")]
    [TestCase(212, 53, 12, ExpectedResult = "D4350C")] // Consider single hex digit numbers
    public string Rgb(int r, int g, int b)
    {
        return Kata.Rgb(r, g, b);
    }

    [TestCase(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, ExpectedResult = 6)]
    [TestCase(new int[0], ExpectedResult = 0)]
    public int MaxSequence(int[] input)
    {
        return Kata.MaxSequence(input);
    }

    [TestCase("test", ExpectedResult = "grfg")]
    [TestCase("Test", ExpectedResult = "Grfg")]
    [TestCase("C# is cool!", ExpectedResult = "P# vf pbby!")]
    [TestCase("10+2 is twelve.", ExpectedResult = "10+2 vf gjryir.")]
    [TestCase("Du:'zO-NgHxQTHnduHJuAJDavpJuoCeEBa&EqCsqiyQbSp Q2T", ExpectedResult = "Qh:'mB-AtUkDGUaqhUWhNWQnicWhbPrROn&RdPfdvlDoFc D2G")]
    public string Rot13(string input)
    {
        return Kata.Rot13(input);
    }

    [TestCase("rkqodlw", "world", ExpectedResult = true)]
    [TestCase("cedewaraaossoqqyt", "codewars", ExpectedResult = true)]
    [TestCase("katas", "steak", ExpectedResult = false)]
    [TestCase("scriptjavx", "javascript", ExpectedResult = false)]
    [TestCase("scriptingjava", "javascript", ExpectedResult = true)]
    [TestCase("scriptsjava", "javascripts", ExpectedResult = true)]
    [TestCase("javscripts", "javascript", ExpectedResult = false)]
    [TestCase("aabbcamaomsccdd", "commas", ExpectedResult = true)]
    [TestCase("commas", "commas", ExpectedResult = true)]
    [TestCase("sammoc", "commas", ExpectedResult = true)]
    public bool Scramble(string input1, string input2)
    {
        return Kata.Scramble(input1, input2);
    }

    [TestCase(new[] { 4, 4, 4, 3, 3 }, ExpectedResult = 400)]
    [TestCase(new[] { 2, 3, 4, 6, 2 }, ExpectedResult = 0)]
    [TestCase(new[] { 2, 4, 4, 5, 4 }, ExpectedResult = 450)]
    public static int ShouldValueTriplets(int[] input)
    {
        return Kata.Score(input);
    }

    [TestCase(5, ExpectedResult = 1)]
    [TestCase(25, ExpectedResult = 6)]
    [TestCase(531, ExpectedResult = 131)]
    public int TrailingZeros(int input)
    {
        return Kata.TrailingZeros(input);
    }

    [TestCase((ulong)714, ExpectedResult = new ulong[] { 21, 34, 1 })]
    [TestCase((ulong)800, ExpectedResult = new ulong[] { 34, 55, 0 })]
    [TestCase((ulong)4895, ExpectedResult = new ulong[] { 55, 89, 1 })]
    public ulong[] ProductFib(ulong input)
    {
        return Kata.ProductFib(input);
    }

    [TestCase(1, 250, ExpectedResult = "[[1, 1], [42, 2500], [246, 84100]]")]
    [TestCase(42, 250, ExpectedResult = "[[42, 2500], [246, 84100]]")]
    [TestCase(250, 500, ExpectedResult = "[[287, 84100]]")]
    public string ListSquared(long m, long n)
    {
        return Kata.ListSquared(m, n);
    }

    [TestCase(5, ExpectedResult = 80)]
    [TestCase(7, ExpectedResult = 216)]
    public long Perimeter(long input)
    {
        return Kata.Perimeter(input);
    }
    
    [TestCase(new[] { -3, 7, 18, -2, 4, 4, 5, -2, 19, 10, 9, 3, 3, 7, 2, 0, 4, 3, 1 }, new[] { 2, 6, 8, 13, 16 }, new[] { 18, 5, 19, 7, 4 })]
    [TestCase(new[] { 10, 9, 1, 1, 4, 4, 1, 5, -5, 19, 19, 16, 5, 4, 10, 7, 12, -2 }, new[] { 4, 7, 9, 14, 16 }, new[] { 4, 5, 19, 10, 12 })]
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

    [Test]
    public void TreeByLevels()
    {
        // Arrange
        var input = new Node(new Node(null, new Node(null, null, 4), 2),
            new Node(new Node(null, null, 5),
                new Node(null, null, 6),
                3),
            1);

        int[] expected = { 1, 2, 3, 4, 5, 6 };

        // Act
        int[] result = Kata.TreeByLevels(input);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    private static IEnumerable<object[]> GetBoards()
    {
        List<(int[,] board, int result)> tuple = new()
        {
            (new[,]
            {
                { 1, 1, 1 },
                { 0, 2, 2 },
                { 0, 0, 0 }
            }, 1),
            (new[,]
            {
                { 2, 1, 1 },
                { 0, 2, 1 },
                { 0, 0, 2 }
            }, 2),
            (new[,]
            {
                { 1, 2, 1 },
                { 2, 1, 1 },
                { 2, 1, 2 }
            }, 0),
            (new[,]
            {
                { 2, 0, 2 },
                { 0, 1, 0 },
                { 1, 0, 0 }
            }, -1)
        };

        return tuple.Select(t => new object[] { t.board, t.result });
    }
    
    [TestCaseSource(nameof(GetBoards))]
    public void TicTacToe(int[,] board, int expected)
    {
        // Act
        int result = Kata.TicTacToe(board);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

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

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }
    
    [TestCase(1, "1")]
    [TestCase(52, "52")]
    [TestCase(98, "98")]
    [TestCase(3, "fizz")]
    [TestCase(9, "fizz")]
    [TestCase(5, "buzz")]
    [TestCase(50, "buzz")]
    [TestCase(15, "fizz buzz")]
    [TestCase(45, "fizz buzz")]
    public void FizzBuzz(int number, string expected)
    {
        // Act
        string result = Kata.FizzBuzz(number);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [TestCase("a {([<>])}", true)]
    [TestCase("", true)]
    [TestCase("{})()", false)]
    [TestCase("(>", false)]
    [TestCase("(", false)]
    [TestCase(null, false)]
    public void ValidBrackets(string input, bool expected)
    {
        // Act
        bool result = Kata.ValidBrackets(input);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }
}
