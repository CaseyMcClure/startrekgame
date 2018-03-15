using System;
using System.Text;
using System.Collections.Generic;
using StarTrekGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StarTrekGameTest
{
    [TestClass]
    public class SubsystemTest
    {
        Subsystem subsystem;

        [TestInitialize()]
        public void Startup()
        {
            subsystem = new Subsystem();
        }

        [TestMethod]
        public void SubsystemHasEnergyTank()
        {
            Assert.IsTrue(subsystem.GetEnergy() >= 0);
        }

        [TestMethod]
        public void AddEnergy()
        {
            int energyToAdd = 2000;
            int currentEnergy = subsystem.GetEnergy();
            int newEnergy = energyToAdd + currentEnergy;

            subsystem.SetEnergy(energyToAdd);

            Assert.IsTrue(subsystem.GetEnergy() == newEnergy);
        }

    }
}
