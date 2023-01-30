using System;

namespace Sanke_And_Lader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Snake & Ladder Simulator******");
            Console.WriteLine("Snake and Ladder\ngame played with two players at start\r\nposition 0");

            int resultOFplayer1 = 0;
            int resultOFplayer2 = 0;
           Game_logic obj= new Game_logic();
            for (int i = 1; i <= 2; i++) 
            {
             if (i==1)
                {
                    Console.WriteLine("**********player one**********\n");
                    int player1 = obj.logic();
                    resultOFplayer1 = player1;
                }

             else
                {
                    Console.WriteLine("\n********player two********\n");
                    int player2 = obj.logic();
                    resultOFplayer2 = player2;
                }
            }
            Console.WriteLine("  result OF player 1 -" + resultOFplayer1);
            Console.WriteLine("  result OF player 2 -" + resultOFplayer2);
            if (resultOFplayer1 < resultOFplayer2)
            {
                Console.WriteLine("*****player one is winner*****");

            }
            else 
            {
                Console.WriteLine("*****player two is winner*****");

            }

        }
    }
}
