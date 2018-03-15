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
    }
}
