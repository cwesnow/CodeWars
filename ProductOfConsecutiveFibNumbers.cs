public class ProdFib {
      public static ulong[] productFib(ulong prod)
      {
        ulong f1 = 0;
        ulong f2 = 0;
        
        for(ulong x = 0; x <= prod; x++) {
          f1 = fib(x);
          f2 = fib(x+1);
          
          if(prod == f1 * f2) return new ulong[] { f1, f2, 1 };
          if(prod < f1 * f2) return new ulong[] { f1, f2, 0 };
        }
        return new ulong[] { f1, f2, 0 };
      }
      
      private static ulong fib(ulong n){
        ulong a = 0;
        ulong b = 1;
        ulong temp = 0;
        
        for(ulong x = 0; x < n; x++){
          temp = a+b;
          a = b;
          b = temp;
        }
        if(n < 2) return n;
        else return a;
      }
}
