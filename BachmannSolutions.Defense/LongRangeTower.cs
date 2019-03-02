using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachmannSolutions.TowerDefense
{
    class LongRangeTower : Tower
    {
        protected override int Range { get; } = 7;

        public LongRangeTower(MapLocation location) : base(location)
        { }
    }
}
