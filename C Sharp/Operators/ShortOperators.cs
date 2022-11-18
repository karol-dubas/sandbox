using System;
using System.Collections.Generic;

namespace Operators
{
    internal class ShortOperators
    {
        public ShortOperators()
        {
            NullCoalescingOperator();
            ConditionalOperator(); // or 'ternary operator'
            NullConditionalOperator();
        }

        private void NullCoalescingOperator()
        {
            // ??
            // The null-coalescing operator ?? returns the value of its left-hand (nullable) operand if it isn't null;
            // otherwise, it evaluates the right-hand operand and returns its result.
            // The ?? operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.

            int? nullable = null;
            int b = nullable ?? 0;
            Console.WriteLine(b); // 0

            nullable = 1;
            int c = nullable ?? throw new Exception();
            Console.WriteLine(c); // 1

            // ??=
            // The null-coalescing assignment operator ??= assigns the value of its right-hand
            // operand to its left-hand operand only if the left-hand operand evaluates to null.
            // The ??= operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.

            // shorter version of
            // if (x is null) { x = y }

            List<int> numbers = null;
            numbers ??= new List<int>() { 1, 2, 3 };
        }

        private void ConditionalOperator()
        {
            // ?:
            // condition ? consequent : alternative
            // It is the short form of the if else conditions.

            int x = 1;
            bool condition = x == 1; // The condition expression must evaluate to true or false.
            string result = condition ? "x = 1" : "y != 1"; // x = 1
        }

        private void NullConditionalOperator()
        {
            // ?.
            // If one operation in a chain of conditional member or element access operations returns null,
            // the rest of the chain doesn't execute.

            // IntroduceYourself() is not called if person is null
            Person person = null;
            person?.IntroduceYourself();

            int? age = person?.Age;
        }
    }
}