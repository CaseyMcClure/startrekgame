using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarTrekGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StarTrekGameTest
{
    [TestClass]
    public class ShieldTests
    {
       Shield shield;

        [TestInitialize()]
       public void Startup()
        {
            shield = new Shield();
        }

        [TestMethod]
        public void ShieldsDownByDefault()
        {
            Assert.IsFalse(shield.IsUp());
        }

        [TestMethod]
        public void TestRaiseShields()
        {
            shield.RaiseShield();
            Assert.IsTrue(shield.IsUp());
        }

        [TestMethod]
        public void ShieldDefaultEnergy()
        {
            Assert.AreEqual(8000, shield.GetCurrentEnergy());
        }

        [TestMethod]
        public void TransferShieldEnergy()
        {
            shield.TransferEnergy(2000);
            Assert.AreEqual(10000, shield.GetCurrentEnergy());
        }

        [TestMethod]
        public void TestMaximumShieldPower()
        {
            shield.TransferEnergy(2001);
            Assert.AreEqual(shield.maxEnergy, shield.GetCurrentEnergy());
        }

        [TestMethod]
        public void TestMinimumShieldPower()
        {
            shield.TransferEnergy(-8001);
            Assert.AreEqual(0, shield.GetCurrentEnergy());
        }

        [TestMethod]
        public void TestShieldDamage()
        {
            shield.DamageShields(2000);
            Assert.AreEqual(6000, shield.GetCurrentEnergy());
        }

        [TestMethod]
        public void TestDefaultIntegrity()
        {
            Assert.AreEqual(shield.maxIntegrity, shield.GetIntegrity());
        }
    }
}
