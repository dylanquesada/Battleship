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
        public List<string> PlaceShip(string input, string direction)
        {
            return columns;
        }
        public void SetBoard()
        {
            string selection;
            string direction;
            for (int i = 0; i < ships.Count(); i++)
            {
                Console.WriteLine("Where would you like to place your {0}? Enter top left start coordinate. ex. 'A3'", ships[i]);
                selection = GetUserInput();
                Console.WriteLine("Do you want your {0} horizontal or vertical?", ships[i]);
                direction = GetUserInput();
                PlaceShip(selection, direction);
                DisplayBoard(columns);
            }

        }
        public void DisplayBoard(List<String> columns)
        {
            Console.WriteLine("A B C D E F G H I J K L M N O P Q R S T");
            for (int i = 0; i <= columns.Count(); i++)
            {
                Console.WriteLine("{0}", i + 1);
                for (int j = 0; j <= columns[i][j]; j++)
                {
                    Console.Write("{0}", columns[i][j]);
                }
            }
        }

    }
}
