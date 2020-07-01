using System;

namespace DelegateSamples
{
    internal class GreetingSample
    {
        private delegate void GreetingsDelegate(string message);

        internal void Hello()
        {
            GreetingsDelegate handler = SaySomething;
            handler("Hello World");

            GreetingsDelegate handlerGreetings = new GreetingsDelegate(SaySomething);
            handlerGreetings("Huhu");

            GreetingsDelegate greetingsDelegate = delegate (string val)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };
            greetingsDelegate("Sample");

            Action<string> greet = name =>
            {
                string greeting = $"Hallo {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");
        }

        /// <summary>
        /// Create a method for a delegate.
        /// </summary>
        /// <param name="message">The message.</param>
        private static void SaySomething(string message)
        {
            Console.WriteLine(message);
        }
    }
}
