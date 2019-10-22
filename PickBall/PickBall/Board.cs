using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBall
{
    class Board
    {
        private int g1, g2, g3;

        public Board(int g1, int g2, int g3)
        {
            this.g1 = g1;
        }
        public void pickball(int g, int mount)
        {
            switch (g)
            {
                case 1 :
                    g1 -= mount;
                    break;
                case 2 :
                    g2 -= mount;
                    break;
                case 3 :
                    g3 -= mount;
                    break;
                default :
                    Console.WriteLine("");
                    break;
            }
        }
        public bool isGameOver()
        {
            if ( g1 == 0 && g2 == 0 && g3 == 0)
            {
                return true;
            }
            return false;
        }
        public void PrintGame()
        {
            Console.WriteLine("Group 1 :" + g1);
            Console.WriteLine("Group 2 :" + g2);
            Console.WriteLine("Group 3 :" + g3);
        }       
    }
}
