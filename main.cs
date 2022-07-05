using System;
using System.Linq;

//Question 2
class MainClass {
public static void Main (string[] args){
    int[,] array_2d = {{1,2,3},{4,5,6},{7,8,9,}};
    PrintOddNumbers(array_2d);  
    ElementSum(array_2d);
    DoubleArray(array_2d);
  }

  public static void PrintOddNumbers(int[,] array_2d){
    Console.WriteLine($"Print all odd numbers: ");
   foreach(int val in array_2d){
     if(val%2!=0){
       Console.Write(val + " ");

     }
   }
    Console.WriteLine();
  }


  public static void ElementSum(int[,] array_2d){
   int total = 0;
   foreach(int val in array_2d){
      total = total + val;

   }
    Console.WriteLine($"The sum of all array elements: {total}");
  }



 public static void DoubleArray(int[,] array_2d){
   Console.WriteLine($"The new 2D array: ");
   foreach(int val in array_2d){
     Console.Write(val*2 + " ");
    }
    
  }
}

