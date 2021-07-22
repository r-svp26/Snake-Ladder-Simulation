using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderSimulation
{
    class SnakeLadderSimulator
    {
        // constants
        const int WIN_SCORE = 100;
        const int NO_PLAY = 0;
        const int LADDER = 1;
        const int SNAKE = 2;
        // variables
        int firstPlayerPosition = 0;
        int firstPlayerDiceCount = 0;
        int firstPlayerStatus = 0;
        int firstPlayerDie;
        int secondPlayerPosition = 0;
        int secondPlayerDiceCount = 0;
        int secondPlayerStatus = 0;
        int secondPlayerDie;

        public void PlayWin()
        {
            while (firstPlayerPosition <= WIN_SCORE && secondPlayerPosition <= WIN_SCORE)
            {
                Random random = new Random();
                firstPlayerDie = random.Next(1, 7);
                firstPlayerDiceCount++;
                firstPlayerStatus = random.Next(0, 3);
                switch (firstPlayerStatus)
                {
                    case NO_PLAY:
                        firstPlayerPosition += 0;
                        break;
                    case LADDER:
                        if (firstPlayerPosition > WIN_SCORE)
                            firstPlayerPosition -= firstPlayerDie;
                        while (firstPlayerStatus == LADDER)
                        {
                            firstPlayerStatus = random.Next(0, 3);
                            if (firstPlayerStatus == LADDER)
                            {
                                firstPlayerDie = random.Next(1, 7);
                                firstPlayerPosition += firstPlayerDie;
                                firstPlayerDiceCount++;
                                if (firstPlayerPosition > WIN_SCORE)
                                    firstPlayerPosition -= firstPlayerDie;
                                if (firstPlayerPosition == WIN_SCORE)
                                    break;
                            }
                            if (firstPlayerStatus == SNAKE)
                            {
                                firstPlayerPosition -= firstPlayerDie;
                                firstPlayerDiceCount++;
                                break;
                            }
                        }
                        break;
                    default:
                        firstPlayerPosition -= firstPlayerDie;
                        break;
                }
                if (firstPlayerPosition < 0)
                {
                    firstPlayerPosition = 0;
                    Console.WriteLine("First player position is:" + firstPlayerPosition);
                }
                if (firstPlayerPosition < WIN_SCORE)
                {
                    firstPlayerPosition += firstPlayerDie;
                    Console.WriteLine("First player position is:" + firstPlayerPosition);
                }
                if (firstPlayerPosition == WIN_SCORE)
                {
                    Console.WriteLine("First player reaches the winning position:" + firstPlayerPosition);
                    Console.WriteLine("Total number of times rolled dice by first player is:" + firstPlayerDiceCount);
                    break;
                }
                // Second Player
                secondPlayerDie = random.Next(1, 7);
                secondPlayerDiceCount++;
                secondPlayerStatus = random.Next(0, 3);
                switch (secondPlayerStatus)
                {
                    case NO_PLAY:
                        secondPlayerPosition += 0;
                        break;
                    case LADDER:
                        if (secondPlayerPosition > WIN_SCORE)
                            secondPlayerPosition -= secondPlayerDie;
                        while (secondPlayerStatus == LADDER)
                        {
                            secondPlayerStatus = random.Next(0, 3);
                            if (secondPlayerStatus == LADDER)
                            {
                                secondPlayerDie = random.Next(1, 7);
                                secondPlayerPosition += secondPlayerDie;
                                secondPlayerDiceCount++;
                                if (secondPlayerPosition > WIN_SCORE)
                                    secondPlayerPosition -= secondPlayerDie;
                                if (secondPlayerPosition == WIN_SCORE)
                                    break;
                            }
                            if (secondPlayerStatus == SNAKE)
                            {
                                secondPlayerPosition -= secondPlayerDie;
                                secondPlayerDiceCount++;
                                break;
                            }
                        }
                        break;
                    default:
                        secondPlayerPosition -= secondPlayerDie;
                        break;
                }
                if (secondPlayerPosition < 0)
                {
                    secondPlayerPosition = 0;
                    Console.WriteLine("Second player position is:" + secondPlayerPosition);
                }
                if (secondPlayerPosition < WIN_SCORE)
                {
                    secondPlayerPosition += secondPlayerDie;
                    Console.WriteLine("Second player position is:" + secondPlayerPosition);
                }
                if (secondPlayerPosition == WIN_SCORE)
                {
                    Console.WriteLine("Second player reaches the winning position:" + secondPlayerPosition);
                    Console.WriteLine("Total number of times rolled dice by second player is:" + secondPlayerDiceCount);
                    break;
                }
            }
        }
    }
}
