﻿namespace _4.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                NumbersOfCol(row);
            }
            for (int row = n-1; row >= 0; row--)
            {
                NumbersOfCol(row);
            }
        }

        private static void NumbersOfCol(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}