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
        static int player1Position = 0;
        static int player2Position = 0;
        static int NO_PLAY = 0;
        static int LADDER = 1;
        static int SNAKE = 2;
        static int dieCount = 0;
        static int player;

        public static void switchPlayer()
        {
            if(player==1)
            {
                player = 2;
            }
            else
            {
                player = 1;
            }
        }
        public static void game()
        {
            Random random = new Random();
             player = random.Next(1, 3);

            while (player1Position < 100 && player2Position < 100)
            {
                int dieNum = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 1:
                        if (player == 1)
                        {
                            player1Position += dieNum;
                            if (player1Position > 100)
                            {
                                player1Position -= dieNum;
                            }
                        }
                        else
                        {
                            player2Position += dieNum;
                            if (player2Position > 100)
                            {
                                player2Position -= dieNum;
                            }
                        }
                        break;
                    case 2:
                        if (player == 2)
                        {
                            player1Position -= dieNum;
                            if (player1Position < 0)
                            {
                                player1Position = START_POSITION;
                            }

                        }
                        else
                        {
                            player2Position -= dieNum;
                            if (player2Position < 0)
                            {
                                player2Position = START_POSITION;
                            }
                        }
                        switchPlayer();
                        break;
                    default:
                        switchPlayer();
                        break;
                }
                Console.WriteLine("Current position of player 1 is " +player1Position);
                Console.WriteLine("Current position of player 2 is " +player2Position);
                dieCount++;
            }
            Console.WriteLine("number of times the dice was played to win the game is " + dieCount);
            Console.WriteLine("Winner is player " + player);
        }
    }
}

