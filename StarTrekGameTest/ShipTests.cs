using System;
using System.Text;
using System.Collections.Generic;
using StarTrekGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarTrekGame;

<<<<<<< HEAD

=======
>>>>>>> 89b23528513b658171e17b7c599a19ba501057fb
namespace StarTrekGameTest
{
    /// <summary>
    /// Summary description for ShipTests
    /// </summary>
    [TestClass]
    public class ShipTests
    {
<<<<<<< HEAD
        Ship ship;

       [TestInitialize()]
       public void Startup()
=======
        Ship ship = new Ship();

        [TestMethod]
        public void CheckForEngine()
>>>>>>> 89b23528513b658171e17b7c599a19ba501057fb
        {
            Assert.IsNotNull(ship.Engine);
        }
    }
}
