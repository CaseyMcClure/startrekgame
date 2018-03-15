using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperStarTrek
{
    class Ship:Subsystem
    {
<<<<<<< HEAD
        public Engine engine;
        public Phaser phaser;
        public Torpedo torpedo;
        public Shield shield;
        public List<Subsystem> subsystems;
        public Random r;
        
        public Ship()
        {
            PopulateShip();

            r = new Random();
        }

        private void PopulateShip()
        {
            subsystems = new List<Subsystem>();

            engine = new Engine();
            subsystems.Add(engine);
=======
       
        public Ship()
        {
>>>>>>> 5315d1d59c2186767334a8fbb4e68bdca5bf7f82

            phaser = new Phaser();
            subsystems.Add(phaser);

            torpedo = new Torpedo();
            subsystems.Add(torpedo);

            shield = new Shield();
            subsystems.Add(shield);
        }

        public Ship(Random r)
        {
            PopulateShip();
            this.r = r;
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
