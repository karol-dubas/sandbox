using OOP.Polymorphism;

var shapes = new Shape[]
{
	new Rectangle(2, 3),
	new Circle(2)
};

foreach (Shape shape in shapes)
{
	Console.WriteLine($"area: {shape.Area}");
	shape.Render();
}