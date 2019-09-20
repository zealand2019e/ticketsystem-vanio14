using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketLybrary;

namespace UnitTestPriceAndStringType
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestPrice125kr()
        {
            //Arrange
            MC vehicleprice = new MC();

            //Act
            double answer = vehicleprice.Price();

            //Assert
            Assert.AreEqual(answer, 125);
        }


        [TestMethod]
        public void TestMCVehicle()
        {
            //Arrange
            MC vehicleType = new MC();

            //Act
            string texType = vehicleType.VehicleType();

            //Assert
            Assert.AreEqual(texType, "MC");
        }


        [TestMethod]
        public void TestCarPrice240()
        {
            //Arrange
           Car answer1 = new Car();

            //Act
            double prize = answer1.Price();

            //Assert
            Assert.AreEqual(prize, 240);
        }
        [TestMethod]
        public void TestVehicleTypeForCar()
        {
            //Arrange
            Car vehicleType = new Car();

            //Act
            string texType = vehicleType.VehicleType();

            //Assert
            Assert.AreEqual(texType, "Car");
        }


        [TestMethod]
        public void TestingException()
        {
            Car bc = new Car();


            Assert.ThrowsException<Exception>(() =>
            {
                string jaj = "License plate must be more than 7 charaters";
                bc.Licenseplate = jaj;
            });

        }



    }
}
