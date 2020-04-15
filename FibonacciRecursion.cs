using System;

namespace ConsoleApp12
{
   class Program
   {
      public static int Fib(int FibNum)
      {
         //if ( (n1 == 1) || (number == 2) )
         if (FibNum == 0)
         {
            return 0;
         }
         else if (FibNum <= 2)
         {
            return 1;
         }
         else
         {
            return Fib(FibNum - 1) + Fib(FibNum - 2);
         }
      }
      public static string FibWord(int FibNum)
      {
         //if ( (n1 == 1) || (number == 2) )
         if (FibNum == 0)
         {
            return "";
         }
         else if (FibNum == 1)
         {
            return "a";
         }
         else if (FibNum == 2)
         {
            return "b";
         }
         else
         {
            return FibWord(FibNum - 1) + FibWord(FibNum - 2);
         }
      }

      static void Main(string[] args)
      {

         int n = 0;

         Console.Write("Please give me an index n of a Fibonacci word and number: ");
         n = int.Parse(Console.ReadLine());

         // do not change anyhting above this line
         // write your code below and replace value "unknown" with the correct answer

         Console.WriteLine($"Fibonacci number f({n})= {Fib(n)} \n");


         Console.WriteLine($"Fibonacci word fw({n})= {FibWord(n)} \n");


         //This gets the length of the fibonacci word.

         Console.WriteLine($"The length of the fibonacci word fw({n})= {Fib(n)} \n");

         //The amount of b's equals the fibonacci number.
         int bCount = Fib(n - 1);

         //The amount of a's equals the fibonnacci words length minus the bCount.
         int aCount = Fib(n - 2);



         Console.WriteLine($"The number of \"b\"s in fw({n})= {bCount}");

         Console.WriteLine($"The number of \"a\"s in fw({n})= {aCount}");
      }
   }
}
