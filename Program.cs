using System;
using HackerRank.DaysOfCode;
using HackerRank.ProblemSolving.Algorithms;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[][] 
                {
                new int[] {-10, 3, 0, 5, -4},
                new int[] {2, -1, 0, 2, -8},
                new int[] {9, -2, -5, 6, 0},
                new int[] {9, -7, 4, 8, -2},
                new int[] {3, 7, 8, -5, 0}                
                };
            int b=  DiagonalDifference.Difference(a);
            Console.WriteLine(b);

        }
    }
}
