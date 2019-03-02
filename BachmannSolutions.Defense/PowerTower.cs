using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachmannSolutions.TowerDefense
{
    class PowerTower : Tower
    {
        protected override int Range { get; } = 2;

        protected override int Power { get; } = 2;

        public PowerTower(MapLocation location) : base(location)
        { }
    }
}
