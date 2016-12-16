public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if(input == null || input.Length == 0) return new int[]{};
        
          int pos = 0;
          int neg = 0;
        
        for(int x = 0; x< input.Length; x++){

          if(input[x] != 0){
              if(input[x] > 0) pos++;
              else neg += input[x];
          }
        }
        
    return new int[] {pos, neg};
    }
}
