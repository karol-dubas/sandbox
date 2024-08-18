namespace FluentValidationDemo
{
    static class Program
    {
        private static void Main()
        {
            new Basics.Basics();
            new BuildInValidators.BuildInValidators();
            new ReUsingValidators.ReUsingValidators();
            new ListValidators.ListValidators();
            new PolymorphicValidatiors.PolymorphicValidatiors();
            new RuleSetAndOptions.RuleSetAndOptions();
            new WhenOtherwiseValidators.WhenOtherwiseValidators();
            new ExtensionValidators.ExtensionValidators();
        }
    }
}
