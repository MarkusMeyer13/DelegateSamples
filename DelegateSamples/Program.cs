using System;

namespace DelegateSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegates.Execute();
            Console.WriteLine("-- Press any key to continue --");
            Console.ReadKey();

            GreetingSample greetingSample = new GreetingSample();
            greetingSample.Hello();
            Console.WriteLine("-- Press any key to exit --");

            Console.ReadKey();
        }
    }
}
