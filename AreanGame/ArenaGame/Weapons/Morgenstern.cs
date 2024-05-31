using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Morgenstern : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Morgenstern(string name)
        {
            Name = name;
            AttackDamage = 39;
            BlockingPower = 2;
        }
    }
}
