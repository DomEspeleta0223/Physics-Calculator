using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Calculator
{
    internal static class FreeFall
    {
        public const double Ag = 9.81;
        public static void FF_Main()
        {

            Console.WriteLine("\nWelcome to Kinematics Free Fall!\nWhat You Are Trying To Solve?");
            Console.WriteLine("\n(1)An Object in Motion Going Upward to a Stop\n(2)An Object in Falling From A Height\n(3)An Object in Motion Going Upward then Falling Back");
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
        public static string FirstSelection()
        {
            string Answer = "";

            Console.WriteLine("\nWhat Are The Given Quantities??\t");
            Console.WriteLine("\n(1)Initial Velocity Only\n(2)Height Only\n(3)Time Only");
            Console.Write("\nYour Choice:\t");
            string Selection = Console.ReadLine()!;
            double Vi, H, T;

            switch (Selection)
            {
                case "1":
                    Console.Write("\nInput Initial Velocity:\t");
                    if (!double.TryParse(Console.ReadLine(), out Vi))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        T = Vi / Ag;
                        H = ((Ag * T * T) / 2);
                        Answer = "\nIt takes " + T + " seconds for time to reach its peak with a height of " + H + " meters";
                        if (Vi <= 0)
                        {
                            Answer = "\nThe object has not been thrown at all";
                        }
                    }
                    break;
                case "2":
                    Console.Write("\nInput Height:\t");
                    if (!double.TryParse(Console.ReadLine(), out H))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        Vi = Math.Sqrt(2 * Ag * H);
                        T = Vi / Ag;
                        Answer = "\nIt takes " + T + " seconds for time to reach its peak with an initial velocity of " + Vi + " m/s";

                        if (H <= 0)
                        {
                            Answer = "\nThe object has not been thrown at all";
                        }
                    }
                    break;
                case "3":
                    Console.Write("\nInput Time:\t");
                    if (!double.TryParse(Console.ReadLine(), out T))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        Vi = Ag * T;
                        H = ((Ag * T * T) / 2);
                        Answer = "\nIt reached a height of " + H + " meters with an initial velocity of " + Vi + " m/s";

                        if (T <= 0)
                        {
                            Answer = "\nThe object has not been thrown at all";
                        }
                    }
                    break;
                default:
                    Answer = "\nInvalid Input!";
                    break;

            }
            return Answer;
        }

        public static string SecondSelection()
        {
            string Answer = "";

            Console.WriteLine("\nWhat Are The Given Quantities??\t");
            Console.WriteLine("\n(1)Final Velocity Only\n(2)Height Only\n(3)Time Only");
            Console.Write("\nYour Choice:\t");
            string Selection = Console.ReadLine()!;
            double Vf, H, T;

            switch (Selection)
            {
                case "1":
                    Console.Write("\nInput Final Velocity:\t");
                    if (!double.TryParse(Console.ReadLine(), out Vf))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        T = Vf / Ag;
                        H = ((Ag * T * T) / 2);
                        Answer = "\nIt takes " + T + " seconds for time to reach the ground with a height of " + H + " meters";
                        if (Vf <= 0)
                        {
                            Answer = "\nThe object has not been fall at all";
                        }
                    }
                    break;
                case "2":
                    Console.Write("\nInput Height:\t");
                    if (!double.TryParse(Console.ReadLine(), out H))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        Vf = Math.Sqrt(2 * Ag * H);
                        T = Vf / Ag;
                        Answer = "\nIt takes " + T + " seconds for time to reach the ground with an final velocity of " + Vf + " m/s before impact";

                        if (H <= 0)
                        {
                            Answer = "\nThe object has not been fall at all";
                        }
                    }
                    break;
                case "3":
                    Console.Write("\nInput Time:\t");
                    if (!double.TryParse(Console.ReadLine(), out T))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        Vf = Ag * T;
                        H = ((Ag * T * T) / 2);
                        Answer = "\nObject fell from a height of " + H + " meters with a final velocity of " + Vf + " m/s before impact";

                        if (T <= 0)
                        {
                            Answer = "\nThe object has not been fall at all";
                        }
                    }
                    break;
                default:
                    Answer = "\nInvalid Input!";
                    break;

            }
            return Answer;
        }
        public static string ThirdSelection()
        {
            string Answer = "";

            Console.WriteLine("\nWhat Are The Given Quantities??\t");
            Console.WriteLine("\n(1)Velocity Only\n(2)Height Only\n(3)Total Time of Flight Only");
            Console.Write("\nYour Choice:\t");
            string Selection = Console.ReadLine()!;
            double V, H, T, t;

            switch (Selection)
            {
                case "1":
                    Console.Write("\nInput Initial Velocity:\t");
                    if (!double.TryParse(Console.ReadLine(), out V))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        T = 2 * (V / Ag);
                        t = T / 2;
                        H = ((Ag * t * t) / 2);
                        Answer = "\nTime of Flight: " + T + " seconds\nMax. Height : " + H + " meters";
                        if (V <= 0)
                        {
                            Answer = "\nThe object has not been Thrown at all";
                        }
                    }
                    break;
                case "2":
                    Console.Write("\nInput Height:\t");
                    if (!double.TryParse(Console.ReadLine(), out H))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        V = Math.Sqrt(2 * Ag * H);
                        T = 2 * (V / Ag);
                        Answer = "\nTime of Flight: " + T + " seconds\nVelocity : " + V + " m/s";
                        if (H <= 0)
                        {
                            Answer = "\nThe object has not been Thrown at all";
                        }
                    }

                    break;
                case "3":
                    Console.Write("\nInput Total Time of Flight:\t");
                    if (!double.TryParse(Console.ReadLine(), out T))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        t = T / 2;
                        V = Ag * t;
                        H = ((Ag * t * t) / 2);

                        Answer = "\nMax. Height: " + H + " meters\nVelocity : " + V + " m/s";
                        if (T <= 0)
                        {
                            Answer = "\nThe object has not been fall at all";
                        }
                    }
                    break;
                default:
                    Answer = "\nInvalid Input!";
                    break;

            }
            return Answer;
        }

        
    }
}
