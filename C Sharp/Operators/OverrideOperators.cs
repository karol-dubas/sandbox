namespace Operators
{
    internal class OverrideOperators
    {
        public OverrideOperators()
        {
            var ticket1 = new Ticket(60);
            var ticket2 = new Ticket(160);

            var ticket3 = ticket1 + ticket2;

            bool areEqual = ticket1 == ticket2;

            bool arentEqual = ticket1 != ticket2;
        }
    }
}