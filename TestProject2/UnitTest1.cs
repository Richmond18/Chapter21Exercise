using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ch21exercise;

namespace TestProject2
{
    [TestClass]
    public class UnitTest2
    {
       

        
            [TestMethod]
            public void TestMethod1()
            {
                Laptop computer1 = new Laptop(7, 760, "WEEEE","2121");
                Assert.AreEqual(computer1.Storage, 760);

            }

            [TestMethod]
            public void TestMethod2()
            {
                Laptop computer1 = new Laptop(7, 760, "12.3232.232", "3232");
                Assert.AreEqual(computer1.IpAdress, "12.3232.232");

            }
        
    }
}
