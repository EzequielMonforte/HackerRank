
public Class StairCase{

   public static void stairCase(int n){
    for(int o=0; o<n; o++){
        for (int i = 1; i <= n; i++) {
            if(i >= n-o){
                System.out.print('#');
            }else{System.out.print(' ');}
        }
        System.out.print("\r\n");
    } 
}     
}