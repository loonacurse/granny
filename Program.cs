using System.Security.Cryptography.X509Certificates;
using System;
using System.Runtime.CompilerServices;
using System.Timers;
using Timer = System.Threading.Timer;
using System.Threading;

namespace Granny
{
    class Program
    {
        System.Timers.Timer aTimer;
        const int H = 5;
        const int W = 10;
        int[,] GameField = new int[H, W];
        int n = 0;
                //bool IndexOutOfRangeException = false;
        static void Main(string[] args)
        {
            Program program = new Program();
                program.Game();
            Console.ReadKey();
        }
        void Game()
        {
            while (true)
            {
                //Console.CursorVisible = false;
                Load();
                //Move();
                Print();
                //Timer();
                Thread.Sleep(500);
            }



        }
        void Load()
        {
            if (n != 5)
            {
                for (int i = 0; i < H; i++)
                {
                    for (int j = 0; j < W; j++)
                    {
                        if (j == 0 + n || j == 1 + n || j == 5 + n || j == 6 + n)
                        {
                            GameField[i, j] = 2;
                        }
                        else
                        {
                            GameField[i, j] = 0;
                        }

                    }
                }
                //Thread.Sleep(500);
                n++;
            }            
            else if (n == 5)
            {
                n = 0;
                for (int i = 0; i < H; i++)
                {
                    for (int j = 0; j < W; j++)
                    {
                        if (j == 0 + n || j == 1 + n || j == 5 + n || j == 6 + n)
                        {
                            GameField[i, j] = 2;
                        }
                        else
                        {
                            GameField[i, j] = 0;
                        }

                    }
                }
                //Thread.Sleep(500);
                n++;
            }
            
        }

        //int Method(int value)
        //{
        //    for(int i = 0; i < H; i++)
        //    {
        //        for(int j=0; j<W; j++)
        //        {
        //            if (GameField[i, j-1] == value)
        //            {
        //                return k=1;
        //            }
        //            else if (GameField[i, j + 1] == value)
        //            {
        //                return k = 1;
        //            }
        //        }
        //    }
        //    return k = 0;
        //}
        //void Move()
        //{
        //    for(int i = 0; i < H; i++)
        //    {
        //        for(int j = 0; j < W; j++)
        //        {
        //            if (GameField[i, j + 1] == 2)
        //            {
        //                GameField[i, j] = 0;
        //                GameField[i, j + 1] = 2;
        //            }
        //            else
        //            {
        //                if (GameField[i, j + 1] == 0)
        //                {
        //                    GameField[i, j] = 0;
        //                    GameField[i, j + 1] = 2;
        //                }
        //                else
        //                {

        //                    if (GameField[i, j - 1] == 2)
        //                    {
        //                        GameField[i, j] = 2;
        //                        GameField[i, j - 1] = 0;
        //                    }
        //                    else
        //                    {
        //                        if (GameField[i, j - 1] == 0)
        //                        {
        //                            GameField[i, j] = 0;
        //                            GameField[i, j - 1] = 0;
        //                        }
        //                    }
        //                }

        //            }
        //        }
        //    }

        //}
        void Print() //Object source, System.Timers.ElapsedEventArgs e
        {
            Console.Clear();
            for (int y = 0; y < H; y++)
            {
                for (int x = 0; x < W; x++)
                {
                    Console.SetCursorPosition(x,y);
                    switch (GameField[y,x])
                    {
                        case 0:
                            Console.Write(" ");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("x");
                            break;
                        default:
                            Console.Write("#");
                            break;
                    }
                }
            }
        }
        //void Timer()
        //{
        //    aTimer = new System.Timers.Timer();
        //    aTimer.Interval = 1000;
        //    aTimer.Elapsed += Print;
        //    aTimer.AutoReset = true;
        //    aTimer.Enabled = true;
        //}
    }
}


