using System;
using System.Text;
using System.Collections.Generic;
using StarTrekGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StarTrekGameTest
{
    [TestClass]
    public class ShipTests
    {
        Ship ship;

        [TestInitialize()]
        public void Startup()
        {
            ship = new Ship();
        }

        [TestMethod]
        public void CheckForEngine()
        {
            Assert.IsNotNull(ship.GetEngine());
        }

        [TestMethod]
        public void EnergyReserveDefault()
        {
            Assert.AreEqual(80000, ship.energy);
        }

        [TestMethod]
        public void EnergyEqualToDefault()
        {
            Assert.AreEqual(ship.GetEnergy(), ship.energy);
        }

        [TestMethod]
        public void ShipHasShield()
        {
            Assert.IsNotNull(ship.GetShield());
        }
        
        [TestMethod]
        public void transferEnergyToSubsystem()
        {
            int currentEnergy = ship.GetEnergy();
            int energyTransfer;
        }

    }
}
