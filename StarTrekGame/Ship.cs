using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTrekGame
{
    public class Ship
    {
        private Engine engine;
        private Shield shield;
        public const int DEFAULT_ENERGY = 80000;
        private int energy = DEFAULT_ENERGY;
        
        public Ship()
        {
            engine = new Engine();
            shield = new Shield();
        }

        public Engine GetEngine()
        {
            return engine;
        }

        public int GetEnergy()
        {
            return energy;
        }

        public Shield GetShield()
        {
            return shield;
        }
    }
}
