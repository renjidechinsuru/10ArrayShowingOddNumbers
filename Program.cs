using System;

namespace _10ArrayShowingOddNumbers
{
    class Program
    {
        static void Main(string[] args) // Declare and initialize array of 10 integers. Then print only the odd number elements
        {
            
            //declaring array of integers
            int[] balance = new int[10];
            //reading the elements
                int[] marks = new int[10] { 94, 283, 850, 274, 3764, 98, 34, 25, 3, 20 };
            
           

            for (int i = 0; i < 10; i++)
                
//print only the odd number
            if (marks[i] % 2 == 1)
               

                Console.WriteLine(marks[i] + "is odd number");
                
           
         





        }
    }
}
