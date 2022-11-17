namespace OOP.Inheritance
{
    public class Base
    {
        protected string BaseField;

        public Base()
        {
            BaseField = "Base ctor";
        }

        public Base(string param)
        {
            BaseField = $"Base ctor, param: {param}";
        }

        public void BaseMethod() { }
    }
}
