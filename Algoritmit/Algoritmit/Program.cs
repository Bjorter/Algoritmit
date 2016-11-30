using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Algoritmit
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();

            app.RunProgram();
        }
    }

    class App
    {
        public int i = 0;
        public int ia = 0;
        public int ib = 0;
        public int ic = 0;
        public int n = 0;

        public int Zero = 0;
        public int One = 0;
        public int Two = 0;
        public int Three = 0;
        public int Four = 0;
        public int Five = 0;
        public int Six = 0;
        public int Seven = 0;
        public int Eight = 0;
        public int Nine = 0;

        public void RunProgram()
        {

            int choice = 0;
            int size = 0;

            // Alustetaan taulukot
            int[] A = new int[10000000];
            int[] B = new int[10000000];
            int[] C = new int[10000000];

            Stopwatch Ms = new Stopwatch();

            Random num = new Random();

            while (choice != 5)
            {
                // Alkutervehdykset ja toiminnan valinta
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nWelcome! Choose a number and press enter, please");
                Console.WriteLine("1. Generate Data");
                Console.WriteLine("2. Run allocation program");
                Console.WriteLine("3. View results");
                Console.WriteLine("4. Reset data");
                Console.WriteLine("5. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {

                            Console.WriteLine("How many random numbers will be allocated to each string?");
                            size = int.Parse(Console.ReadLine());

                            for (i = 0; i < size; i++)
                            {
                                A[i] = num.Next(0, 10);

                                B[i] = num.Next(0, 10);

                                C[i] = num.Next(0, 10);
                            }

                            Console.WriteLine("Finished generating {0} random numbers to all 3 strings", size);
                            Console.ReadLine();

                            break;
                        }

                    case 2:
                        {
                            Ms.Start();

                            while (ic < i)
                            {
                                if (size == 0)
                                {
                                    break;
                                }
                                else if (n == 0 || n == 2 || n == 4 || n == 6 || n == 8)
                                {
                                    if (ia <= i)
                                    {
                                        ia = Allocate(A, ia);
                                    }
                                }
                                else if (n == 1 || n == 5 || n == 9)
                                {
                                    if (ib <= i)
                                    {
                                        ib = Allocate(B, ib);
                                    }
                                }
                                else if (n == 3 || n == 7)
                                {
                                    if (ic <= i)
                                    {
                                        ic = Allocate(C, ic);
                                    }
                                }

                                n++;

                                if (n == 10)
                                { n = 0; }
                            }

                            Ms.Stop();

                            Console.WriteLine("Done allocating!");
                            Console.ReadLine();

                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("The results are as follows!");
                            Console.WriteLine("Time to completion {0} seconds", Ms.ElapsedMilliseconds);
                            Console.WriteLine("Zeros: {0} Ones: {1}, Twos: {2} Threes: {3} Fours: {4}", Zero, One, Two, Three, Four);
                            Console.WriteLine("Fives: {0} Sixes: {1} Sevens: {2} Eights: {3} Nines: {4}", Five, Six, Seven, Eight, Nine);

                            Console.ReadLine();
                            break;
                        }

                    case 4:
                        {
                            Zero = 0;
                            One = 0;
                            Two = 0;
                            Three = 0;
                            Four = 0;
                            Five = 0;
                            Six = 0;
                            Seven = 0;
                            Eight = 0;
                            Nine = 0;

                            size = 0;

                            ia = 0;
                            B = null;
                            ib = 0;
                            C = null;
                            ic = 0;
                            n = 0;

                            Ms.Reset();

                            Console.WriteLine("Data reset!");
                            Console.ReadLine();

                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Exiting program!");
                            Console.ReadLine();

                            break;
                        }
                }
            }

        }

        //----------------------------------------------
        // Katsoo taulukon seuraavan numeron ja lisää sen nimisen int muuttujan arvoa yhdellä
        // Tämän jälkeen kyseinen numero taulukosta poistetaan
        public int Allocate(int[] s, int ix)
        {
            int num = s[ix];

            // Jos seuraava numero taulukossa puuttuu, lähdetään aliohjelmasta tekemättä mitään
            if (ix == i)
            {
                return ix;
            }

            ix++;

            switch (num)
            {
                case 0:
                    {
                        Zero++;
                        return ix;
                    }

                case 1:
                    {
                        One++;
                        return ix;
                    }

                case 2:
                    {
                        Two++;
                        return ix;
                    }

                case 3:
                    {
                        Three++;
                        return ix;
                    }

                case 4:
                    {
                        Four++;
                        return ix;
                    }

                case 5:
                    {
                        Five++;
                        return ix;
                    }

                case 6:
                    {
                        Six++;
                        return ix;
                    }

                case 7:
                    {
                        Seven++;
                        return ix;
                    }

                case 8:
                    {
                        Eight++;
                        return ix;
                    }

                case 9:
                    {
                        Nine++;
                        return ix;
                    }
            }

            return ix;

        }

    }

}
