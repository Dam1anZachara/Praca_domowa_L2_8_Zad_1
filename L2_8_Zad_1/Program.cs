using System;

namespace L2_8_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 0;
            int endNumber = 100;
            int primeNumberCounter = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                int numberOfDivisors = 0;
                //Console.WriteLine("Nr " + i);
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        numberOfDivisors++; 
                    }
                }
                if (numberOfDivisors == 2)
                {
                    primeNumberCounter++;
                    Console.WriteLine("Lp.: " + i);
                }
            }
            Console.WriteLine($"W zakresie liczb {startNumber} - {endNumber} jest {primeNumberCounter} liczb pierwszych ");
        }
    }
}
