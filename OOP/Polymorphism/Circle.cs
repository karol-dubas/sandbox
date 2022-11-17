namespace OOP.Polymorphism;

public class Circle : Shape
{
	private readonly int _radius;

	public Circle(int radius)
	{
		_radius = radius;
	}

	public override double Area => Math.PI * (_radius * _radius);

	public override void Render()
	{
		Console.WriteLine("Rendering curved shape...");
	}
}

