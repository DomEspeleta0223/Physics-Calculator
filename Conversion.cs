using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Calculator
{
    internal static class Conversion
    {
        public static void ConversionMain()
        {
            Console.WriteLine("Select Physical Quantity:\n(1)Mass\n(2)Time\n(3)Distance\n(4)Speed\n(5)Angle");
            string Selection = Console.ReadLine()!;

            switch (Selection)
            {
                case "1":
                    Console.WriteLine("\n"+Mass());
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.WriteLine("\n"+Time());
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    Console.WriteLine("\n"+Distance());
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "4":
                    Console.WriteLine("\n" + Speed());
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    Console.WriteLine("\n" + Angle());
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
        public static string Mass()
        {
            string Answer = "";
            Console.WriteLine("Please Select Unit:\n(1)Kilograms\n(2)Slugs\n(3)Pounds\n(4)Tons");
            string Selection = Console.ReadLine()!;
            double Kgs, Slgs, Lbs, Tonnes;

            if (Selection == "1")
            {
                Console.Write("Enter Kgs: ");

                if (!double.TryParse(Console.ReadLine(), out Kgs))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    Slgs = Kgs / 14.5939;
                    Lbs = Kgs / 0.45;
                    Tonnes = Kgs / 1000;

                    Answer = Slgs + " Slgs\n" + Lbs + " Lbs\n" + Tonnes + " Tonnes";
                }

            }
            else if (Selection == "2")
            {
                Console.Write("Enter Slgs: ");

                if (!double.TryParse(Console.ReadLine(), out Slgs))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    Kgs = Slgs * 14.5939;
                    Lbs = Slgs * 32.17;
                    Tonnes = Slgs / 68.5218;

                    Answer = Kgs + " Kgs\n" + Lbs + " Lbs\n" + Tonnes + " Tonnes";
                }
            }
            else if (Selection == "3")
            {
                Console.Write("Enter Lbs: ");

                if (!double.TryParse(Console.ReadLine(), out Lbs))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    Kgs = Lbs * 0.45;
                    Slgs = Lbs / 32.17;
                    Tonnes = Lbs / 2204.62;

                    Answer = Kgs + " Kgs\n" + Slgs + " Slgs\n" + Tonnes + " Tonnes";
                }
            }
            else if (Selection == "4")
            {
                Console.Write("Enter Tonnes: ");

                if (!double.TryParse(Console.ReadLine(), out Tonnes))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    Kgs = Tonnes * 1000;
                    Slgs = Tonnes * 68.5218;
                    Lbs = Tonnes * 2204.62;

                    Answer = Kgs + " Kgs\n" + Slgs + " Slgs\n" + Lbs + " Lbs";
                }
            }
            else
            {
                Answer = "Invalid Input!";
            }

            return Answer;
        }

        public static string Time()
        {
            string Answer = "";
            Console.WriteLine("Please Select Unit:\n(1)Seconds\n(2)Minutes\n(3)Hours\n(4)Days\n(5)Weeks\n(6)Years");
            string Selection = Console.ReadLine()!;
            double S,M,H,D,W,Y;

            if (Selection == "1")
            {
                Console.Write("Enter Seconds: ");

                if (!double.TryParse(Console.ReadLine(), out S))
                {
                    Answer = "Invalid Input!";
                }
                else
                {
                    M = S / 60;
                    H = M / 60;
                    D = H / 24;
                    W = D / 7;
                    Y = D / 365;
                    Answer = M + " Mins\n" + H + " Hrs\n" + D + " Days\n" + W + " Wks\n" + Y + " Yrs";
                }

            }
            else if (Selection == "2")
            {
                Console.Write("Enter Minutes: ");

                if (!double.TryParse(Console.ReadLine(), out M))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    S = M * 60;
                    H = M / 60;
                    D = H / 24;
                    W = D / 7;
                    Y = D / 365;
                    Answer = S + " Secs\n" + H + " Hrs\n" + D + " Days\n" + W + " Wks\n" + Y + " Yrs";

                }
            }
            else if (Selection == "3")
            {
                Console.Write("Enter Hours: ");
                string Hs = Console.ReadLine()!;

                if (!double.TryParse(Console.ReadLine(), out H))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    M = H * 60;
                    S = M * 60;
                    D = H / 24;
                    W = D / 7;
                    Y = D / 365;
                    Answer = S + " Secs\n" + M + " Mins\n" + D + " Days\n" + W + " Wks\n" + Y + " Yrs";
                }
            }
            else if (Selection == "4")
            {
                Console.Write("Enter Days: ");

                if (!double.TryParse(Console.ReadLine(), out D))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    H = D * 24;
                    M = H * 60;
                    S = M * 60; ;
                    W = D / 7;
                    Y = D / 365;
                    Answer = S + " Secs\n" + M + " Mins\n" + H + " Hrs\n" + W + " Wks\n" + Y + " Yrs";

                }
            }
            else if (Selection == "5")
            {
                Console.Write("Enter Weeks: ");

                if (!double.TryParse(Console.ReadLine(), out W))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    D = W * 7;
                    H = D * 24;
                    M = H * 60;
                    S = M * 60; ;
                    Y = D / 365;
                    Answer = S + " Secs\n" + M + " Mins\n" + H + " Hrs\n" + D + " Days\n" + Y + " Yrs";

                }
            }
            else if (Selection == "6")
            {
                Console.Write("Enter Years: ");;

                if (!double.TryParse(Console.ReadLine(), out Y))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    D = Y * 365;
                    W = D / 7;
                    H = D * 24;
                    M = H * 60;
                    S = M * 60; ;

                    Answer = S + " Secs\n" + M + " Mins\n" + H + " Hrs\n" + D + " Days\n" + W + " Weeks";

                }
            }
            else
            {
                Answer = "Invalid Input!";
            }

            return Answer;
        }

        public static string Distance()
        {
            string Answer = "";
            Console.WriteLine("Please Select Unit:\n(1)Meters\n(2)Feet\n(3)Inches\n(4)Miles");
            string Selection = Console.ReadLine()!;
            double  M, F, I, Mi;

            if (Selection == "1")
            {
                Console.Write("Enter Meters: ");

                if (!double.TryParse(Console.ReadLine(), out M))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    F = M * 3.28;
                    I = M * 39.375;
                    Mi = M / 1609;

                    Answer = F + " Ft\n" + I + " Inches\n" + Mi + " Miles";

                }
            }
            else if (Selection == "2")
            {
                Console.Write("Enter Feet: ");

                if (!double.TryParse(Console.ReadLine(), out F))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    M = F / 3.28;
                    I = M * 39.375;
                    Mi = M / 1609;

                    Answer = M + " Meters\n" + I + " Inches\n" + Mi + " Miles";
                }

            }
            else if (Selection == "3")
            {
                Console.Write("Enter Inches: ");

                if (!double.TryParse(Console.ReadLine(), out I))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    F = I / 12;
                    M = F / 3.28;
                    Mi = M / 1609;

                    Answer = M + " Meters\n" + F + " Feet\n" + Mi + " Miles";
                }

            }
            else if (Selection == "4")
            {
                Console.Write("Enter Miles: ");

                if (!double.TryParse(Console.ReadLine(), out Mi))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    M = Mi * 1609;
                    F = M * 3.28;
                    I = F * 12;

                    Answer = M + " Meters\n" + F + " Feet\n" + I + " Inches";

                }
            }
            else
            {
                Answer = "Invalid Input!";
            }

            return Answer;
        }
        public static string Speed()
        {
            string Answer = "";
            Console.WriteLine("Please Select Unit:\n(1)m/s\n(2)km/h\n(3)mi/h\n(4)ft/s");
            string Selection = Console.ReadLine()!;
            double MpS, KmpH, MipH, FpS;

            if (Selection == "1")
            {
                Console.Write("Enter m/s: ");

                if (!double.TryParse(Console.ReadLine(), out MpS))
                {
                    Answer = "Invalid Input!";
                }
                else
                { 
                    KmpH = MpS * 3.6;
                    MipH = MpS * 2.2369;
                    FpS = MpS * 3.28; 
                    Answer = KmpH + " Km/h\n" + MipH + " mi/h\n" + FpS + " ft/s";
                }

            }
            else if (Selection == "2")
            {
                Console.Write("Enter km/h: ");
                if (!double.TryParse(Console.ReadLine(), out KmpH))
                {
                    Answer = "Invalid Input!";
                }
                else
                {
                    MpS = KmpH / 3.6;
                    MipH = MpS * 2.2369;
                    FpS = MpS * 3.28;

                    Answer = MpS + " m/s\n" + MipH + " mi/h\n" + FpS + " ft/s";
                }

            }
            else if (Selection == "3")
            {
                Console.Write("Enter Mi/h: ");
                if (!double.TryParse(Console.ReadLine(), out MipH))
                {
                    Answer = "Invalid Input!";
                }
                else
                {
                    MpS = MipH / 2.2369;
                    KmpH = MpS * 3.6;
                    FpS = MpS * 3.28;

                    Answer = MpS + " m/s\n" + KmpH + " km/h\n" + FpS + " ft/s";

                }
            }
            else if (Selection == "4")
            {
                Console.Write("Enter ft/s: ");
                if (!double.TryParse(Console.ReadLine(), out FpS))
                {
                    Answer = "Invalid Input!";
                }
                else
                {
                    MpS = FpS / 3.28;
                    MipH = MpS * 2.2369;
                    KmpH = MpS * 3.6;

                    Answer = MpS + " m/s\n" + KmpH + " km/h\n" + MipH + " mi/h";
                }

            }
            else
            {
                Answer = "Invalid Input!";
            }

            return Answer;
        }
        public static string Angle()
        {
            string Answer = "";
            Console.WriteLine("Please Select Unit:\n(1)Degrees\n(2)Radians");
            string Selection = Console.ReadLine()!;
            double O;
            if (Selection == "1")
            {
                Console.Write("Enter Angle in Degrees: ");

                if (!double.TryParse(Console.ReadLine(), out O))
                {
                    Answer = "Invalid Input!";
                }
                else
                {

                    O = (O * Math.PI) / 180;
                    Answer = O + " rad";
                }
            }
            else if (Selection == "2")
            {
                Console.Write("Enter Angle in Radians: ");

                if (!double.TryParse(Console.ReadLine(), out O))
                {
                    Answer = "Invalid Input!";
                }
                else
                {
                    O = (O * 180) / Math.PI;
                    Answer = O + " degrees";
                }
            }
            else
            {
                Answer = "Invalid Input!";
            }


            return Answer;
        }
    }
}
