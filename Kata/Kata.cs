using System.Diagnostics;
using System.Numerics;
using System.Text;
using Kata.Models;

namespace Kata;

public class Kata
{
	public static int[] RemoveFromList(int[] values, int[] valuestoRemove)
	{
		return values.Where(i => !valuestoRemove.Contains(i)).ToArray();
	}

	public static int Multiples(int value)
	{
		if (value < 0)
			return 0;

		int sum = 0;

		for (int i = 3; i < value; i++)
		{
			if (i % 3 == 0 || i % 5 == 0)
				sum += i;
		}

		return sum;
	}

	public static int Fib(int input)
	{
		if (input < 2)
			return input;

		int prev = 1;
		int curr = 1;

		for (int i = 2; i < input; i++)
		{
			int temp = curr;
			curr += prev;
			prev = temp;
		}

		return curr;
	}

	public static int RecursiveFib(int input)
	{
		if (input < 2)
			return input;

		int prev = RecursiveFib(input - 2);
		int curr = RecursiveFib(input - 1);

		return prev + curr;
	}

	public static int FindOddInt(int[] seq)
	{
		return seq.GroupBy(i => i)
			.First(i => i.Count() % 2 == 1)
			.Key;

		//Dictionary<int, int> numbers = new();

		//foreach (var num in seq)
		//{
		//    if (!numbers.ContainsKey(num))
		//    {
		//        numbers.Add(num, 1);
		//    }
		//    else
		//    {
		//        var kvp = numbers.Single(n => n.Key == num);
		//        numbers[kvp.Key]++;
		//    }
		//}

		//foreach (var kvp in numbers)
		//{
		//    if (kvp.Value % 2 == 1)
		//    {
		//        return kvp.Key;
		//    }
		//}

		//throw new ArgumentException("No odd int");
	}

	public static string SpinWords(string sentence)
	{
		var words = sentence.Split(' ')
			.Select(s => s.Length >= 5 ? new string(s.Reverse().ToArray()) : s);

		return string.Join(' ', words);
	}

	public static int DigitalRoot(long n)
	{
		while (n > 9)
		{
			n = (int)n.ToString()
				.Sum(char.GetNumericValue);
		}

		return (int)n;
	}

	public static int[] ArrayDiff(int[] a, int[] b)
	{
		return a.Where(x => !a.Intersect(b).Contains(x)).ToArray();
	}

	public static int FindOutlier(int[] integers)
	{
		return integers.Distinct()
			.GroupBy(i => i % 2)
			.Single(i => i.Count() == 1)
			.ElementAt(0);
	}

	public static int[] MoveZeroes(int[] array)
	{
		return array.OrderBy(x => x == 0).ToArray();

		// ##################################

		//return array.Where(n => n != 0)
		//    .Concat(array.Where(n => n == 0))
		//    .ToArray();

		// ##################################

		//List<int> list = new();

		//int[] zeros = array.Where(n => n == 0).ToArray();
		//list = array.Where(n => n != 0).ToList();
		//list.AddRange(zeros);

		//return list.ToArray();
	}

	public static string GetReadableTime(int seconds)
	{
		int minutes = seconds / 60;
		seconds %= 60;
		int hours = minutes / 60;
		minutes %= 60;

		return $"{hours:d2}:{minutes:d2}:{seconds:d2}";
	}

	public static string Rgb(int r, int g, int b)
	{
		return $"{DecimalToHex(r)}{DecimalToHex(g)}{DecimalToHex(b)}";
	}

	private static string DecimalToHex(int value)
	{
		value = value > 255 ? 255 : value < 0 ? 0 : value;
		return $"{value:X2}";
	}

	public static int MaxSequence(int[] arr)
	{
		int sum = 0;

		// Subarray start index
		for (int i = 0; i < arr.Length; i++)
			// Take arr[i + 1] 'l' ints from array to subarray
		for (int l = 1; l <= arr.Length - i; l++)
		{
			int[] subarray = new int[l];
			Array.Copy(arr, i, subarray, 0, l);

			int subarraySum = subarray.Sum();
			if (subarraySum > sum)
				sum = subarraySum;
		}

		return sum;
	}

	public static string Rot13(string message)
	{
		StringBuilder sb = new();

		foreach (char c in message)
		{
			if (!char.IsLetter(c))
			{
				sb.Append(c);
				continue;
			}

			char newChar = (char)(c + (char.ToLower(c) <= 'm' ? 13 : -13));
			sb.Append(newChar);
		}

		return sb.ToString();
	}

	public static bool Scramble(string str1, string str2)
	{
		var letters = str1.ToList();

		foreach (char c in str2)
		{
			if (!letters.Contains(c))
				return false;

			letters.Remove(c);
		}

		return true;
	}

	public static int Score(int[] dice)
	{
		int points = 0;

		var dict = dice.GroupBy(d => d)
			.ToDictionary(x => x.Key, x => x.Count());

		foreach (var group in dict)
		{
			if (group.Value < 3)
				continue;

			points += group.Key switch
			{
				1 => 1000,
				int i when i is >= 2 and <= 6 => i * 100,
				_ => throw new UnreachableException()
			};

			dict[group.Key] -= 3;
		}

		points += dict.Where(d => d.Key == 1)
			.Sum(x => x.Value * 100);

		points += dict.Where(d => d.Key == 5)
			.Sum(x => x.Value * 50);

		return points;
	}

	public static int TrailingZeros(int n)
	{
		int fives = 0;
		for (int i = 5; i <= n; i *= 5)
			fives += n / i;

		return fives;
	}

	public static ulong[] ProductFib(ulong prod)
	{
		ulong x = 0, y = 1, product = 0;

		while (product < prod)
		{
			y += x;
			x = y - x;
			product = x * y;
		}

		return new[] { x, y, (ulong)(prod == product ? 1 : 0) };
	}

	public static string ListSquared(long m, long n)
	{
		Dictionary<long, long> result = new();

		for (long i = m; i < n; i++)
		{
			long divisorsSum = 0;

			for (long j = i; j >= 1; j--)
			{
				if (i % j == 0)
					divisorsSum += (long)Math.Pow(j, 2);
			}

			double sqrt = Math.Sqrt(divisorsSum);

			if (sqrt == (long)sqrt)
				result.Add(i, divisorsSum);
		}

		return $"[{string.Join(", ", result.Select(r => $"[{r.Key}, {r.Value}]"))}]";
	}

	public static long Perimeter(long n)
	{
		long x = 0, y = 1, sides = 1;

		for (int i = 0; i < n; i++)
		{
			y += x;
			x = y - x;
			sides += y;
		}

		return sides * 4;
	}

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

	public static int[] TreeByLevels(Node node)
	{
		List<int> result = new();

		if (node is null)
			return Array.Empty<int>();

		Queue<Node> q = new();
		q.Enqueue(node);

		while (q.Any())
		{
			var next = q.Dequeue();

			if (next.Left is Node left)
				q.Enqueue(left);

			if (next.Right is Node right)
				q.Enqueue(right);

			result.Add(next.Value);
		}

		return result.ToArray();
	}

	public static int TicTacToe(int[,] board)
	{
		int[,,] winningLines =
		{	
			// (x,y)  0  1  2
			//    0 |--|--|--|
			//    1 |--|--|--|
			//    2 |--|--|--|
			
			// { x, y }
			{ { 0, 0 }, { 0, 1 }, { 0, 2 } },
			{ { 1, 0 }, { 1, 1 }, { 1, 2 } },
			{ { 2, 0 }, { 2, 1 }, { 2, 2 } },
			{ { 0, 0 }, { 1, 0 }, { 2, 0 } },
			{ { 0, 1 }, { 1, 1 }, { 2, 1 } },
			{ { 0, 2 }, { 1, 2 }, { 2, 2 } },
			{ { 0, 0 }, { 1, 1 }, { 2, 2 } },
			{ { 0, 2 }, { 1, 1 }, { 2, 0 } }
		};

		int[] line = new int[3];
		bool draw = true;

		for (int i = 0; i < winningLines.Length / 3 / 2; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				int x = winningLines[i, j, 0];
				int y = winningLines[i, j, 1];

				line[j] = board[x, y];

				if (board[x, y] == 0)
					draw = false;
			}

			if (line.All(n => n == 1))
				return 1;

			if (line.All(n => n == 2))
				return 2;
		}

		return draw ? 0 : -1;
	}

	public static bool IsPalindrome(string s)
	{
		if (string.IsNullOrWhiteSpace(s))
			return false;

		s = s.Replace(" ", string.Empty)
			.ToLower();
		
		// int half = s.Length / 2;
		// for (int i = 0; i < half; i++)
		// {
		// 	if (s[i] != s[^(i + 1)])
		// 		return false;
		// }
		//
		// return true;

		return s == new string(s.ToCharArray().Reverse().ToArray());
	}

	public static string FizzBuzz(int number)
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

