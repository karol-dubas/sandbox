using Kata.Models;

namespace Kata;

public partial class KataTests
{
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
}

public partial class Kata
{
	/// <summary>
	/// Flatten tree by levels, left nodes first, then right
	/// </summary>
	/// <param name="node">Top node</param>
	/// <returns>Flettened tree values</returns>
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
}
