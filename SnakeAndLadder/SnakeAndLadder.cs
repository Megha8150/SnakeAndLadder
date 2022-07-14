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
        static int currentPosition = 0;
        static int NO_PLAY = 0;
        static int LADDER = 1;
        static int SNAKE = 2;
        static int dieCount = 0;
        public static void game()
        {
            while (currentPosition < 100)
            {
                Random random = new Random();
                int dieNum = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 1:
                        currentPosition += dieNum;
                        if (currentPosition > 100)
                        {
                            currentPosition -= dieNum;
                        }
                        break;
                    case 2:
                        currentPosition -= dieNum;
                        if (currentPosition < 0)
                        {
                            currentPosition = START_POSITION;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Current Position is " + currentPosition);
                dieCount++;
            }
            Console.WriteLine("Exact winning Position is " + currentPosition);
            Console.WriteLine("number of times the dice was played to win the game is " + dieCount);
        }
    }
}

