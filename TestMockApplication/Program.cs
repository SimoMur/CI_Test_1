namespace TestMockApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleWrapper();
            var obj = new MyClass(console);

            obj.LookBusyForAWhile(3);
        }
    }
}
