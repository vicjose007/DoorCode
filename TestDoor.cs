using ISBNc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void OpenDoor()
        {
            Door obj = new Door();

            string key = "Open";

            bool result = obj.OpenDoor(key);

            Assert.IsTrue(result);

        }
        [Fact]
        public void CloseDoor()
        {
            Door obj = new Door();

            string key = "Close";

            bool result = obj.CloseDoor(key);

            Assert.IsTrue(result);

        }
    }
}