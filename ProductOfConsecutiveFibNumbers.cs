public class ProdFib {
      public static ulong[] productFib(ulong prod)
      {
        ulong f1 = 0, f2 = 0, answer = 0;
        
        for(ulong x = 0; x <= prod; x++) {
          f1 = fib(x);
          f2 = fib(x+1);
          if( f1 * f2 >= prod){
            if(prod == f1 * f2) answer = 1;
            break;
          }
        }
        return new ulong[] { f1, f2, answer };
      }
      
      private static ulong fib(ulong n){
        ulong a = 0;
        ulong b = 1;
        ulong temp = 0;
        
        for(ulong x = 0; x < n; x++){
          temp = a;
          a = b;
          b = temp + b;
        }
        return a;
      }
}
