using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class PowerTower : Tower
    {
        protected override int Power { get; } = 3;

        public PowerTower(MapLocation location) : base(location)
        { }
    }
}
