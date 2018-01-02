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
        public string name;
        public int size;
        bool sunk = false;
        int hits = 0;

        // constructor
        public Ship(string Name, int Size)
        {
            name = Name;
            size = Size;
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
