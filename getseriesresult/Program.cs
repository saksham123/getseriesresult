using System;

namespace getseriesresult
{
    class Program
    {
        public static double getSeriesResult()//method
        {
            int i, n, sum = 0, x = 1;
            Console.WriteLine("Enter a number :"); // get number from user
            n = Int32.Parse(Console.ReadLine()); // put the value in variable n
            Console.Write("for the following series:");
            Console.Write("");
            Console.Write("\n\n");

            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} + ", x); 
                sum = sum + x; //add the value in sum
                x = (x) + 1;//increment the value of x till n
            }
            Console.Write("\nThe Sum is : {0}\n", sum);//display sum
            Console.ReadLine();
            return 0;
        }
        static void Main(string[] args)
        {
            try
            {
                getSeriesResult();//call method
            }
            catch (Exception)
            {
                Console.Write("Please  enter a whole number");//display if user enters anything other than whole number
            }
            Console.ReadLine();
        }//main end
    }//class end
}