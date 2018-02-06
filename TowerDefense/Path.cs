﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Path
    {

        private readonly MapLocation[] _path;

        // constructor
        public Path(MapLocation[] path)
        {
            _path = path;
        }

        // method
        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}
