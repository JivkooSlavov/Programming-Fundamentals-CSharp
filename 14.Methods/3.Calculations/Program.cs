﻿using System.ComponentModel;
using System.Threading.Channels;

namespace _3.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string function = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            switch (function)
            {
                case "add":
                    Add(number1, number2);
                    break;
                case "multiply":
                    Multiply(number1, number2);
                    break;
                case "subtract":
                    Subtract(number1, number2);
                    break;
                case "divide":
                    Divide(number1, number2);
                    break;
                default:
                    break;
            }
            static  void Add(int number1, int number2) 
            {
                Console.WriteLine(number1+number2);
            }
            static void Multiply(int number1, int number2)
            {
                Console.WriteLine(number1*number2);
            }
            static void Subtract(int number1, int number2)
            {
                Console.WriteLine(number1 - number2);
            }
            static void Divide(int number1, int number2)
            {
                Console.WriteLine(number1/number2);
            }

        }
    }
}