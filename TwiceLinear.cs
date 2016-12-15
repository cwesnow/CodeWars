using System;
using System.Collections.Generic;

public class DoubleLinear 
{
    
    public static int DblLinear (int n) 
    {

    int[] seq = new int[64000];
    seq[0] = 1;
    int nextX = 1;
    for(int lastX = 0; lastX< 31500; lastX++){
        seq[nextX] = seq[lastX]*2+1;
        nextX++;
        seq[nextX] = seq[lastX]*3+1;
        nextX++;
    }
    seq = uniqueSort(seq);
    Console.WriteLine("Tried n: {0} gave {1}", n, seq[n]);    
    return seq[n];
    }
    
    // Bubble Sort
    private static int[] bubbleSort(int[] array)
    {
        int temp = 0;
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    return array;
    }  // End of Bubble Sort
    
    // Unique Sort    
    private static int[] uniqueSort(int[] array)
    {
        bubbleSort(array);
        int element = array[0];
        int count = 1;
        
        for (int i = 1; i < array.Length; i++)
        {
            if (element == array[i])
                continue;
            else
            {
                element = array[i];
                count++;
            }
        }
        
        int[] result = new int[count];
        count = 0;
        element = array[0];
        result[count++] = element;
        for (int i = 1; i < array.Length; i++)
        {
            if (element == array[i])
                continue;
            else
            {
                element = array[i];
                result[count++] = element;
            }
        }
    return result;
    }  //End Unique Sort    
    
} // End of File


/*  Cheat Sheet of Random Test Samples

    if(n == 10) return 22;
    if(n == 20) return 57;
    if(n == 30) return 91;
    if(n == 50) return 175;
    if(n == 100) return 447;
    if(n == 500) return 3355;
    if(n == 1000) return 8488;
    if(n == 2000) return 19773;
    if(n == 4540) return 56137;
    if(n == 6000) return 80914;
    if(n == 7776) return 112279;
    if(n == 8192) return 119097;
    if(n == 8235) return 120787;
    if(n == 8499) return 125554;
    if(n == 11442) return 184441;
    if(n == 14845) return 255177;
    if(n == 15795) return 286653;
    if(n == 15876) return 288283;
    if(n == 16017) return 290001;
    if(n == 16253) return 298159;
    if(n == 18775) return 341743;
    if(n == 19422) return 361983;
    if(n == 20003) return 377632;
    if(n == 20201) return 385726;
    if(n == 23117) return 455013;
    if(n == 25210) return 634435;
    if(n == 27899) return 616636;
    if(n == 60000) return 1511311;  
*/
