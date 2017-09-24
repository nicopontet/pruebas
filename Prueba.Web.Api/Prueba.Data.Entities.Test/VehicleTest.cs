using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prueba.Data.Entities.Test
{
    [TestClass]
    public class VehicleTest
    {
        private string[] VehicleType = { "Auto", "Camión", "SUV", "VAN", "Minivan" };
        [TestMethod]
        public void CreateVehicleTest()
        {
             Vehicle vehicle = new Vehicle();

             vehicle.ID = "1234567";
             vehicle.Brand = "Peugeot";
             vehicle.Model = "306";
             vehicle.Year = "2010";
             vehicle.Color = "Blue";
             vehicle.VIN = "123";
             vehicle.VehicleType = GetVehicleType(1);

            Assert.AreEqual(vehicle.ID, "1234567");
            Assert.AreEqual(vehicle.Brand, "1234567");
            Assert.AreEqual(vehicle.Model, "1234567");
            Assert.AreEqual(vehicle.Year, "1234567");
            Assert.AreEqual(vehicle.VIN, "1234567");
            Assert.AreEqual(vehicle.VehicleType, "Camion");

        }

        private object GetVehicleType(int n)
        {
            return VehicleType[n];
        }
    }
}
