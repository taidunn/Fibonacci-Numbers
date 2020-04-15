using System;

namespace ConsoleApp12
{
   class Program
   {
      static void Main(string[] args)
      {

         int n = 0;

         Console.Write("Please give me an index n of a Fibonacci word and number: ");
         n = int.Parse(Console.ReadLine());

         // do not change anyhting above this line
         // write your code below and replace value "unknown" with the correct answer

         int n1 = 0;
         int n2 = 1;
         int n3 = 0;
         int i;
         int currentLen = 0;

         for (i = 2; i < n; ++i)
         {
            //n3 will be set to be equal to n1 and n2.
            n3 = n1 + n2;
            //n1 will be equal to n2.
            n1 = n2;
            //n2 will be equal to n3.
            n2 = n3;
         }
         Console.WriteLine($"Fibonacci number f({n})= {n3}\n");


         string base1 = "1";
         string base2 = "2";
         string fibWord = "";

         string temporary;
         //'i' will start at 2 and will go until it is no longer less than 'n'.
         //'i' will iterate by 1 every time.
         for (i = 2; i < n; i++)
         {
            //The string 'temporary' is set equal to 'base2'.
            temporary = base2;
            //'base2' is basically set to "base2 = base2 + base1".
            base2 += base1;
            //'base1' is set equal to the value of temporary.
            base1 = temporary;
         }

         int length = base2.Length;

         //i starts at 0 and will keep running until it equals the length.
         for (i = 0; i != length; i++)
         {
            char check = base2[currentLen];

            //If it equaled '1' it would execute the statement below.
            //It is checking if the specific character is '1'.
            if (check.Equals('1'))
            {
               //It would add 'a' to the fibWord string.
               fibWord = (fibWord + "a");
               currentLen++;
            }
            //If it equaled '2' it would execute the statement below.
            //It is checking if the specific character is '2'.
            if (check.Equals('2'))
            {
               //It would add 'b' to the fibWord string.
               fibWord = (fibWord + "b");
               currentLen++;
            }
         }

         Console.WriteLine($"Fibonacci word fw({n})= {fibWord}\n");


        //This gets the length of the fibonacci word.
        int fibWordint = fibWord.Length;

         Console.WriteLine($"The length of the fibonacci word fw({n})= {fibWordint}\n");

         //The amount of b's equals the fibonacci number.
         int bCount = n3;

         //The amount of a's equals the fibonnacci words length minus the bCount.
         int aCount = fibWordint - n3;



         Console.WriteLine($"The number of \"b\"s in fw({n})= {bCount}");

         Console.WriteLine($"The number of \"a\"s in fw({n})= {aCount}");
      }
   }
}
