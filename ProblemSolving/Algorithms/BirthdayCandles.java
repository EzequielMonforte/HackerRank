//https://www.hackerrank.com/challenges/birthday-cake-candles/problem

public class BirthdayCandles {
    public static void main(String[] args) {
        
       System.out.println(Solution(new int[]{1,2,1,2}));  
        
    }
    public static int Solution(int[] ar){
        int count= 0;
        int max=0;
        for (int num : ar) {
            if(num>= max){
                if(num== max){
                    count++;
                }
                if(num> max){
                    max= num;
                    count=1;
                }
                
            }
        }
        return count;
    }     
   
}