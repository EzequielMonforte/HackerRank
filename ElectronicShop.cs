//https://www.hackerrank.com/challenges/electronics-shop/problem
//test

public class ElectronicShop{

    public static int getMoneySpent(int[] kb, int[] dr, int mn){
        int sum=0;
        int maxtemp=-1;
        for(int i=0; i< kb.Length; i++){
            for(int o=0; o< dr.Length; o++){
                sum=kb[i]+ dr[o];
                if(sum > maxtemp && sum <= mn){
                    maxtemp =sum;
                }
            }
        }
        return maxtemp;
    }
}