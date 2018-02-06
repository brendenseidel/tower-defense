﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            bool inBounds = point.X < Width && 
                            point.X >= 0 && 
                            point.Y < Height && 
                            point.Y >= 0;

            return inBounds;
        }

    }
}
