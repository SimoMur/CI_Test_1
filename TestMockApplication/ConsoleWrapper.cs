using System;

namespace TestMockApplication
{
    public interface IConsoleWrapper
    {
        void WriteLine(string str);
    }

    public class ConsoleWrapper : IConsoleWrapper
    {
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}