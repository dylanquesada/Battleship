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
        public List<Ship> ships = new List<Ship>() {
            new Ship("Destroyer", 2),
            new Ship("Submarine", 3),
            new Ship("Battleship", 4),
            new Ship("Aircraft Carrier", 5) };
        public List<List<char>> columns = new List<List<char>>();

        // constructor
        public Player()
        {
            
        }
        // member methods 

        public string GetUserInput()
        {
            return Console.ReadLine();
        }
        public List<List<char>> PlaceShip(string input, string direction, Ship ship)
        {
            string name = ship.name;
            char Column;
            char Marker;
            Marker = 'A';
            Column = input[0];
            switch (direction)
            {
                case "horizontal":
                    for (int i = 0; i < columns.Count(); i++)
                    {
                        Marker++;
                        if(Marker == input[0])
                        {
                            for (int j = 0; j < ship.size; j++)
                            {
                                columns[input[0]][input[1] + j] = name[j];
                            }
                        }
                    }
                    return columns;
                    //break;
                case "vertical":
                    for (int i = 0; i < columns.Count(); i++)
                    {
                        Marker++;
                        if (Marker == input[0])
                        {
                            for (int j = input[1]; j < ship.size; j++)
                            {
                                columns[i][j] = ship.name[j - input[1]];
                            }
                        }
                    }
                    return columns;
                    //break;

                default:
                    return columns;
                    //break;
            }
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
                PlaceShip(selection, direction, ships[i]);
                DisplayBoard(columns);
            }

        }
        public void DisplayBoard(List<List<char>> columns)
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
