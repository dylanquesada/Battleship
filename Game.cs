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
            while (playerOne.hitsTaken < 14 && playerTwo.hitsTaken < 14)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            playerTwo.DisplayBoard(playerTwo.columns);
            
        }

        // member methods 
        public void PlayerTurn(Player attackingPlayer, Player defendingPlayer)
        {
            string position;
            Console.WriteLine(" - [- Enemy's Board -] - ");
            defendingPlayer.DisplayBoard(defendingPlayer.columns);
            Console.WriteLine("{0}'s Turn.", attackingPlayer.name);
            Console.WriteLine("Enter your targeting coordinates:");
            position = GetUserInput();            
            defendingPlayer.columns = defendingPlayer.FireOnSquare(defendingPlayer.columns);
           // Console.Clear();
        }
        public string GetUserInput()
        {
            return Console.ReadLine();
        }
        public void RunGame()
        {

        }


    }
}
