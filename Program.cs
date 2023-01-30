using System;

namespace Sanke_And_Lader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Snake & Ladder Simulator******");

            Console.WriteLine("Snake and Ladder\ngame played with single player at start\r\nposition 0");


            int position = 0;
            int step = 0;
            Random obj=new Random();
            int dice = obj.Next(1,7);

            Console.WriteLine("dice no."+dice);

           
            int option=obj.Next(0,3);
            switch(option)
            {
             case 0: Console.WriteLine("no play");
                    position = position + 0;
             break;
             case 1: Console.WriteLine("play go ahed");
                    position= position + dice;
             break;
             case 2: Console.WriteLine("play go back");
            
                    position = position - dice ;

             break;
            
            }
          

        }
    }
}
