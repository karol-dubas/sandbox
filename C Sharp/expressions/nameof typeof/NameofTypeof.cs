using System;
using System.Collections.Generic;

namespace expressions
{
    internal class NameofTypeof
    {
        public NameofTypeof()
        {
            // A nameof expression produces the name of a variable, type, or member as the string constant.
            var numbers = new List<int> { 1, 2, 3 };
            string str1 = nameof(numbers);  // numbers
            string str2 = nameof(numbers.Count);  // Count

            // The typeof operator obtains the System.Type instance for a type.
            Type type1 = typeof(string); // System.String
            Type type2 = typeof(List<int>); // System.Collections.Generic.List`1[[System.Int32..
            Type type3 = typeof(Program); // expressions.Program
            Type type4 = typeof(Dictionary<,>); // System.Collections.Generic.Dictionary`2[TKey,TValue]
        }
    }
}