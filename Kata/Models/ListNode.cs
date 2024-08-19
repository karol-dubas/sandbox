namespace Kata.Models;

public class ListNode
{
	public ListNode Next { get; }
	public int Value { get; }

	public ListNode(int value = 0, ListNode next = null)
	{
		Value = value;
		Next = next;
	}
}