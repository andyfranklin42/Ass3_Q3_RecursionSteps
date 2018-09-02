using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3_Q3_RecursionSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            //unit tests written to check code
            unitTest();
            
            //Console.WriteLine(CountWays(4));

            //always included code to make sure you can see the output before the console closes
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }


        private static int CountWays(int numStairs)
        {
            int count = 0;
            //do we have both options?
            if (numStairs >= 2)
            {
                //option if you take 1 step next
                count += CountWays(numStairs - 1);
                //option if you take 2 steps next
                count += CountWays(numStairs - 2);
            }
            else
            {
                //if no then single step is the only choice
                return 1;
            }

            return count;
            
        }

        private static void unitTest()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("For " + i + " steps: " + CountWays(i));
            }
        }

    }
}
