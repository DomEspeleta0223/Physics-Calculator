using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Calculator
{
    internal static class _2D_Kinematics
    {
        public const double Ag = 9.81;
        public static void Two_D()
        {
            Console.WriteLine("\nWelcome to 2D Kinematics!\nWhat You Are Trying To Solve? ");
            Console.WriteLine("\n(1)Projectile Launched at an Angle\n(2)Circular Motion");
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
            Console.WriteLine("\n(1)Initial Velocity, and Angle Only\n(2)Initial Velocity, Angle, and Initial Height");
            Console.Write("\nYour Choice:\t");
            string Selection = Console.ReadLine()!;
            double Vi, H, T, Vf, X, O, Vx, Vfy, Vy, Hi;

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
                        Console.Write("\nInput Angle:\t");
                        if (!double.TryParse(Console.ReadLine(), out O))
                        {
                            Answer = "Invalid Input!";
                        }
                        else
                        {

                            O = (O * Math.PI) / 180;

                            T = (2 * Vi * Math.Sin(O)) / Ag;
                            Vy = Vi * Math.Sin(O);
                            Vx = Vi * Math.Cos(O);
                            X = Vx * T;
                            H = ((Vi * Vi) * (Math.Sin(O) * Math.Sin(O))) / (2 * Ag);
                            Vfy = Vy + ((-Ag) * T);
                            Vf = Math.Sqrt((Vx * Vx) + (Vfy * Vfy));

                            Answer = "Max Height : " + H + " meters\nVelocity before impact: " + Vf + " m/s\nTime of Flight : " + T + " seconds\nHorizontal Distance :" + X + " meters";

                            if (O > 90 || O < 0)
                            {
                                Answer = "Angle cannot be less than 0 or more than 90 degrees";
                            }
                            else if (Vi < 0)
                            {
                                Answer = "Velocity Must Not Be Negative";
                            }
                        }

                    }

                    break;
                case "2":
                    Console.Write("\nInput Initial Velocity:\t");
                    if (!double.TryParse(Console.ReadLine(), out Vi))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        Console.Write("\nInput Angle:\t");
                        if (!double.TryParse(Console.ReadLine(), out O))
                        {
                            Answer = "Invalid Input!";
                        }
                        else
                        {
                            Console.Write("\nInput Initial Height:\t");
                            if (!double.TryParse(Console.ReadLine(), out Hi))
                            {
                                Answer = "Invalid Input!";
                            }
                            else
                            {
                                O = (O * Math.PI) / 180;

                                Vy = Vi * Math.Sin(O);
                                Vx = Vi * Math.Cos(O);

                                H = (((Vi * Vi) * (Math.Sin(O) * Math.Sin(O))) / (2 * Ag)) + Hi;
                                T = ((Vi * Math.Sin(O)) / Ag) + (Math.Sqrt((2 * H) / Ag));
                                X = Vx * T;
                                Vfy = Vy + ((-Ag) * T);
                                Vf = Math.Sqrt((Vx * Vx) + (Vfy * Vfy));

                                Answer = "Max Height : " + H + " meters\nVelocity before impact: " + Vf + " m/s\nTime of Flight : " + T + " seconds\nHorizontal Distance :" + X + " meters";

                                if (O > 90 || O < 0)
                                {
                                    Answer = "Angle cannot be less than 0 or more than 90 degrees";
                                }
                                else if (Vi < 0)
                                {
                                    Answer = "Velocity Must Not Be Negative";
                                }

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
        
        public static string SecondSelection()
        {
            string Answer = "";

            Console.WriteLine("\nWhat Are You Trying To Solve??\t");
            Console.WriteLine("\n(1)Solving For Quantities\n(2)Revolution");
            Console.Write("\nYour Choice:\t");
            string Selection = Console.ReadLine()!;
            double D, C, Cc, T, V, M, Av, Fc, Ac, r;


            switch (Selection)
            {
                case "1":
                    Console.WriteLine("\nWhat Are The Given Quantities??\t");
                    Console.WriteLine("\n(1)Length of an Arc, Time, Radius, and Mass\n(2)Linear Velocity, Radius, and Mass");
                    Console.Write("\nYour Choice:\t");
                    string Select = Console.ReadLine()!;

                    switch (Select)
                    {

                        case "1":
                            Console.Write("\nInput 1ength of an Arc:\t");
                            if (!double.TryParse(Console.ReadLine(), out C))
                            {
                                Answer = "Invalid Input!";
                            }
                            else
                            {
                                Console.Write("\nInput Radius:\t");
                                if (!double.TryParse(Console.ReadLine(), out r))
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
                                        Console.Write("\nInput Mass:\t");
                                        if (!double.TryParse(Console.ReadLine(), out M))
                                        {
                                            Answer = "Invalid Input!";
                                        }
                                        else
                                        {
                                            Av = C / (r * T);
                                            Fc = M * Av * Av * r;
                                            Ac = Fc / M; ;

                                            Answer = "\nAngular Velocity: " + Av + " rad/s\nCentripetal Acceleration: " + Ac + " rad/s²\nCentripetal Force: " + Fc + " Newtons";
                                        }
                                    }
                                }
                            }
                            break;
                        case "2":
                            Console.Write("\nInput Linear Velocity:\t");
                            if (!double.TryParse(Console.ReadLine(), out V))
                            {
                                Answer = "Invalid Input!";
                            }
                            else
                            {
                                Console.Write("\nInput Radius:\t");
                                if (!double.TryParse(Console.ReadLine(), out r))
                                {
                                     Answer = "Invalid Input!";
                                }
                                else
                                {
                                     Console.Write("\nInput Mass:\t");
                                     if (!double.TryParse(Console.ReadLine(), out M))
                                     {
                                        Answer = "Invalid Input!";
                                     }
                                     else
                                     {
                                        Av = V / r;
                                        Fc = M * Av * Av * r;
                                        Ac = Fc / M;

                                        Answer = "\nAngular Velocity: " + Av + " rad/s\nCentripetal Acceleration: " + Ac + " rad/s²\nCentripetal Force: " + Fc + " Newtons";
                                     }
                                }
                            }

                            break;
                        default:
                            Answer = "Invalid Input!";
                            break;

                    }
                    break;

                case "2":
                    Console.Write("\nInput Acceleration:\t");
                    if (!double.TryParse(Console.ReadLine(), out Ac))
                    {
                        Answer = "Invalid Input!";
                    }
                    else
                    {
                        Console.Write("\nInput Circumference:\t");
                        if (!double.TryParse(Console.ReadLine(), out C))
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
                                D = (Ac * (T * T)) / 2;
                                Cc = D / C;

                                Answer = "You Can Have " + Cc + " Cycles with the given input";

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
