using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Physics_Calculator
{
    internal static class HorizontalMotion
    {
        public static void HM_Main()
        {
            Console.WriteLine("\nWelcome to Horizontal Motion!\nWhat You Are Trying To Solve?");
            Console.WriteLine("\n(1)An Object in Motion Going to a Stop\n(2)Two Objects in Motion (One Object is Chasing the Other)\n(3)Solving Quantities");
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
            Console.WriteLine("NOTE THAT ACCELERATION MUST BE A NOT BE ZERO NOR IN THE SAME DIRECTION WITH VELOCITY");
            Console.Write("\nInput Velocity:\t");
            double Vi, A;
            string Answer = "";
            if (!double.TryParse(Console.ReadLine(), out Vi))
            {
                Answer = "Invalid Input!";
            }
            else
            {
                Console.Write("\nInput Acceleration:\t");
                if (!double.TryParse(Console.ReadLine(), out A))
                {
                    Answer = "Invalid Input!";
                }
                else
                {
                    double t = Math.Abs(Vi / A);
                    double x = ((A * t * t) / 2) + (Vi * t);

                    Answer = "\nIt takes " + t + "seconds to stop and it will reach " + x + "meters";

                    if ((A == 0 && Vi != 0) || (Vi == 0 && A != 0))
                    {
                        Answer = "\nObject Must Be Decelerating";
                    }
                    else if ((A > 0 && Vi > 0) || (A < 0 && Vi < 0))
                    {
                        Answer = "\nAcceleration and Velocity Must Not Be In The Same Direction";
                    }
                    else if (Vi == 0 && A == 0)
                    {
                        Answer = "\nObject is Not Moving at All";
                    }
                }

            }


            return Answer;
        }

        public static string SecondSelection()
        {
            string Answer = "";

            double Vi1, Vi2, A1, A2;
            Console.Write("\nInput Chasing Object's Velocity:\t");
            if (!double.TryParse(Console.ReadLine(), out Vi1))
            {
                Answer = "Invalid Input!";
            }
            else
            {
                Console.Write("\nInput Chasing Object's Acceleration:\t");
                if (!double.TryParse(Console.ReadLine(), out A1))
                {
                    Answer = "Invalid Input!";
                }
                else
                {
                    Console.Write("\nInput Speeding Object's Velocity:\t");
                    if (!double.TryParse(Console.ReadLine(), out Vi2))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        Console.Write("\nInput Speeding Object's Acceleration:\t");
                        if (!double.TryParse(Console.ReadLine(), out A2))
                        {
                            Answer = "Invalid Input!";
                        }
                        else
                        {
                            double T = Math.Abs((Vi2 - Vi1) / ((A2 - A1) / 2));
                            double x = ((A1 * T * T) / 2) + (Vi1 * T);

                            Answer = "\nIt will take " + T + " seconds for the chasing car to reach speeding car with a distance covering " + x + " meters";

                            if (((A2 > A1) && (Vi1 == Vi2)) || (A1 == 0) || ((A1 < A2) && (Vi1 < Vi2)) || ((A1 < A2) && (Vi1 == Vi2)) || ((A1 == A2) && (Vi1 < Vi2)))
                            {
                                Answer = "\nChasing car will never reach speeding car";
                            }
                            else if (Vi1 >= Vi2 && A1 >= A2)
                            {
                                Answer = "\nNothing to chase at all";
                            }
                        }
                    }
                }
            }

            return Answer;
        }
        public static string ThirdSelection()
        {
            string Answer = "";
            Console.WriteLine("\nWhat Are You Trying To Solve??\t");
            Console.WriteLine("\n(1)Final Velocity and Position of an object at a Given Time and Acceleration\n(2)Time it takes for an object to reach a certain distance given acceleration");
            Console.Write("\nYour Choice:\t");
            string Selection = Console.ReadLine()!;
            double A, V, X, T;
            switch (Selection)
            {
                case "1":
                    Console.Write("\nInput Acceleration:\t");
                    if (!double.TryParse(Console.ReadLine(), out A))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        Console.Write("\nInput Time:\t");
                        if (!double.TryParse(Console.ReadLine(), out T))
                        {
                            Answer = "Invalid Input!";
                        }
                        else
                        {
                            V = A * T;
                            X = ((A * T * T) / 2) + (V * T);
                            Answer = "\nThe object will reach " + X + " meters with final velocity of " + V + " m/s";
                            if (T == 0)
                            {
                                Answer = "No Point Where The Object Will Stop";
                            }
                            else if (T < 0)
                            {
                                Answer = "Time Cannot Go Backwards";
                            }
                            else if (A == 0)
                            {
                                Answer = "Object Won't Move";
                            }
                        }
                    }
                    break;
                case "2":
                    Console.Write("\nInput Acceleration:\t");
                    if (!double.TryParse(Console.ReadLine(), out A))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        Console.Write("\nInput Distance:\t");
                        if (!double.TryParse(Console.ReadLine(), out X))
                        {
                            Answer = "Invalid Input!";
                        }
                        else
                        {
                            X = Convert.ToDouble(Console.ReadLine());

                            V = Math.Sqrt(2 * A * X);
                            T = V / A;
                            Answer = "\nThe object will take " + T + " seconds with final velocity of " + V + " m/s";
                            if (A == 0)
                            {
                                Answer = "Object Won't Move";
                            }
                        }
                    }
                    break;
                default:
                    Answer = "Invalid Input!";
                    break;

            }
            return Answer;
        }
        
    }
}
