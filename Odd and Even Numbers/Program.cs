using System;

namespace Odd_and_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;


            Console.WriteLine("Sayı giriniz:");

            {
                for (int i = 1; i < 10; i++)
                {
                    
                    sayi = Convert.ToInt32(Console.ReadLine());
                   
                    if (sayi > 0 && sayi % 2 == 0)
                    {
                        Console.WriteLine("Sayı çift sayıdır.");
                    }
                    if (sayi > 0 && sayi % 2 == 1)
                    {
                        Console.WriteLine("Sayı tek sayıdır.");
                    }
                }
            }
        }
    }
}
