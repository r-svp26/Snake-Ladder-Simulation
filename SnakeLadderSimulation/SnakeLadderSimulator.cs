using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderSimulation
{
    class SnakeLadderSimulator
    {
        // constants
        const int noPlay = 0;
        const int ladder = 1;
        const int snake = 2;
        // variable
        static int playerPosition = 0;
        static int diceCount = 0;
        /// <summary>
        /// This method is used to choose the option.
        /// </summary>
        public static void selectOption()
        {
            // variables
            int die = 0;
            int option = 0;
            while (playerPosition < 100)
            {
                Random random = new Random();
                option = random.Next(0, 3);
                diceCount++;
                // invoking the getDie method
                die = getDie();
                if (option == 1)
                {
                    if (playerPosition <= 100 && (playerPosition + die) <= 100)
                    {
                        playerPosition = playerPosition + die;
                        Console.WriteLine("Player status is Ladder");
                        Console.WriteLine("Player position is:" + playerPosition);
                    }
                }
                else if (option == 2)
                {
                    if (playerPosition > 0 && (playerPosition-die) >= 0)
                    {
                        playerPosition = playerPosition - die;
                        Console.WriteLine("Player status is Snake");
                        Console.WriteLine("Player position is:" + playerPosition);
                    }
                }
                else
                {
                    Console.WriteLine("Player status is No Play");
                    Console.WriteLine("Player position is:" + playerPosition);
                }
            }
            Console.WriteLine("Total number of dice rolled is:" +diceCount);
        }
        /// <summary>
        /// getDie method is used to get the random die value.
        /// </summary>
         public static int getDie() 
        {
                Random random = new Random();
                int die = random.Next(1, 7);
                return die;
        }
    }
}
