using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Calculator
{
    internal class Resistance
    {
        public static void ResistanceMain()
        {
            Console.WriteLine("\nWelcome to Resistance Calculator!\nWhat You Are Trying To Solve? ");
            Console.WriteLine("\n(1)Resistance of Wires\n(2)Resistance of 4 Band Resistors\n(3)Resistance of 5 Band Resistors");
            Console.Write("\nYour Choice:\t");
            string Selection = Console.ReadLine()!;
            Console.Clear();

            switch (Selection)
            {
                case "1":
                    Console.WriteLine(FirstSelection());
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.WriteLine(SecondSelection());
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    Console.WriteLine(ThirdSelection());
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        public static string ThirdSelection()
        {
            string Answer = "";
            Console.WriteLine("Enter Color For First Digit: \n(1)Black\n(2)Brown\n(3)Red\n(4)Orange\n(5)Yellow\n(6)Green\n(7)Blue\n(8)Violet\n(9)Gray\n(10)White");
            string SelectionFD = Console.ReadLine()!;

            double FD = (Digits(SelectionFD)) * 100;

            Console.WriteLine("Enter Color For Second Digit: \n(1)Black\n(2)Brown\n(3)Red\n(4)Orange\n(5)Yellow\n(6)Green\n(7)Blue\n(8)Violet\n(9)Gray\n(10)White");
            string SelectionSD = Console.ReadLine()!;

            double SD = (Digits(SelectionSD)) * 10;

            Console.WriteLine("Enter Color For Third Digit: \n(1)Black\n(2)Brown\n(3)Red\n(4)Orange\n(5)Yellow\n(6)Green\n(7)Blue\n(8)Violet\n(9)Gray\n(10)White");
            string SelectionTD = Console.ReadLine()!;

            double TD = Digits(SelectionTD);

            Console.WriteLine("Enter Color For Multiplier: \n(1)Black\n(2)Brown\n(3)Red\n(4)Orange\n(5)Yellow\n(6)Green\n(7)Blue\n(8)Gold\n(9)Silver");
            string SelectionMult = Console.ReadLine()!;

            double mult = Multiplier(SelectionMult);

            Console.WriteLine("Enter Color For Tolerance: \n(1)Brown\n(2)Red\n(3)Green\n(4)Blue\n(5)Violet\n(6)Gold\n(7)Silver");
            string SelectionTol = Console.ReadLine()!;

            double T = Tolerance(SelectionTol);

            double R = (FD + SD + TD) * mult;
            double Min = R - (R * T);
            double Max = R + (R * T);

            Answer = "\nResistance :" + Min + " up to " + Max + " ohms";

            if ((FD == 999) || (SD == 999) || (mult == 999) || (T == 999))
            {
                Answer = "\nInvalid Input!";
            }
            return Answer;

        }
        public static string SecondSelection()
        {
            string Answer = "";
            Console.WriteLine("Enter Color For First Digit: \n(1)Black\n(2)Brown\n(3)Red\n(4)Orange\n(5)Yellow\n(6)Green\n(7)Blue\n(8)Violet\n(9)Gray\n(10)White");
            string SelectionFD = Console.ReadLine()!;

            double FD = (Digits(SelectionFD))*10;

            Console.WriteLine("Enter Color For Second Digit: \n(1)Black\n(2)Brown\n(3)Red\n(4)Orange\n(5)Yellow\n(6)Green\n(7)Blue\n(8)Violet\n(9)Gray\n(10)White");
            string SelectionSD = Console.ReadLine()!;

            double SD = (Digits(SelectionSD));

            Console.WriteLine("Enter Color For Multiplier: \n(1)Black\n(2)Brown\n(3)Red\n(4)Orange\n(5)Yellow\n(6)Green\n(7)Blue\n(8)Gold\n(9)Silver");
            string SelectionMult = Console.ReadLine()!;

            double mult = Multiplier(SelectionMult);

            Console.WriteLine("Enter Color For Tolerance: \n(1)Brown\n(2)Red\n(3)Green\n(4)Blue\n(5)Violet\n(6)Gold\n(7)Silver");
            string SelectionTol = Console.ReadLine()!;

            double T = Tolerance(SelectionTol);

            double R = (FD + SD) * mult;
            double Min = R - (R * T);
            double Max = R + (R * T);

            Answer = "\nResistance :"+Min+" up to "+Max+" ohms";

            if ((FD == 999)||(SD ==999)||(mult == 999)||(T == 999))
            {
                Answer = "\nInvalid Input!";
            }
            return Answer;

        }

        public static string FirstSelection()
        {
            string Answer = "";
            double L, D;
            Console.WriteLine("Enter Material: \n(1)Iron\n(2)Copper\n(3)Aluminum\n(4)Silver\n(5)Lead\n(6)Tungsten\n(7)Platinum");
            string Selection = Console.ReadLine()!;

            double Rho = Constants(Selection);
            Console.Write("Enter Length of Wire (in meters): ");
            if (!double.TryParse(Console.ReadLine(), out L))
            {
                Answer = "Invalid Input!";
            }
            else
            {
                Console.Write("Enter Diameter of Wire (in meters): ");
                if (!double.TryParse(Console.ReadLine(), out D))
                {
                    Answer = "Invalid Input!";
                }
                else
                {
                    double A, R, r;

                    r = D / 2;

                    A = Math.PI * (r * r);
                    R = (Rho * L) / A;

                    Answer = "\nResistance: " + R + " Ohms";

                    if (Rho == 999)
                    {
                        Answer = "\nInvalid Input!";
                    }

                }

            }
            return Answer;
        }

        public static double Constants(string num1)
        {
            double rho;
            switch (num1)
            {
                case "1":
                    rho = 0.0000000971;
                    break;
                case "2":
                    rho = 0.0000000168;
                    break;
                case "3":
                    rho = 0.0000000265;
                    break;
                case "4":
                    rho = 0.0000000159;
                    break;
                case "5":
                    rho = 0.00000022;
                    break;
                case "6":
                    rho = 0.0000000561; 
                    break;
                case "7":
                    rho = 0.000000106;
                    break;
                default:
                    rho = 999;
                    break;

            }
            return rho;
        }
        public static double Digits(string num1)
        {
            double FD;
            switch (num1)
            {
                case "1":
                    FD = 0;
                    break;
                case "2":
                    FD = 1;
                    break;
                case "3":
                    FD = 2;
                    break;
                case "4":
                    FD = 3;
                    break;
                case "5":
                    FD = 4;
                    break;
                case "6":
                    FD = 5;
                    break;
                case "7":
                    FD = 6;
                    break;
                case "8":
                    FD = 7;
                    break;
                case "9":
                    FD = 8;
                    break;
                case "10":
                    FD = 9;
                    break;
                default:
                    FD = 999;
                    break;

            }
            return FD;
        }
        public static double Multiplier(string num1)
        {
            double M;
            switch (num1)
            {
                case "1":
                    M = 1;
                    break;
                case "2":
                    M = 10;
                    break;
                case "3":
                    M = 100;
                    break;
                case "4":
                    M = 1000;
                    break;
                case "5":
                    M = 10000;
                    break;
                case "6":
                    M = 100000;
                    break;
                case "7":
                    M = 1000000;
                    break;
                case "8":
                    M = 0.1;
                    break;
                case "9":
                    M = 0.01;
                    break;
                default:
                    M = 999;
                    break;

            }
            return M;
        }
        public static double Tolerance(string num1)
        {
            double T;
            switch (num1)
            {
                case "1":
                    T = 0.01;
                    break;
                case "2":
                    T = 0.02;
                    break;
                case "3":
                    T = 0.005;
                    break;
                case "4":
                    T = 0.0025;
                    break;
                case "5":
                    T = 0.001;
                    break;
                case "6":
                    T = 0.05;
                    break;
                case "7":
                    T = 0.1;
                    break;
                default:
                    T = 999;
                    break;

            }
            return T;
        }
    }
}
