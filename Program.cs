using Physics_Calculator;
using System;

internal class Class1
{
    static void Main(string[] args)
    {

        for (; ; )
        {
            Console.WriteLine("Hello I am Dominic Welcome to Physics Calculator! \n(This Calculator is in SI Unit please use converter first if necessary)");
            Console.WriteLine("\nWelcome to Physics Calculator");

            List<string> calculators = new List<string>();

            calculators.Add("(1) Fundamental Converter");
            calculators.Add("(2) Horizontal Motion");
            calculators.Add("(3) Free Fall");
            calculators.Add("(4) Two Dimension Kinematics");
            calculators.Add("(5) Resistance Calculator");

            foreach (string choices in calculators)
            {
                Console.WriteLine(choices);
            }

            Console.Write("\nYour Choice:\t");

            string choice = Console.ReadLine()!;
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Conversion.ConversionMain();
                    break;
                case "2":
                    HorizontalMotion.HM_Main();
                    break;
                case "3":
                    FreeFall.FF_Main();
                    break;
                case "4": 
                    _2D_Kinematics.Two_D();
                    break;
                case "5":
                    Resistance.ResistanceMain();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    Console.ReadKey();
                    Console.Clear();
                    break;

            }
        }
    }
    
}
