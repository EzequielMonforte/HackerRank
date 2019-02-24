//https://www.hackerrank.com/challenges/diagonal-difference/problem

namespace HackerRank.ProblemSolving.Algorithms{
public class DiagonalDifference{

    public static int Difference(int[][] arr){
        int diagA=0;
        int diagB=0;
        int o=0;
        for(int i=0; i< arr.Length; i++){
            diagA+= arr[i][i];
        }
        for(int i=arr.Length-1; i>= 0; i--){
            diagB+= arr[i][o];
            o++;
        }

        return System.Math.Abs(diagA- diagB);
    }
}
}