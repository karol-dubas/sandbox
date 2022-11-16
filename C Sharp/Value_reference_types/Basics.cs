using System;

namespace Value_reference_types;

public class Basics
{
	public Basics()
	{
		// Stos i sterta, krótki opis:
		/* Stos nie obchodzi programisty, jest utrzymywany przez system,
		 * deklarując zmienną trafia na stos i zostaje z niego usunięta, kiedy wypadnie poza klamry {}
		 *
		 * Na stertę trafiają wszystkie klasy i ich instancje, również interfejsy i tablice itp.
		 * nie zarządzana przez system, tylko .NET, elementy trafiające na stertę tworzone są
		 * operatorem 'new' (zazwyczaj). 
		 */
		
		ValueTypes();
		ReferenceTypes();
		ReferenceTypesStringsArrays();
		PassingVariablesToMethods();
	}

	private void ValueTypes()
	{
		/* Powszechny, podstawowy typ, kompilator alokuje odpowiednią ilość miejsca w pamięci do przechowania wartości zmiennej.
		 * Umieszczane są na stosie.
		 * Wszystkie typy wartościowe dziedziczą z klasy System.ValueType, program ma do nich szybki dostęp.
		 * Domyślnie są przekazywane przez wartość, czyli do funkcji przekazywana jest ich kopia.
		 * Mają niezmienną wielkość, czyli wiemy ile zajmą miejsca w pamięci. Nie mogą być null (domyślnie, bez nullable np. "int?").
		 *
		 * Lista typów wartościowych: 
		 * int, double, float, long, byte, char, bool, enum (struct).
		 */

		int value1 = 10;
		// Kopiowanie wartości, nie adresu na jaki wskazuje, 2 różne miejsca (zmienne) w pamięci
		int value2 = value1;

		Console.WriteLine($"Początkowe value1: {value1}"); // 10
		Console.WriteLine($"Skopiowane value2 z value1: {value2}"); // 10

		value2 = 20;

		Console.WriteLine($"Niezmienione value1: {value1}"); // 10
		Console.WriteLine($"Tylko value2 zmienione: {value2}"); // 20
	}

	private static void ReferenceTypes()
	{
		/* Umieszczany na stercie, referencja do pamięci umieszczana jest na stosie,
		 * a obszar pamięci do referencji znajduje się na stercie.
		 * Typami referencyjnymi są elementy, które rozszerzają klasę System.Object i System.String
		 * Mają zmienną wielkość, nie wiadomo ile miejsca w pamięci będzie zajmować klasa.
		 * Czyści je Garbage Collector. Domyślnie mogą być null do .NET 5
		 * 
		 * Przykłady:
		 * klasy, interfejsy, tablice, stringi.
		 */

		// Te zmienne są referencjami, ich wartościami jest adres pamięci
		// gdzie przechowywana jest wartość/instancja obiektu.
		Person person1 = new("Karol");

		// Kopiowany jest adres na jaki wskazuje person1, do zmiennej person2
		var person2 = person1;

		person1.PrintName(); // Karol
		person2.PrintName(); // Karol

		// Zmieniam imię 2 osoby, a 1 też się zmienia, bo obie zmienne wskazują na tą samą wartość na stercie
		person2.FirstName = "Marek";

		person1.PrintName(); // Marek
		person2.PrintName(); // Marek

		// Tak samo dla tablic
		int[] array1 = { 1, 2, 3 };
		int[] array2 = array1;

		// Zmienni również wartości w tab1.
		array2[0] = 4;
		array2[1] = 5;
		array2[2] = 6;

		// Ale gdybym przypisał nową tablicę do array2 np. array2 = new int[] { 7, 8, 9 },
		// to wartości array1 by się nie zmieniły, bo utworzona by była nowa tablica z nowym adresem na stosie
	}

	private static void ReferenceTypesStringsArrays()
	{
		// String, jest typem referencyjnym, ale zachowuje się jak wartościowy, jest to tablica char[]

		// Obie zmienne wskazują na tą samą wartość na stercie, kopiowany jest adres
		string str1 = "1";
		string str2 = str1;

		Console.WriteLine($"Początkowe str1: {str1}"); // 1
		Console.WriteLine($"Skopiowane str2 z str1: {str2}"); // 1

		// Ale tu tworzony jest nowy string, nie jak w przypadku innych typów referencyjnych, które wskazują na adres,
		// bo to tablica char[] - nie da się zmienić jej długości
		// również każda inna modyfikacja string powoduje utworzenie nowego stringa
		str2 = "2";

		// Strings are immutable the contents of a string object cannot be changed after the
		// object is created, although the syntax makes it appear as if you can do this.
		// For example, when you write this code, the compiler actually creates a new string object to
		// hold the new sequence of characters, and that new object is assigned to str2. The memory that had been
		// allocated for str2 (when it contained the string "1") is then eligible for garbage collection.

		Console.WriteLine($"Niezmienione str1: {str1}"); // 1
		Console.WriteLine($"Tylko str2 zmienione: {str2}"); // 2

		// Tak samo dla tablic
		int[] array3 = { 1, 2, 3 };
		int[] array4 = array3;

		// Zmieni tylko wartość array4, array3 zostanie takie same,
		// bo tworzony jest nowy obiekt tablicy, a nie zmieniana jest jej wartość,
		array4 = new[] { 4, 5, 6 };
		array4[0] = 7;
	}
	private static void PassingVariablesToMethods()
	{
		Person person3 = new("Arek");
		person3.PrintName(); // Arek

		/* Przekazanie referencji wartości obiektu, do metody przez wartość,
		*  czyli do metody trafia kopia referencji (wartość na stosie, która wskazuje obiekt na stercie),
		*  ale wskazuje na oryginalny obiekt na stercie, który faktycznie zmienia obiekt,
		*  bo person3 wskazuje na ten sam adres, który jest w metodzie.
		*/
		ChangePersonName(person3, "Maciek");
		person3.PrintName(); // Maciek

		/* Po wysłaniu typu wartościowego do metody, zostaje on skopiowany
		 * i wszystkie zmiany są dostępne tylko w tej metodzie,
		 * oryginalna wartość pozostaje niezmienna
		 */

		// Przekazanie referencji do obiektu, do metody przez referencję
		ChangePersonNameRef(ref person3, "Alfred");
		person3.PrintName(); // Alfred
	}

	// Taka metoda powinna się znajować w klasie Person,
	// ale tutaj demonstruję przykład różnych sposobów wysyłania obiektów
	public static void ChangePersonName(Person person, string newName)
	{
		// Zmienia wartość na stercie, czyli również poza tą metodą
		person.FirstName = newName;

		/* Wartość person (parametr) przesłana do metody zostanie zmieniona na nowy obiekt z FirstName = "Alfred", ale ten
		 * obiekt jest dostępny tylko w tej metodzie, tak samo jak w przypadku typów wartościowych.
		 * Zmieniam wartość referencji tylko dla tej metody, czyli oryginalna zmienna nie zostanie zmieniona na nowy obiekt.
		 */
		person = new Person("Alfred");
	}

	public static void ChangePersonNameRef(ref Person person, string newName)
	{
		// Tutaj obiekt (wartość na stercie) zostanie podmieniony
		person = new Person(newName);
	}
}
