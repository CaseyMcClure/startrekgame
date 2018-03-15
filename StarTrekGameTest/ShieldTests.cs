using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperStarTrek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperStarTrekTest
{
    [TestClass]
    public class ShieldTests
    {
       Shield shield;

       public ShieldTests()
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
            Assert.AreEqual(8000, shield.GetCurrrentEnergy());
        }

        [TestMethod]
        public void TransferShieldEnergy()
        {
            shield.TransferEnergy(2000);
            Assert.AreEqual(10000, shield.GetCurrrentEnergy());
        }

        [TestMethod]
        public void TestMaximumShieldPower()
        {
            shield.TransferEnergy(2001);
<<<<<<< HEAD
            Assert.AreEqual(shield.maxEnergy, shield.GetCurrentEnergy());
=======
            Assert.AreEqual(shield.maxPower, shield.GetCurrrentEnergy());
>>>>>>> 5315d1d59c2186767334a8fbb4e68bdca5bf7f82
        }

        [TestMethod]
        public void TestMinimumShieldPower()
        {
            shield.TransferEnergy(-8001);
            Assert.AreEqual(0, shield.GetCurrrentEnergy());
        }

        [TestMethod]
        public void TestShieldDamage()
        {
            shield.DamageShields(2000);
            Assert.AreEqual(6000, shield.GetCurrrentEnergy());
        }

        [TestMethod]
        public void TestIntegrity()
        {
            Assert.AreNotEqual(shield.maxIntegrity, shield.GetIntegrity());
        }
    }
}
