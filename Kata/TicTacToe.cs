namespace Kata;

public partial class KataTests
{
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
}

public partial class Kata
{
	/// <summary>
	/// Analyze tic tac toe board.
	/// </summary>
	/// <param name="board">
	/// Current 2D board, where 0 is empty field and 1/2 are O/X values.
	/// Example <paramref name="board"/>, where 2 won:
	/// <code>
	/// new int[,]
	/// {
	///   { 2, 1, 1 },
	///   { 0, 2, 1 },
	///   { 0, 0, 2 }
	/// }
	/// </code>
	/// </param>
	/// <returns>
	/// -1 - in game, 0 - draw, 1/2 - score.
	/// </returns>
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
}
