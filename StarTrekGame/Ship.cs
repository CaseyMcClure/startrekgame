using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTrekGame
{
    public class Ship
    {
        public Engine engine;
        public Phaser phaser;
        public Torpedo torpedo;
        public Shield shield;
        public int energy;
        public List<Subsystem> subsystems;
        public Random r;

        public Ship()
        {
            PopulateShip();
            energy = 80000;
        }

        public Ship(Random r)
        {
            PopulateShip();
            this.r = r;
        }

        private void PopulateShip()
        {
            subsystems = new List<Subsystem>();

            engine = new Engine();
            subsystems.Add(engine);

            phaser = new Phaser();
            subsystems.Add(phaser);

            torpedo = new Torpedo();
            subsystems.Add(torpedo);

            shield = new Shield();
            subsystems.Add(shield);
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

        public void ProcessAttack(int amount)
        {
            if (shield.GetCurrentEnergy() - amount > 0)
            {
                shield.DamageShields(amount);
            }
            else
            {
                int excessDamage = amount - shield.GetCurrentEnergy();
                shield.DamageShields(shield.GetCurrentEnergy());
                int subsystemIndex = SubsystemToDamage();
                DamageSubsystem(subsystemIndex, excessDamage);
            }
        }

        private int SubsystemToDamage()
        {
            int subsystemIndex = r.Next(subsystems.Count - 1);
            return subsystemIndex;
        }

        public void DamageSubsystem(int index, int amount)
        {
            subsystems[index].DamageIntegrity(amount);
        }
    }
}
