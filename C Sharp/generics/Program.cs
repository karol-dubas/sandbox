namespace generics
{
    class Program
    {

        private static void Main()
        {
            new CommonGeneric();
            new GenericInterface();

            // Covariance (out - generic modifier)
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-generic-modifier

            // Contravariance (in - generic Modifier)
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/in-generic-modifier
        }
    }
}
