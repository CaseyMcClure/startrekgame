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
        private int energy = 0; 

        public int GetIntegrity()
        {
            return integrity;
        }

        public int GetEnergy()
        {
            return energy;
        }

        public void SetEnergy(int energyToAdd)
        {
            energy += energyToAdd;
        }
        public void Damage(int amount)
        {
            integrity -= amount;
        }
    }
}
