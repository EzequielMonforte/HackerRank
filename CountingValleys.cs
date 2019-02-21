//https://www.hackerrank.com/challenges/counting-valleys/problem
public class CountingValleys
{
    public static int Count(int n, string p){
        char[] steps= p.ToCharArray();
        int valleys= 0;
        int height= 0;
        bool isDown=false;
        foreach (char step in steps)
        {
            if (step== 'U'){
                height++;
                if(height>=0){
                    isDown=false;
                }
                
            }
            if (step== 'D'){
                height--;
                if(height <=-1 && !isDown){
                    valleys++;
                    isDown=true;
                }
                
                
            }
        }
        return valleys;
    }
}