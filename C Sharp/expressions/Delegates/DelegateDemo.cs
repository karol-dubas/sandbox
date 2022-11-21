using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expressions.Delegates
{
    public class DelegateDemo
    {
        public DelegateDemo()
        {
            // Invoking normal method
            int normalMethodInvoke = Increment(1);

            // Create an instance of the delegate
            var normalMethodDelegate = new Manipulate(Increment);
            int normalMethodResult = normalMethodDelegate(1);
            int normalMethodResult2 = normalMethodDelegate.Invoke(2);

            // Pass a method as a variable
            int anotherResult = Get2(Increment);

            // Anonymous method is a delegate () { } and it returns a delegate
            Manipulate anonymousMethodDelegate = delegate(int input)
            {
                return input + 1;
            };

            int anonymousResult = anonymousMethodDelegate(2);

            // Lambda expression are anything with => and a left/right value
            // They can return a delegate (invoke a method)
            Manipulate lambdaDelegate = a => a * 2;
            int lambdaResult = lambdaDelegate(5);

            // Jeśli dodaję { } to i tak muszę napisać 'return',
            // chyba, że nic nie zwracam
            Manipulate lambdaDelegate2 = (a) =>
            {
                return a * 2;
            };

            // An Action is a delegate with no return type and optional input
            Action action = () =>
            {
                Console.WriteLine($"Action");
            };
            
            Action<int> actionWithInput = (a) =>
            {
                Console.WriteLine($"Action input: {a}");
            };

            // A Func is a delegate with a return type and optional input
            Func<int> func = () => 2;
            func();
            
            Func<int, int> funcWithInput = n => n + 1;
            funcWithInput(2);
            
            Func<int, int> funcWithInput2 = Increment;
            funcWithInput2(2);

            // Mimic the FirstOrDefault Linq expression
            string[] items = new string[] { "a", "b", "c", "d", "e", "f" };
            // Przesyłam lambdę do extension method
            string foundItem = items.GetFirstOrDefault<string>(i => i == "c");
        }

        private int Increment(int number)
        {
            return number + 1;
        }

        private int Get2(Manipulate method)
        {
            return method(1);
        }
    }
}
