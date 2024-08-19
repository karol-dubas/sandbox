using Kata.Models;

namespace Kata;

public partial class KataTests
{
	private static IEnumerable<object[]> GetNodes()
	{
		var list = new List<(ListNode head, bool result)>()
		{
			(new(1), true),
			(new(1, new(2)), false),
			(new(1, new(2, new(2, new(1)))), true),
		};

		return list.Select(t => new object[] { t.head, t.result });
	}
	
	[TestCaseSource(nameof(GetNodes))]
	public void IsLinkedListPalindrome(ListNode head, bool expected)
	{
		// Act
		bool result = Kata.IsLinkedListPalindrome2(head);
		
		// Assert
		Assert.That(expected, Is.EqualTo(result));
	}
}

public partial class Kata
{
	/// <summary>
	/// Determines whether the linked list is a palindrome.
	/// </summary>
	/// <param name="head">Head of a singly linked list.</param>
	/// <returns>True if it is a palindrome, otherwise false.</returns>
	public static bool IsLinkedListPalindrome(ListNode head)
	{
		var list = new List<int>();
		list.Add(head.Value);

		while (head.Next is not null)
		{
			head = head.Next;
			list.Add(head.Value);
		}

		var copy = new List<int>(list);
		copy.Reverse();

		return copy.SequenceEqual(list);
	}

	public static bool IsLinkedListPalindrome2(ListNode head)
	{
		var list = new List<int>();
		list.Add(head.Value);

		while (head.Next is not null)
		{
			head = head.Next;
			list.Add(head.Value);
		}

		for (int i = 0; i < list.Count / 2; i++)
		{
			if (list[i] != list[list.Count - 1 - i])
				return false;
		}

		return true;
	}
}
