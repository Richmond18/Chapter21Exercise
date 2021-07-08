using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ch21exercise;

namespace Test1 
{
    [TestClass]
    public class ComputerClassTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Computer computer1 = new Computer(7,760, "WEEEE","2323");
            Assert.AreEqual(computer1.Storage, 760);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Computer computer1 = new Computer(7, 760, "12.3232.232" ,"1212");
            Assert.AreEqual(computer1.IpAdress, "12.3232.232");

        }


    }
}
