namespace OOP.Polymorphism;

public abstract class Shape
{
	// Cała klasa musi być abstract, bo jak stworzyć obiekt, bez implementacji metody?
	// Składowe abstract trzeba nadpisać w klasach pochodnych z własną implementacją.
	// Deklaracja nie może zawierać ciała.
	public abstract double Area { get; }

	// Składowe virtual można nadpisać, jeśli nie nadpiszę, to wywoła się metoda bazowa (ta)
	public virtual void Render()
	{
		Console.WriteLine("Rendering shape...");
	}
}
