using System;

namespace Attributes
{
    [AttributeUsage(
        AttributeTargets.Method | AttributeTargets.Class, // można użyć atrybutu Help na klasy i metody itd.
        AllowMultiple = false,
        Inherited = false)]
    // własny atrybut Help, można też nazwać HelpAttribute, nie musi miec końcówki ..Attribute
    class HelpAttribute : Attribute
    {
        protected string Description;

        public HelpAttribute(string description)
        {
            Description = description;
        }
    }
}
