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
        public Player playerOne;
        public Player playerTwo;

        // constructor
        public Game()
        {
            Player playerOne = new Player();
            Console.WriteLine("Enter player one's name:");
            playerOne.name = GetUserInput();
            Player playerTwo = new Player();
            Console.WriteLine("Enter player two's name:");
            playerTwo.name = GetUserInput();
            playerTwo.PopulateBoard();
            playerTwo.DisplayBoard(playerTwo.columns);
            
        }

        // member methods 
        public string GetUserInput()
        {
            return Console.ReadLine();
        }
        public void RunGame()
        {

        }


    }
}
