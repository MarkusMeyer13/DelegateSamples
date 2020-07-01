using System;

namespace DelegateSamples
{
    /// <summary>
    /// SampleDelegates.
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/anonymous-functions"/>
    internal class SampleDelegates
    {
        private delegate void TestDelegate(string s);
        private static void DelegateMethod(string s)
        {
            Console.WriteLine(s);
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        internal static void Execute()
        {
            // Original delegate syntax required
            // initialization with a named method.
            TestDelegate testDelA = new TestDelegate(DelegateMethod);

            // C# 2.0: A delegate can be initialized with
            // inline code, called an "anonymous method." This
            // method takes a string as an input parameter.
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };

            // C# 3.0. A delegate can be initialized with
            // a lambda expression. The lambda also takes a string
            // as an input parameter (x). The type of x is inferred by the compiler.
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };

            // Invoke the delegates.
            testDelA("Hello. My name is M and I write lines.");
            testDelB("That's nothing. I'm anonymous and ");
            testDelC("I'm a famous author.");
        }
    }
}
