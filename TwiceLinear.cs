using System;
using System.Collections.Generic;

public class DoubleLinear 
{
    public static int DblLinear (int n) 
    {
        List<int> list = new List<int>();
        int i = 1;
        list.Add(i);
        while(i/2 < n){
          if(list.Contains(i) == true){
            if( !list.Contains(Y(i)) ) list.Add(Y(i));
            list.Add(Z(i));
          }
          i++;        
        }
        list.Sort();
        return list[n];
    }
 
    private static int Y(int x) {
        return (2 * x + 1);
    }

    private static int Z(int x) {
        return (3 * x + 1);
    }
}
