using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLybrary;

namespace UnitTestPriceAndStringType
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestPrice240()
        //{
        //    //Arrange
        //    Car price1 = new Car();

        //    //Act
        //    double actualprice = price1.Price();

        //    //Assert
        //    Assert.AreEqual(actualprice,240);
        //}
        //[TestMethod]
        //public void TestString()
        //{
        //    //Arrange
        //    Car vehicleType = new Car();

        //    //Act
        //    string actualtype = vehicleType.VehicleType();

        //    //Assert
        //    Assert.AreEqual(actualtype, "Car");
        //}
        //[TestMethod]
        //public void TestPrice125()
        //{
        //    //Arrange
        //    MC mc = new MC();

        //    //Act
        //    double actualpirce = mc.Price();

        //    //Assert
        //    Assert.AreEqual(actualpirce, 125);
        //}
        //[TestMethod]
        //public void TestVehicle()
        //{
        //    //Arrange
        //    MC vehicleType = new MC();

        //    //Act
        //    string texType = vehicleType.Vehicle();

        //    //Assert
        //    Assert.AreEqual(texType, "MC");
        //}
        [TestMethod]
        public void TestPrice125kr()
        {
            //Arrange
            MC vehicleprice = new MC();

            //Act
            double answer = vehicleprice.Price125kr();

            //Assert
            Assert.AreEqual(answer, 125);
        }
        [TestMethod]
        public void TestMCVehicle()
        {
            //Arrange
            MC vehicleType = new MC();

            //Act
            string texType = vehicleType.MCVehicle();

            //Assert
            Assert.AreEqual(texType, "MC");
        }
        [TestMethod]
        public void TestCarPrice240()
        {
            //Arrange
           Car answer1 = new Car();

            //Act
            double prize = answer1.CarPrice240();

            //Assert
            Assert.AreEqual(prize, 240);
        }
        [TestMethod]
        public void TestVehicleTypeForCar()
        {
            //Arrange
            Car vehicleType = new Car();

            //Act
            string texType = vehicleType.VehicleTypeForCar();

            //Assert
            Assert.AreEqual(texType, "Car");
        }

    }
}
