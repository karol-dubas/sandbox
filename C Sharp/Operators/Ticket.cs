using System;

namespace Operators
{
    public class Ticket
    {
        public int DurationInMinutes { get; set; }
        public DateTime Created { get; set; }

        public Ticket(int durationInMinutes)
        {
            DurationInMinutes = durationInMinutes;
            Created = DateTime.Now;
        }

        public static Ticket operator +(Ticket a, Ticket b)
        {
            return new Ticket(a.DurationInMinutes + b.DurationInMinutes);
        }

        public static bool operator ==(Ticket a, Ticket b)
        {
            return a.DurationInMinutes == b.DurationInMinutes;
        }

        public static bool operator !=(Ticket a, Ticket b)
        {
            return a.DurationInMinutes != b.DurationInMinutes;
        }
    }
}
