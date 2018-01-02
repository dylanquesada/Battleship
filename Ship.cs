using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Ship
    {
        // member variables
        bool sunk = false;
        int hits = 0;

        // constructor
        public Ship()
        {
            string name;
            int size;
        }

        // member methods
        public int TakeHit()
        {
            return hits += 1;
        }
        public void SinkShip()
        {
            sunk = true;
        }
    }
}
