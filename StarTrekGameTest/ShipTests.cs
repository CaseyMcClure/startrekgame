using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckForEngine()
        {
<<<<<<< HEAD
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
=======

>>>>>>> 5315d1d59c2186767334a8fbb4e68bdca5bf7f82
        }
    }
}
