using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBall
{
    class Program
    {
        static void Main(string[] args)
        {
            Board game = new Board(3, 5, 7);
            Controller C = new Controller();
            C.PlayGames();
        }
    }
}
