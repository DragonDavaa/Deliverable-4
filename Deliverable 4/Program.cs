
//Author: Weimar Ardila
//Date: 2/2/2023
//Description: Fibonacci
using System;
namespace Deliverable_4
{
    class Program
    {
        static void Main(string[] args)
        {            
           int[] fibonacci = new int[25];
           // Initialize fibonacci series
           fibonacci[0] = 0;
           fibonacci[1] = 1;
           for (int i = 0; i < fibonacci.Length; i++)
           {
              if (i >= 2)
              {
                   fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
              }
           }
           // Printing the results in the console
           for (int i = 0; i < fibonacci.Length; i++)
           {
               Console.WriteLine("Fibonacci( " + i + ") = " + fibonacci[i]);
           }  
        }
    }
}
