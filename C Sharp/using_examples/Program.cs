using System;
using System.IO;

namespace using_examples
{
    // https://www.youtube.com/watch?v=Scqq7rqDpnM
    // Używamy, w połączeniach z bazą danych, plikami itd.
    class Program
    {
        static void Main()
        {
            string path = @$"{Environment.CurrentDirectory}\file.txt";

            var readFileStream = new FileStream(path, FileMode.Open);

            // Nie można znowu otworzyć, bo plik jest używany przez poprzedni file stream
            // var readFileStream2 = new FileStream(path, FileMode.Open);

            readFileStream.Close();
            // Teraz mogę, bo poprzednie połączenie zostało zamknięte
            var readFileStream2 = new FileStream(path, FileMode.Open);
            byte[] buffer = new byte[10];
            readFileStream2.Read(buffer, 0, 4);
            readFileStream2.Close();

            // Rozwiązaniem jest użycie try finally
            var readFileStream3 = new FileStream(path, FileMode.Open);
            try
            {
                // W przypadku wystąpienia exception połączenie nie byłoby zamknięte
                throw new Exception();
            }
            finally
            {
                // Dzięki finally zawsze zamykamy połączenie
                readFileStream3.Close();
            }

            // Skrótem dla powyższego try finally jest using
            // using możemy użyć dla każdej klasy, która implementuje IDisposable
            using var readFileStream4 = new FileStream(path, FileMode.Open)
            {
                // readFileStream4.Read();
                // throw new Exception();
            };
            // Po zakończeniu bloku using zostanie zamknięte połączenie
            // nie ważne jaki będzie wynik operacji
        }
    }
}
