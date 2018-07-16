namespace TestMockApplication
{
    public class MyClass
    {
        private readonly IConsoleWrapper consoleWrapper;

        public MyClass(IConsoleWrapper newConsoleWrapper)
        {
            consoleWrapper = newConsoleWrapper;
        }

        public string LookBusy()
        {
            return "Doing very important work.. OOPS THIS SHOULDN'T BE HERE!";
        }

        public void LookBusyForAWhile(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                consoleWrapper.WriteLine(LookBusy());
            }
        }
    }
}
