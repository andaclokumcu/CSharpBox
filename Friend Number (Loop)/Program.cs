using System;

namespace Friend_Number__Loop_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            int toplam1 = 0;
            int toplam2 = 0;
            

            Console.WriteLine("Birinci sayıyı girin:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < sayi1; i++)
            {
                if (sayi1 % i == 0) 
                {
                    toplam1 += i;
                }
            }

            for (int i = 1; i < sayi2; i++)
            {
                if (sayi2 % i == 0) 
                {
                    toplam2 += i;
                }
            }

            if (sayi1==toplam2 && sayi2==toplam1)
            {
                Console.WriteLine("Girilen sayılar arkadaş sayıdır.");
                
            }

            else
            {
                Console.WriteLine("Sayılar arkadaş sayı değildir");
                
            }

            Console.ReadLine();

        }
    }
}
