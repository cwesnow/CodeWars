public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
      int left = 0;
      int right = 0;
      for( int i = 1; i < arr.Length; i++){
        right += arr[i];
      }
      
      for(int x = 1; x< arr.Length; x++){
        left += arr[x-1];
        right -= arr[x];
        if(left == right) return x;
      }
      return -1;
  }
}
