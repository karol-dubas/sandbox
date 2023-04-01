namespace Kata;

public partial class KataTests
{
	private static IEnumerable<object[]> GetNodes2()
	{
		ListNode first = new(3, new(4, new(5)));
		ListNode second = new(4, new(5, new(6)));
		
		var list = new List<(ListNode head, ListNode result)>()
		{
			(new(1, new(2, first)), first),
			(new(1, new(2, new(3, second))), second),
		};

		return list.Select(t => new object[] { t.head, t.result });
	}

	[TestCaseSource(nameof(GetNodes2))]
	public void MiddleNode(ListNode head, ListNode expected)
	{
		// Act
		var result = Kata.MiddleNode(head);
		
		// Assert
		Assert.That(expected, Is.EqualTo(result));
	}
}

public partial class Kata
{
	/// <summary>
	/// Returns middle node of the linked list.
	/// </summary>
	/// <param name="head">Head of a singly linked list.</param>
	/// <returns>
	/// Middle node of the linked list, If there are two middle nodes, return the second middle node.
	/// </returns>
	public static ListNode MiddleNode(ListNode head)
	{
		var slower = head;
		var faster = head;

		while (faster?.Next is not null)
		{
			slower = slower.Next;
			faster = faster.Next.Next;
		}
		
		return slower;
	}
}
