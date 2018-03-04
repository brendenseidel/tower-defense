using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Towers
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = .95;

        public SniperTower(MapLocation location) : base(location)
        {}
    }
}
