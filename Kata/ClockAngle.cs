namespace Kata;

public partial class KataTests
{
	// h [1-12]
	// m [0-59]
	// angle 0-180

	// 5m - 30 degrees

	[TestCase(12, 0, ExpectedResult = 0)]
	[TestCase(3, 15, ExpectedResult = 7.5)]
	[TestCase(12, 15, ExpectedResult = 82.5)]
	[TestCase(10, 30, ExpectedResult = 135)]
	public double FindAngleInTime(int hours, int mins)
	{
		return Kata.FindAngleInTime(hours, mins);
	}
}

public partial class Kata
{
	/// <summary>
	/// Determines the angle between the hands of the clock.
	/// </summary>
	/// <returns>Angle between the hands of the clock, for a given hour and mins.</returns>
	public static double FindAngleInTime(int hours, int mins)
	{
		double hourDegrees = 360 / 12 * hours + mins * (30 / 60.0);
		int minuteDegrees = 360 / 60 * mins;

		double angle = Math.Abs(hourDegrees - minuteDegrees);

		if (angle > 180)
			angle = 360 - angle;

		return angle;
	}
}
