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
            Assert.IsNotNull(ship.Engine);
        }
    }
}
