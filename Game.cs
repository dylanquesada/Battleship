using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {

        // member variables

        // constructor
        public Game()
        {
            //Board board = new Board();
        }

        // member methods 
        
        public void DisplayBoard(List<String> columns, List<String> rows)
        {
            for (int i = 0; i <= columns.Count(); i++)
            {
                Console.WriteLine("{0}", i + 1);
                for(int j = 0; j <= 20; j++)
                {
                    Console.Write("{0}", rows[j]);
                }
            }
        }

    }
}
