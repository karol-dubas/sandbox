namespace OOP.Polymorphism;

public class Rectangle : Shape
{
	private readonly double _x;
	private readonly double _y;

	public Rectangle(double x, double y)
	{
		_x = x;
		_y = y;
	}

	public override double Area => _x * _y;
}

