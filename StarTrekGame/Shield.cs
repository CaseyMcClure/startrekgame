using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperStarTrek
{
    public class Shield:Subsystem
    {
        bool isUp = false;
        int energy = 8000;
        public int maxEnergy = 10000;

        public bool IsUp()
        {
            return isUp;
        }

        public void RaiseShield()
        {
            isUp = true;
        }

        public int GetCurrrentEnergy()
        {
            return energy;
        }

        public void TransferEnergy(int amountToTransfer)
        {
            energy += amountToTransfer;
            if (energy > maxEnergy)
            {
                energy = maxEnergy;
            }
            if (energy < 0)
            {
                energy = 0;
            }
        }

        public void DamageShields(int amountToDamage)
        {
            energy -= amountToDamage;
            if (energy > maxEnergy)
            {
                energy = maxEnergy;
            }
            if (energy < 0)
            {
                energy = 0;
            }
        }
    }
}
