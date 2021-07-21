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

        /// <summary>
        /// This method is used to choose the option.
        /// </summary>
        public static void selectOption()
        {
            // variables
            int die = 0;
            int option = 0;
            Random random = new Random();
            option = random.Next(0, 3);
            // invoking the getDie method
            die = getDie();
            if (option == 1)
            {
                playerPosition = playerPosition + die;
                Console.WriteLine("Player status is Ladder");
                Console.WriteLine("Player position is:" + playerPosition);
            }
            else if (option == 2)
            {
                playerPosition = playerPosition - die;
                Console.WriteLine("Player status is Snake");
                Console.WriteLine("Player position is:" + playerPosition);
            }
            else
            {
                Console.WriteLine("Player status is No Play");
                Console.WriteLine("Player position is:" + playerPosition);
            }
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
