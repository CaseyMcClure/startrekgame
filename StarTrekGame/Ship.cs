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
        
        public Ship()
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

            energy = 80000;
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

        public void DamageShields(int amount)
        {
        }

        public void DamageSubsystem(int index, int amount)
        {
            subsystems[index].Damage(amount);
        }
    }
}
