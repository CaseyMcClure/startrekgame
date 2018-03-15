using System;
using System.Text;
using System.Collections.Generic;
using StarTrekGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StarTrekGameTests
{
    [TestClass]
    public class ShipTests
    {
        Ship ship;

        [TestMethod]
        public void CheckForEngine()
        {
            Assert.IsNotNull(ship.engine);
        }

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
<<<<<<< HEAD
            int currentEnergy = ship.GetEnergy();
            int energyTransfer;
=======
            ship.ProcessAttack(20000);
            Assert.AreEqual(0, ship.shield.GetCurrentEnergy());
>>>>>>> e17f04f89a90aa68da6b00e3c25bce85d9f1fd32
        }

        [TestMethod]
        public void TestIncomingAttack()
        {
            MockRandom mockRandom = new MockRandom();
            ship = new Ship(mockRandom);
            ship.ProcessAttack(20000);
            Assert.AreEqual(0, ship.shield.GetCurrentEnergy());
            Assert.AreNotEqual(ship.engine.maxIntegrity, ship.engine.GetIntegrity());

        }

        class MockRandom : Random
        {
            public override int Next(int maxValue)
            {
                return 0;
            }
=======

>>>>>>> 5315d1d59c2186767334a8fbb4e68bdca5bf7f82
        }
    }
}
