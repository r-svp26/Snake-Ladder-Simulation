using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderSimulation
{
    class SnakeLadderSimulator
    {
        // constants
        const int WIN_SCORE = 100;
        const int LADDER = 1;
        const int SNAKE = 2;
        // variables
        static int playerPosition = 0, diceCount = 0, die, option;

        /// <summary>
        /// This method is used to choose the option.
        /// </summary>
        public static void SelectOption()
        {
            while (playerPosition < WIN_SCORE)
            {
                Random random = new Random();
                option = random.Next(0, 3);
                diceCount++;
                // invoking the GetDie method
                die = GetDie();
                switch (option)
                {
                    case LADDER:
                        if (playerPosition <= WIN_SCORE && (playerPosition + die) <= WIN_SCORE)
                        {
                            playerPosition += die;
                            Console.WriteLine("Player status is Ladder");
                            Console.WriteLine("Player position is:" + playerPosition);
                        }
                        break;
                    case SNAKE:
                        if (playerPosition > 0 && (playerPosition - die) >= 0)
                        {
                            playerPosition -= die;
                            Console.WriteLine("Player status is Snake");
                            Console.WriteLine("Player position is:" + playerPosition);
                        }
                        else
                            playerPosition = 0;
                        break;
                    default:
                        {
                            Console.WriteLine("Player status is No Play");
                            Console.WriteLine("Player position is:" + playerPosition);
                        }
                        break;
                }
            }
            Console.WriteLine("Total number of dice rolled is:" +diceCount);
        }

        /// <summary>
        /// getDie method is used to get the random die value.
        /// </summary>
         public static int GetDie() 
        {
                Random random = new Random();
                int die = random.Next(1, 7);
                return die;
        }
    }
}
