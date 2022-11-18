using System;

namespace generics
{
    class GenericClass<TRef, TValue> 
        // Po where są 'generic limiters'
        where TValue : struct
        where TRef : class
    {
        public TValue Property { get; set; }

        public TRef Write(TRef input)
        {
            Console.WriteLine(input);
            return input;
        }
    }
}
