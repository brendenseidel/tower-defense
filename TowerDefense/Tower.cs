using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            if (!location.OnMap(this))
            {
                throw new OutOfBoundsException(x + ", " + y + " is outside the boundaries of the map.");
            }
            _location = location;
        }
    }
}
