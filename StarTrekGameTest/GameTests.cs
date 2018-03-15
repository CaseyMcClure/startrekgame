using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarTrekGame;

namespace StarTrekGameTest
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void ThereIsACurrentStarDate()
        {
            Game game = new Game();
            Assert.IsNotNull(game.StarDate());
        }
    }
}
