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
        int power = 8000;
        public int maxPower = 10000;

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
            return power;
        }

        public void TransferEnergy(int amountToTransfer)
        {
            power += amountToTransfer;
            if (power > maxPower)
            {
                power = maxPower;
            }
            if (power < 0)
            {
                power = 0;
            }
        }

        public void DamageShields(int amountToDamage)
        {
            power -= amountToDamage;
            if (power > maxPower)
            {
                power = maxPower;
            }
            if (power < 0)
            {
                power = 0;
            }
        }
    }
}
