namespace Properties
{
    public class PropertyAccessors
    {
        // Only the getter remains public, while the setter becomes private.
        // This approach is used to make properties that can be written only from inside of the class.
        public int MyProperty { get; private set; }

        // Newer versions of C# give you a closely related construct
        // which lets you make your property read-only. This is similar to { get; private set; }
        // but in addition it restricts all assignments of MyProperty2 to the constructor of its containing class.
        public int MyProperty2 { get; }
        
        // Both properties are inaccessible to external classes

        public PropertyAccessors()
        {
            MyProperty = 1;
            MyProperty2 = 1;
            
            TrySet();
        }

        public void TrySet()
        {
            MyProperty = 1;

            // Only in constructor
            // MyProperty2 = 1;
        }
    }
}