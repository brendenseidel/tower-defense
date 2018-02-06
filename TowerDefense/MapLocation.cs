﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + ", " + y + " is outside the boundaries of the map.");
            }
        }
    }
}