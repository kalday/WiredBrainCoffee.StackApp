using System;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new SimpleStack();

            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);
        }
    }
}