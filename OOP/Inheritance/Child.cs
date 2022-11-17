namespace OOP.Inheritance
{
    public class Child : Base
    {
        public Child()
        {
            BaseField = "Child ctor";
        }

        public Child(string param) : base(param)
        {
            BaseField = $"Child ctor, param: {param}";
        }

        public void ChildMethod() { }
    }
}
