using System;


namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c={3,1};
            int[] b={5,2,8};
            var a=ElectronicShop.getMoneySpent(c, b ,10);
            Console.WriteLine(a);
        }
    }
}
