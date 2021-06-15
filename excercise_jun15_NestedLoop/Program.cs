using System;

namespace excercise_jun15_NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for(i=1; i<=5; i++)
            {
                for(j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");       
            }

            Console.WriteLine(" ");

            int k, l;

            for (k = 1; k <= 5; k++)
            {
                for (l = 5; l >= k; l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
