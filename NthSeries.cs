using System;

public class NthSeries {
	
	public static string seriesSum (int n)
  {   
      if( n == 0 ) return "0.00";

      double number = 1.00;
      
      for(int x = 1; x < n; x++){
      
          number += 1 / (1.0 + x*3);
      }

      return number.ToString("F2");
	}
}
