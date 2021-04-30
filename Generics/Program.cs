using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T>  //Generic class
    {
        T[] _array;  //dizi tanımlama
        T[] _tempArray; //stack ve head de referans tutucu

        public MyList()  
        {
            _array = new T[0]; //eleman newlendi yani listeye ilk eleman olarak atandı
        }

        public void Add(T item)
        {
            _tempArray = _array; //_array'in referans adresi eşitlenir yani _temArray tarafından tutulur.

            _array = new T[_array.Length + 1]; //her newlemede var olan _array bir ekleniyor gibi yani array artık yeni bir yeri tutsun diyoruz.
                                     //102.adres oluşuyor. 101 adresi olan array 102 oluyor. 101.adrestekileri _tempArray tutuyor.

            for (int i = 0; i < _tempArray.Length + 1; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

 //Add(item) ile gönderdiğimiz yeni eleman array[array.Length-1] = item kodyu ile 4-1 yani 3.adrese eklenecek.Yani boş olan yere yeni eleman eklenecek.

        public int Count
        {
            get { return _array.Length; } //array uzunluğunu saydırır ve döndürür.
        }

    }
}
