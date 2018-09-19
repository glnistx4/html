using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    /*
    class bard
    {
        public void board (float board)
        {
            int road = 12;
            int end = 5;
            for (int i = 0; i < 0; i++);

        }

        
    }
    */
    class caller
    { 
        public static void Main(string[] args)
        {
            int ye = 0;
            int yu = 0;
            int yi = 0;
            int ya = 0;
            int turn = 0;
            int da=0;
            int yo;
            player place = new player();
            Console.WriteLine("WELCOME TO LUDO");
            Console.WriteLine("OF");
            Console.WriteLine("HELL!!!");
            Console.ReadLine();
            Console.WriteLine("How many players? (1-4)");


            switch (Console.ReadLine())
            {
                case "4": // 4 players
                    while (da != 1)
                    { 
                       do // player 1
                        {
                            Random hej = new Random();
                            yo = hej.Next(1, 7);
                            Console.WriteLine("which dot to move?");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    ye = ye + yo;
                                    place.dot1(ye);
                                    break;
                                case "2":
                                    yu = yu + yo;
                                    place.dot2(yu);
                                    break;
                                case "3":
                                    yi = yi + yo;
                                    place.dot3(yi);
                                    break;
                                case "4":
                                    ya = ya + yo;
                                    place.dot4(ya);
                                    break;
                            }
                            turn++;
                        } while (turn == 0);

                       do // player 2
                    {
                        Random hej = new Random();
                        yo = hej.Next(1, 7);
                        Console.WriteLine("which dot to move?");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                ye = ye + yo;
                                place.dot1(ye);
                                break;
                            case "2":
                                yu = yu + yo;
                                place.dot2(yu);
                                break;
                            case "3":
                                yi = yi + yo;
                                place.dot3(yi);
                                break;
                            case "4":
                                ya = ya + yo;
                                place.dot4(ya);
                                break;
                        }
                        turn++;
                    } while (turn == 1);

                       do // player 3
                    {
                        Random hej = new Random();
                        yo = hej.Next(1, 7);
                        Console.WriteLine("which dot to move?");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                ye = ye + yo;
                                place.dot1(ye);
                                break;
                            case "2":
                                yu = yu + yo;
                                place.dot2(yu);
                                break;
                            case "3":
                                yi = yi + yo;
                                place.dot3(yi);
                                break;
                            case "4":
                                ya = ya + yo;
                                place.dot4(ya);
                                break;
                        }
                        turn++;
                    } while (turn == 2);

                       do // player 4
                    {
                        Random hej = new Random();
                        yo = hej.Next(1, 7);
                        Console.WriteLine("which dot to move?");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                ye = ye + yo;
                                place.dot1(ye);
                                break;
                            case "2":
                                yu = yu + yo;
                                place.dot2(yu);
                                break;
                            case "3":
                                yi = yi + yo;
                                place.dot3(yi);
                                break;
                            case "4":
                                ya = ya + yo;
                                place.dot4(ya);
                                break;
                        }
                        turn = 0;
                    } while (turn == 3);
                    }
                    break;
                case "3":

                    break;

            }

        }
    }
}