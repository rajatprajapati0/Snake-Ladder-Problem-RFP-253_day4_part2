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
        

           while (step < 100)
           {
                   int dice = obj.Next(1, 7);
                   Console.WriteLine("you got on dice " + dice);
                   int option = obj.Next(0, 3);

             switch (option)
             {
                    case 0:
                        Console.WriteLine("no play");
                        position = position + 0;
                        Console.WriteLine("your position " + position);
                        step = position;
                        break;
                    case 1:
                        Console.WriteLine("play go ahed");
                        position = position + dice;
                        step = position;
                        if (step > 100)
                        {
                            position = position - dice;
                            Console.WriteLine("you can not move more than 100 step dice again yor position is " + position);
                            step = position;
                        }
                        else
                        {
                            Console.WriteLine("your position " + position);
                            step = position;
                        }
                        
                        break;
                    case 2:
                       
                        Console.WriteLine("play go back");

                              position = position - dice;

                        step = position;
                        if (step<0) 
                        {
                            position = 0;
                            step = position;
                        }
                        else
                        {
                            Console.WriteLine("your position " + position);
                            step = position;
                        }
                        break;

                
             }
           }
          

        }
    }
}
