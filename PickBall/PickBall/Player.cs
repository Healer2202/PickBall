using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBall
{
     public class Player
    {
        private string player;
        public Player ( string Name)
        {
            this.player = Name;
        }
        public void pickball(Board game)
        {
            Console.Write("Which group do you choose : ");
            int group = int.Parse(Console.ReadLine());
            Console.Write("How many balls you want pick : ");
            int mount = int.Parse(Console.ReadLine());
            game.pickball(group, mount);
        }
        public string getName()
        {
            return this.player;
        }
    }
}

