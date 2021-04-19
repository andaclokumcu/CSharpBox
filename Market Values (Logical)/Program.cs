using System;

namespace Market_Values__Logical_
{
    class Program
    {
        static void Main(string[] args)
        {
            double piyasaDun = 115000.6;
            double piyasaBugun = 116000;
            bool sonuc = piyasaBugun == piyasaDun;

            string mesajArtis = "Artis oku";
            string mesajAzalis = "Azalis oku";
            string mesajAyni = "Sabit oku";

            if(piyasaBugun>piyasaDun)
            {
                Console.WriteLine(mesajArtis);
            }
            else if(piyasaBugun==piyasaDun)
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
