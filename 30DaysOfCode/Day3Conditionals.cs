//https://www.hackerrank.com/challenges/30-conditional-statements/problem

namespace HackerRank.DaysOfCode{

    public class ConditionalStatements{

        public static string WeirdOrNot(int a){
            if(a % 2 != 0){
                return "Weird";
            }
            if(a >= 2 && a <=5){
                return "Not Weird";
            }
            if(a >=6 && a<=20){
                return "Weird";
            }
            if(a > 20){
                return "Not Weird";
            }
            return null;
        }
    }
}