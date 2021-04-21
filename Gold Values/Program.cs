using System;

namespace Gold_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            double gramaltinBugun=468.59;
            double gramaltinDun=468.67;

            double ceyrekaltinBugun = 771;
            double ceyrekaltinDun = 754;

            string mesajArtis = "Artis var";
            string mesajAzalis = "Azalis var";
            string mesajAyni = "Sabit kalmis";

            if (gramaltinBugun>gramaltinDun)
            {
                Console.WriteLine(mesajArtis);
            }
            else if (gramaltinDun==gramaltinBugun)
            {
                Console.WriteLine(mesajAyni);
            }
            else
            {
                Console.WriteLine(mesajAzalis);
            }

            if (ceyrekaltinBugun > ceyrekaltinDun)
            {
                Console.WriteLine(mesajArtis);
            }
            else if (ceyrekaltinBugun == ceyrekaltinDun)
            {
                Console.WriteLine(mesajAyni);
            }
            else
            {
                Console.WriteLine(mesajAzalis);
            }

        }
    }
}
