namespace Reflection
{
    class Person
    {
        [DisplayProperty("Imię")]
        public string FirstName { get; set; }

        [DisplayProperty("Nazwisko")]
        public string LastName { get; set; }
    }
}
