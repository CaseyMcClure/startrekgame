using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarTrekGame;

namespace StarTrekGameTest
{
    [TestClass]
    public class ShipTests
    {
        Ship ship = new Ship();

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
        public void CheckForShields()
        {
            Assert.IsNotNull(ship.shield);
        }

        [TestMethod]
        public void VerifySubsystemList()
        {
            Assert.AreEqual(4, ship.subsystems.Count);
        }

        [TestMethod]
        public void TestSubsystemDamage()
        {
            ship.DamageSubsystem(0, 1000);
            Assert.AreEqual(9000, ship.subsystems[0].GetIntegrity());
        }

        [TestMethod]
        public void TestShieldDamage()
        {
            ship.DamageShields(20000);
            Assert.AreEqual(ship.shield.GetCurrentEnergy(), 0);
        }

    }
}
