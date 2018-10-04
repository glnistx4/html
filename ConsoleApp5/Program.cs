using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    class fields
    {
        public int Road;
        public int End;
        public fields (int road, int end)
        {
            Road = road;
            End = end;
        }
    }

    class caller
    { 
        public static void Main(string[] args)
        {

            int ye = 0;     // dot 1
            int yu = 0;     // dot 2
            int yi = 0;     // dot 3
            int ya = 0;     // dot 4
            int turn = 0;   // turn counter
            int da=0;       // so the game keeps goin
            int path = 52;  // the amount of steps to end
            int end = 5;    // the last part of the road
            int dat = 0;    // the dot of end
            int hej;        // Dice
            int yo;         // postion controller
            int cpu = 0;    // computer
        
            player place = new player();        // package from Player class
            Random START = new Random();        // package from class Dice
            

            Console.WriteLine("WELCOME TO LUDO");
            Console.WriteLine("OF");
            Console.WriteLine("HELL!!!");
            Console.ReadLine();
            Console.WriteLine("How many players? (1-4)");

            switch (Console.ReadLine())
            {
                case "4": // 4 players
                    Console.WriteLine("Lets us see who willbe the 1st sacrifice!!! (die roll)");
                    hej = START.Next(1, 4);
                    if (hej == 1)
                    { 
                        while (da != 4)
                    {
                        do // player 1
                        {
                            dice dieroll = new dice();
                            hej = dieroll.Value;
                            yo = hej;

                            Console.WriteLine("which dot to move?");
                            Console.WriteLine("Player 2\nwhich dot to move?");
                            Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                            Console.WriteLine(hej);

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
                                if (path <= ya || path <= yi || path <= yu || path <= ye)
                                {
                                    ya = ya - path;
                                    yi = yi - path;
                                    yu = yu - path;
                                    ye = ye - path;
                                }
                                else if (path == ya || path == yu || path == ye || path == yi)
                                {
                                    dat = hej;
                                    if (dat == end)
                                    {
                                        da++;
                                    }
                                }
                            turn++;
                        } while (turn == 0);

                        do // player 2
                        {
                            dice dieroll = new dice();
                            hej = dieroll.Value;
                            yo = hej;

                            Console.WriteLine("which dot to move?");
                            Console.WriteLine("Player 3\nwhich dot to move?");
                            Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                            Console.WriteLine(hej);

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
                            dice dieroll = new dice();
                            hej = dieroll.Value;
                            yo = hej;

                            Console.WriteLine("which dot to move?");
                            Console.WriteLine("Player 4\nwhich dot to move?");
                            Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                            Console.WriteLine(hej);

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
                            dice dieroll = new dice();
                            hej = dieroll.Value;
                            yo = hej;

                            Console.WriteLine("which dot to move?");
                            Console.WriteLine("Player 1\nwhich dot to move?");
                            Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                            Console.WriteLine(hej);

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
                    }
                    else if (hej == 2)
                    {
                        while (da != 1)
                        {

                            do // player 1
                            {
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("Player 1\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;
                                Console.WriteLine("Player 2\nwhich dot to move?");
                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 3\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 4\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                    }
                    else if (hej == 3)
                    {
                        while (da != 1)
                        {

                            do // player 1
                            {
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("Player 4\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;
                                Console.WriteLine("Player 1\nwhich dot to move?");
                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 2\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 3\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                    }
                    else if (hej == 4)
                    {
                        while (da != 1)
                        {

                            do // player 1
                            {
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("Player 3\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;
                                Console.WriteLine("Player 4\nwhich dot to move?");
                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 1\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 2\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                    }
                    break;
                case "2":   // 2 players + 2 cpu
                    Console.WriteLine("Lets us see who willbe the 1st sacrifice!!! (die roll)");
                    hej = START.Next(1, 4);
                    if (hej == 1)
                    {
                        while (da != 1)
                        {

                            do // player 1
                            {
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 2\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 3\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                cpu = dieroll.Com;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 4\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

                                switch (cpu)
                                {
                                    case 1:
                                        ye = ye + yo;
                                        place.dot1(ye);
                                        break;
                                    case 2:
                                        yu = yu + yo;
                                        place.dot2(yu);
                                        break;
                                    case 3:
                                        yi = yi + yo;
                                        place.dot3(yi);
                                        break;
                                    case 4:
                                        ya = ya + yo;
                                        place.dot4(ya);
                                        break;
                                }
                                turn++;
                            } while (turn == 2);

                            do // player 4
                            {
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                cpu = dieroll.Com;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 1\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

                                switch (cpu)
                                {
                                    case 1:
                                        ye = ye + yo;
                                        place.dot1(ye);
                                        break;
                                    case 2:
                                        yu = yu + yo;
                                        place.dot2(yu);
                                        break;
                                    case 3:
                                        yi = yi + yo;
                                        place.dot3(yi);
                                        break;
                                    case 4:
                                        ya = ya + yo;
                                        place.dot4(ya);
                                        break;
                                }
                                turn = 0;
                            } while (turn == 3);
                        }
                    }
                    else if (hej == 2)
                    {
                        while (da != 1)
                        {

                            do // player 1
                            {
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("Player 1\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;
                                Console.WriteLine("Player 2\nwhich dot to move?");
                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                cpu = dieroll.Com;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 3\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

                                switch (cpu)
                                {
                                    case 1:
                                        ye = ye + yo;
                                        place.dot1(ye);
                                        break;
                                    case 2:
                                        yu = yu + yo;
                                        place.dot2(yu);
                                        break;
                                    case 3:
                                        yi = yi + yo;
                                        place.dot3(yi);
                                        break;
                                    case 4:
                                        ya = ya + yo;
                                        place.dot4(ya);
                                        break;
                                }
                                turn++;
                            } while (turn == 2);

                            do // player 4
                            {
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                cpu = dieroll.Com;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 4\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

                                switch (cpu)
                                {
                                    case 1:
                                        ye = ye + yo;
                                        place.dot1(ye);
                                        break;
                                    case 2:
                                        yu = yu + yo;
                                        place.dot2(yu);
                                        break;
                                    case 3:
                                        yi = yi + yo;
                                        place.dot3(yi);
                                        break;
                                    case 4:
                                        ya = ya + yo;
                                        place.dot4(ya);
                                        break;
                                }
                                turn = 0;
                            } while (turn == 3);
                        }
                    }
                    else if (hej == 3)
                    {
                        while (da != 1)
                        {

                            do // player 1
                            {
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("Player 4\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;
                                Console.WriteLine("Player 1\nwhich dot to move?");
                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 2\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 3\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                    }
                    else if (hej == 4)
                    {
                        while (da != 1)
                        {

                            do // player 1
                            {
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;

                                Console.WriteLine("Player 3\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;
                                Console.WriteLine("Player 4\nwhich dot to move?");
                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

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
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                cpu = dieroll.Com;
                                yo = hej;

                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 1\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

                                switch (cpu)
                                {
                                    case 1:
                                        ye = ye + yo;
                                        place.dot1(ye);
                                        break;
                                    case 2:
                                        yu = yu + yo;
                                        place.dot2(yu);
                                        break;
                                    case 3:
                                        yi = yi + yo;
                                        place.dot3(yi);
                                        break;
                                    case 4:
                                        ya = ya + yo;
                                        place.dot4(ya);
                                        break;
                                }
                                turn++;
                            } while (turn == 2);

                            do // player 4
                            {
                                dice dieroll = new dice();
                                hej = dieroll.Value;
                                yo = hej;
                                cpu = dieroll.Com;
                                Console.WriteLine("which dot to move?");
                                Console.WriteLine("Player 2\nwhich dot to move?");
                                Console.WriteLine("Zhe Dots are on {0},{1},{2} and{3}", ye, yu, yi, ya);
                                Console.WriteLine(hej);

                                switch (cpu)
                                {
                                    case 1:
                                        ye = ye + yo;
                                        place.dot1(ye);
                                        break;
                                    case 2:
                                        yu = yu + yo;
                                        place.dot2(yu);
                                        break;
                                    case 3:
                                        yi = yi + yo;
                                        place.dot3(yi);
                                        break;
                                    case 4:
                                        ya = ya + yo;
                                        place.dot4(ya);
                                        break;
                                }
                                turn = 0;
                            } while (turn == 3);
                        }
                    }

                    break;

            }

        }
    }
}