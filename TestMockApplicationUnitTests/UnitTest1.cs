using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TestMockApplication;

namespace TestMockApplicationUnitTests
{
    [TestClass]
    public class MyClassTests
    {
        private readonly MyClass target;
        private readonly IConsoleWrapper consoleWrapper;

        public MyClassTests()
        {
            consoleWrapper = Substitute.For<IConsoleWrapper>();
            target = new MyClass(consoleWrapper);
        }

        [TestMethod]
        public void LookBusy_ReturnsCorrectString()
        {
            var expected = "Doing very important work..";

            var result = target.LookBusy();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LookBusyForAWhile_RepeatsAssignedNumberOfTimes()
        {
            target.LookBusyForAWhile(3);

            consoleWrapper.ReceivedWithAnyArgs(3).WriteLine(""); 
        }

        [TestMethod]
        public void LookBusyForAWhile_ArgZero_NoCallsToConsole()
        {
            target.LookBusyForAWhile(0);

            consoleWrapper.DidNotReceiveWithAnyArgs().WriteLine("");
        }

        [TestMethod]
        public void FailingTest()
        {
            Assert.IsTrue(false);
        }
    }
}
