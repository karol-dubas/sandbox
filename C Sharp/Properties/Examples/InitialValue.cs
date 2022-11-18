namespace Properties
{
    public class InitialValue
    {
        public int Width { get; set; }
        public int Length { get; set; } = 1;

        private int _age = 1;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        
        public InitialValue()
        {
            Width = 1;

            // Kontruktor nadpisuje init property
            Length = 2;
        }
    }
}