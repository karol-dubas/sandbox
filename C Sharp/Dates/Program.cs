using System;
using System.Globalization;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime();
            DateTimeOffset(); // lepszy DateTime
            TimeSpan();
            DateParse();
            DateFormatting();
        }

        private static void DateTime()
        {
            DateTime dt = new(1999, 3, 22, 8, 35, 0, DateTimeKind.Utc);

            // DateTime static fields:
            var now = System.DateTime.Now;
            // Czas uniwersalny UTC, do niego się dodaje/odejmuje np. +1/-6 do odpowiednich stref czasowych
            var utcNow = System.DateTime.UtcNow;
            var today = System.DateTime.Today; // bez godziny

            // Property Kind pokazduje jaki czas przechowujemy
            Console.WriteLine(now.Kind); // Local
            Console.WriteLine(utcNow.Kind); // Utc

            // Pokaże 1/2h różnicę, czyli jakie jest przesunięcie między polskim czasem, a UTC.
            // Nie można takich czasów ze sobą porównać
            Console.WriteLine($"{now} - {utcNow} = {now - utcNow}");
        }

        private static void DateTimeOffset()
        {
            // DateTimeOffset działa podobnie do DateTime, tylko lepiej, offset pokazuję różnicę w czasie do UTC
            var nowOffset = System.DateTimeOffset.Now; // pokazuje przesunięcie +1/2
            var nowUtcOffset = System.DateTimeOffset.UtcNow;

            Console.WriteLine($"{nowOffset} \toffset: {nowOffset.Offset}");
            Console.WriteLine($"{nowUtcOffset} \toffset: {nowUtcOffset.Offset}");

            // Teraz nie pokaże różnicy (tylko niedokładność komputera),
            // więc taki czas możemy ze sobą porównywać
            Console.WriteLine($"{nowOffset} - {nowUtcOffset} = {nowOffset - nowUtcOffset}");
        }

        private static void TimeSpan()
        {
            // TimeSpan is a struct that is used to represent time in days, hour, minutes, seconds, and milliseconds.
            TimeSpan oneDay = new TimeSpan(24, 0, 0); // 24h

            var now = System.DateTime.Now;
            DateTime tomorrow = now.Add(oneDay);
        }

        private static void DateParse()
        {
            // The Parse() and ParseExact() methods will throw an exception if the specified string is not a valid
            // representation of a date and time. So, it's recommended to use TryParse() or TryParseExact()
            // method because they return false if a string is not valid.
            bool isValidDate = System.DateTime.TryParse("31/03/2018", out DateTime result);

            if (isValidDate)
                Console.WriteLine(result.Kind); // pokaże Unspecified, bo nie wiadomo jaki to czas

            // Parse() i TryParse() nie mają formatu, jeśli chcemy go określić
            DateTimeOffset timeWithOffset = System.DateTimeOffset.ParseExact("08/12/1992 07.00.00 -05:00", "dd/MM/yyyy hh.mm.ss zzz", CultureInfo.InvariantCulture);
            DateTimeOffset timeWithOffsetUtc = timeWithOffset.UtcDateTime;
        }

        private static void DateFormatting()
        {
            var now = System.DateTime.Now;

            // Formatowanie dat
            Console.WriteLine(now); // 06/09/2021 14:10:36
            Console.WriteLine(now.ToShortDateString()); // 06/09/2021
            Console.WriteLine(now.ToLongDateString()); // 06 September 2021
            Console.WriteLine(now.ToString("g")); // 06/09/2021 14:14, dużo formatów do wyboru
            
            // Własne formaty:
            Console.WriteLine(now.ToString("yyyy.MM.dd")); // 2021.09.06
            Console.WriteLine(now.ToString("yyyy-MMM-ddd")); // 2021-Sep-Mon
            Console.WriteLine(now.ToString("MM.dd hh:mm:ss")); // 09.06 02:19:41
        }
    }
}
