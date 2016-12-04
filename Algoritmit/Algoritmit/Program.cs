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

        public int ACount = 0;
        public int BCount = 0;
        public int CCount = 0;

        public void RunProgram()
        {

            int choice = 0;
            int size = 0;
            int random = 0;

            // Alustetaan taulukot
            string A = "";
            string B = "";
            string C = "";

            char letter;

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
                                random = num.Next(0, 3);
                                A = A + GenLetter(random);
                                random = num.Next(0, 3);
                                B = B + GenLetter(random);
                                random = num.Next(0, 3);
                                C = C + GenLetter(random);
                            }

                            Console.WriteLine("Finished generating {0} random letters to all 3 strings", size);
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
                                    if (ia < i)
                                    {
                                        letter = GetLetter(A, ia);
                                        ia++;
                                        A = Allocate(letter, A);
                                    }
                                }
                                else if (n == 1 || n == 5 || n == 9)
                                {
                                    if (ib < i)
                                    {
                                        letter = GetLetter(B, ib);
                                        ib++;
                                        B = Allocate(letter, B);
                                    }
                                }
                                else if (n == 3 || n == 7)
                                {
                                    if (ic < i)
                                    {
                                        letter = GetLetter(C, ic);
                                        ic++;
                                        C = Allocate(letter, C);
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
                            Console.WriteLine("Time to completion {0} milliseconds", Ms.ElapsedMilliseconds);
                            Console.WriteLine("Letters A: {0}\nLetters B: {1}\nLetters C: {2}", ACount, BCount, CCount);

                            Console.ReadLine();
                            break;
                        }

                    case 4:
                        {
                            A = "";
                            B = "";
                            C = "";

                            ACount = 0;
                            BCount = 0;
                            CCount = 0;

                            size = 0;

                            ia = 0;
                            ib = 0;
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

        public string GenLetter (int r)
        {
            string Letter = "";
            switch (r)
            {
                case 0:
                    {
                        Letter = "A";
                        return Letter;
                    }
                case 1:
                    {
                        Letter = "B";
                        break;
                    }
                case 2:
                    {
                        Letter = "C";
                        break;
                    }
            }
            return Letter;
        }

        public char GetLetter(string X, int ix)
        {
            char Letter = 'D';
            if (ix <= i)
            {
                Letter = X[0];
                return Letter;
            }
            return Letter;
        }

        //----------------------------------------------
        // Katsoo taulukon seuraavan numeron ja lisää sen nimisen int muuttujan arvoa yhdellä
        // Tämän jälkeen kyseinen numero taulukosta poistetaan
        public string Allocate(char Letter, string SX)
        {

            switch (Letter)
            {
                case 'A':
                    {
                        ACount++;
                        SX = SX.Remove(0,1);
                        return SX;
                    }

                case 'B':
                    {
                        BCount++;
                        SX = SX.Remove(0, 1);
                        return SX;
                    }

                case 'C':
                    {
                        CCount++;
                        SX = SX.Remove(0, 1);
                        return SX;
                    }
                case 'D':
                    {
                        return SX;
                    }
            }

            return SX;
        }

    }

}
