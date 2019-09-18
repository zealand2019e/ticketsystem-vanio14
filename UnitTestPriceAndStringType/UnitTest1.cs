using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLybrary;

namespace UnitTestPriceAndStringType
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrice240()
        {
            //Arrange
            Car price1 = new Car();

            //Act
            double actualprice = price1.Price();

            //Assert
            Assert.AreEqual(actualprice,240);
        }
        [TestMethod]
        public void TestString()
        {
            //Arrange
            Car vehicleType = new Car();

            //Act
            string actualtype = vehicleType.VehicleType();

            //Assert
            Assert.AreEqual(actualtype, "Car");
        }
    }
}
