using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarTrekGame;


namespace StarTrekGameTests
{
    [TestClass]
    public class UnitTest1
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
            Assert.IsNotNull(ship.engine);
        }

        [TestMethod]
        public void CheckForPhaser()
        {
            Assert.IsNotNull(ship.phaser);
        }

        [TestMethod]
        public void CheckForTorpedo()
        {
            Assert.IsNotNull(ship.torpedo);
        }

        [TestMethod]
        public void CheckForShield()
        {
            Assert.IsNotNull(ship.shield);
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
        public void transferEnergyToSubsystem()
        {
            int currentEnergy = ship.GetEnergy();
            int energyTransfer;

            ship.ProcessAttack(20000);
            Assert.AreEqual(0, ship.shield.GetCurrentEnergy());
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
        }
    }
}
