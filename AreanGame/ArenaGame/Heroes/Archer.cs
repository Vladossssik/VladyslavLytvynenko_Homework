using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Archer : Hero
    {
        private double hitCount;
        private double damageCoef;

        public Archer(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
        }

        public override double Attack()
        {
            double damage = base.Attack();

            double probability = random.NextDouble();
            if (probability < 0.8)
            {
                damage *= 2;
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 3)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage);
        }
    }
}
