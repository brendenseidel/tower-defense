using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class TowerDefenseException : Exception
    {
        public TowerDefenseException()
        {

        }
        public TowerDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TowerDefenseException
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
