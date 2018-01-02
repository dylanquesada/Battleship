using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        // member variables
        public List<string> ships = new List<string>() {  "Destroyer (2)", "Submarine (3)", "Battleship (4)", "Aircraft Carrier (5)" };
        public List<string> columns = new List<string>();

        // constructor
        public Player()
        {
            
        }
        // member methods 
        public string GetUserInput()
        {
            return Console.ReadLine();
        }
        public void SetBoard()
        {
            string selection;
            for (int i = 0; i < ships.Count(); i++)
            Console.WriteLine("Where would you like to place your{0}", ships[i]);
            selection = GetUserInput();
        }
        
    }
}
