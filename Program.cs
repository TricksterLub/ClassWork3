// See https://aka.ms/new-console-template for more information
/*
int i = 1;
int unput=0;
for (; i<11; i++)
{
    int input;
    int.TryParse(Console.ReadLine(), out input);
    if (input >unput && input>=0)
    {
        unput = input;
    } else if (input>unput)
    {
        unput = input;
    }
}
Console.WriteLine(unput);
*/


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            int Shiftx = 5,Shifty = 5;
            Console.WriteLine("-----------");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-----------");
            Console.SetCursorPosition(Shiftx+x, Shifty+y);
            ConsoleKeyInfo input;
            
                while (true)
                {
                    input = Console.ReadKey(true);
                    
                    switch (input.Key)
                    {
                        case ConsoleKey.W:
                            {   
                            if (y >-4)
                            {
                                y--;
                                
                            }
                            break;
                            }
                        case ConsoleKey.A:
                            { if (x > -4)
                            {
                                x--;
                            }
                                break;
                            }
                        case ConsoleKey.S:
                            {  if (y != 4)
                            {
                                y++;
                            }
                                break;
                            }
                        case ConsoleKey.D:
                            {   if (x != 4)
                            {
                                x++;
                            }
                                break;
                            }
                    }
                    Console.SetCursorPosition(Shiftx+x, Shifty+y);
                } 
            
            }
            

        }
    }

