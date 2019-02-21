//https://www.hackerrank.com/challenges/sock-merchant/problem
static public class SockMerchant{
    public static int socks(int n, int[] ar) {
        int pairs= 0;

        for(int i=0; i< ar.Length; i++){
            if(ar[i] != 0){
                for(int o= i+1; o < ar.Length; o++){
                    if(ar[i]== ar[o] && ar[o]!= 0){
                        pairs++;
                        ar[i]=0;
                        ar[o]=0;
                    }
                }
            }
        }
        return pairs;
    }
}