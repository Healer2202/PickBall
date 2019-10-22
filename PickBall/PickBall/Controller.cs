using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBall
{
    class Controller
    {
        private Board game;
        private Player P1, P2;

        public Controller()
        {
            P1 = new Player("Long");
            P2 = new Player("Computer");
            game = new Board(3, 5, 7);
        }

        public void PlayGames()
        {
            while (game.isGameOver() != true)
            {
                game.PrintGame();
                P1.pickball(game);
                if(game.isGameOver())
                {
                    Console.WriteLine(P1.GetName() + "Loses");
                    Console.WriteLine(P2.GetName() + "Wins");
                    break;
                }
                Console.WriteLine(P2.GetName() + "a turn");              
                game.PrintGame();
                P2.pickball(game);
            }
        }
    }
}
