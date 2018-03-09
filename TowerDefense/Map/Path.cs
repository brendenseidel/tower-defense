﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

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

        public bool IsOnPath(MapLocation location)
        {
            foreach (var pathLocation in _path)
            {
                if (location.Equals(pathLocation))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
