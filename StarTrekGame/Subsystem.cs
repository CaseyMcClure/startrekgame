using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTrekGame
{
    public class Subsystem
    {
        int integrity = 10000;
        public int maxIntegrity = 10000;

        public int GetIntegrity()
        {
            return integrity;
        }

        public void Damage(int amount)
        {
            integrity -= amount;
        }

    }
}
