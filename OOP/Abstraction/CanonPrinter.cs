public class CanonPrinter : IPrinter
{
	public void Print(string text)
	{
		TakePaper();
		HandlePrinting(text);
	}

	private void TakePaper()
	{
		Console.WriteLine("Taking paper...");
	}

	private void HandlePrinting(string text)
	{
		Console.WriteLine($"Printing... {text}");
	}
}
