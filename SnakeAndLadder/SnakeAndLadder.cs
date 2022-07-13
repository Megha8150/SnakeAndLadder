using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
     class SnakeAndLadder
    {
        static int START_POSITION = 0; 
        public static void game()
        {
            Random random = new Random();
            int num = random.Next(1, 7);
            Console.WriteLine(num);
        }
    }
}
