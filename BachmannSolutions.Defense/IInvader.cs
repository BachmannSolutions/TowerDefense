using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachmannSolutions.TowerDefense
{
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMoveable
    {
        void Move();
    }

    interface IInvader : IMappable , IMoveable
    {
        bool HasScored { get; }

        int Health { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void DecreaseHealth(int factor);
    }
}
