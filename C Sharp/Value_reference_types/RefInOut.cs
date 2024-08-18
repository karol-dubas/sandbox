namespace Value_reference_types;

public class RefInOut
{
	public RefInOut()
	{
		int x = 0;
		int y;

		Person person = new("Karol");

		// Przesyłam tylko kopię, jest to typ wartościowy
		Normal(x); // x = 0

		// Przesyłam referencję (wskaźnik na wartość) i pracuję na oryginale.
		Ref(ref x); // x = 2

		// Aby przesłać wartość przez ref, musi być ona zaincjalizowana,
		// bo jak przesłać wartość której nie ma?
		// Ref(y); // nie zadziała

		// out działa odwrotnie do ref:
		// nie wymaga inicjalizacji zmiennej, ale wymaga zmianę wewnątrz metody
		Out(out x); // x = 3
		Out(out y); // y = 3
		Out(out int z); // z = 3
		Out(out person); // person.FirstName = "Jan"

		// in, to taki ref, albo zwkłe przekazanie, tylko zmnienna wewnątrz jest readonly
		// czyli po przekazaniu nie może się zmienić jej wartość, chyba że zmienimy pole tego obiektu.
		// Tak samo jak "readonly List<Person> people", jest readonly, a można operować metodami listy
		In(in x);
		In(in person); // person.FirstName = "Stanisław"
	}

	private void Normal(int param)
	{
		param = 1;
	}

	private void Ref(ref int param)
	{
		// Można, ale nie trzeba edytować parametru ref
		param = 2;
	}

	private void Out(out int param)
	{
		// out wymaga zmiany parametru wewnątrz metody 
		param = 3;
	}
	
	private void Out(out Person param)
	{
		// Nie zadziała, bo pierwsze trzeba przypisać wartość (utworzyć nowy obiekt)
		// param.FirstName = "Jan";

		param = new Person("Jan");
		param.FirstName = "Jan";
	}

	private void In(in int param)
	{
		// nie można zmienić wartości, jest tutaj readonly
		//param = 4;
		int temp = param;
	}
	
	private void In(in Person param)
	{
		//param = new Person("Stanisław");
		param.FirstName = "Stanisław";
		Person temp = param;
	}
}
