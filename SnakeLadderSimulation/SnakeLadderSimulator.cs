using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderSimulation
{
    class SnakeLadderSimulator
    {
        /// <summary>
        /// getDie method is used to get the random die value.
        /// </summary>
        public void getDie() 
        {
                Random random = new Random();
                int die = random.Next(1, 7);
                Console.WriteLine(die);
        }
    }
}
