using System.Collections.Generic;
using System.Linq;

public class DoubleLinear 
{
    
    public static int DblLinear (int n) 
    {
        List<int> list = new List<int>();
        list.Add(1);
        
        for(int x = 0; x < n*5; x++){
            list.Add( mathX(list[x]) );
            list.Add( mathY(list[x]) );
        }
        
        list = list.Distinct().ToList();
        list.Sort();
        
    return list[n];
    }

    private static int mathX(int x){
        return x*2+1;
    }
    
    private static int mathY(int x){
        return x*3+1;
    }
}
