using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTrekGame
{
    public class Ship:Subsystem
    {
        Engine engine;
        
        public Ship()
        {
            engine = new Engine();

        }

        public Engine GetEngine()
        {
            return engine;
        }
    }
}
