using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___Properties
{
    class Product
    {
        public Product()
        {
            _unitPrice = 1000;  //set--> yazdırma
        }

        decimal _unitPrice;

        public int Id { get; set; }
        public string ProductNumber { get; set; }

        public decimal UnitPrice
        {
            get
            {
                return _unitPrice + _unitPrice * 18 / 100; //get--> okuma
            }
        }

        public decimal UnitInStock;
    }
}
