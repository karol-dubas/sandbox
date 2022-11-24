public class HpPrinter : IPrinter
{
	public void Print(string text)
	{
		TakePaper();
		HandlePrinting(text);
		ShowInfo();
	}

	private void TakePaper()
	{
		Console.WriteLine("Taking paper...");
	}

	private void HandlePrinting(string text)
	{
		Console.WriteLine($"Printing... {text}");
	}

	private void ShowInfo()
	{
		Console.WriteLine($"Printed");
	}
}
