using System;
using System.Diagnostics;

namespace Interface_and_abstract_class.UseCase
{
	public class UseCase
	{
		// - struktura:
		//		- interfejs mogę implementować w dowolnych klasach, oraz kilka dla jednej klasy
		//		- dziedziczyć można tylko po jednej klasie i tworzy się takie drzewo

		// - klasa abstrakcyjna daje więcej możliwości, możemy implementować:
		//		- konstruktor (z którego można skorzystać w klasie pochodnej, albo go nadpisać),
		//		- składowe w pełni, częściowo, albo wcale (virtual, abstract, override)
		//		- składowe nie tylko public
		//		- składowe statyczne
		//		- domyślne implementacje property/metod (interfejs też może, ale mało się używa)

		// - syntax: 
		//		- w interface składowe są 'public abstract' i nie trzeba tego pisać
		//		- implementując interface nie robimy override, mimo że domyślnie jest abstract

		public UseCase()
		{
			var textFile = new TextFile("text file");
			Console.WriteLine(textFile.Type); // txt
			textFile.Name = "new txt name";
			textFile.Owner = "Karol";
			textFile.Open();
			Console.WriteLine(TextFile.Counter); // 1

			var image = new Image("img file", new byte[420]);
			Console.WriteLine(image.Type); // jpg
			image.Source = new byte[1337];
			image.GetThumbnail();
			image.Open();
			Console.WriteLine(Image.Counter); // 2

			var exe = new ExecutableFile("exe file");
			Console.WriteLine(exe.Type); // exe
			exe.Open();
			Console.WriteLine(File.Counter); // 3
		}
	}
}
