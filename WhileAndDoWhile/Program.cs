using System;

namespace WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //While and Do While Loop// Break statement
            int i = 0;
            while (true)
            {
                if (i > 10)
                {
                    break;
                    
                }
                
                Console.WriteLine(i);
                i++;
            }

            //Continue statement
            int j = 0;
            while (j < 20)
            {
                j++;
                if (j%5==0)
                {
                    continue;
                }
                Console.WriteLine(j);
            }


            //Do While Loop

            int k = 0;

            do
            {
                Console.WriteLine("Value of k: {0}", k);

                k++;

            } while (k < 10);

            Console.ReadKey();
        }
    }
}
