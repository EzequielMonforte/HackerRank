//https://www.hackerrank.com/challenges/30-operators/problem

namespace HackerRank.DaysOfCode
{
    public class Day2Operators
    {
    public static void solve(double meal_cost, int tip_percent, int tax_percent) {
            double Mtip= meal_cost*tip_percent/100;
            double Mtax= meal_cost*tax_percent/100;
            System.Console.WriteLine(System.Math.Round(meal_cost+ Mtip+ Mtax));

    }

    }
}