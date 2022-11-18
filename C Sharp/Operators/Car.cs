namespace Operators
{
    class Car
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public int HorsePower { get; set; }

        public override bool Equals(object obj)
        {
            // Możemy sprawdzić, czy np. Type, Brand, HorsePower są takie same i jeśli są równe to zwrócić true
            // ...
            
            // Domyślna implementacja zwróci false (sprawdzanie czy to te same obiekty)
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            // Używane w Dictionary i Hashtable
            return base.GetHashCode();
        }
    }
}
