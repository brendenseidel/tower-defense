using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMovable
    {
        void Move();
    }

    interface IInvader : IMappable, IMovable
    {       
        bool HasScored { get; }
        
        int Health { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void DecreaseHealth(int factor);
    }
}
