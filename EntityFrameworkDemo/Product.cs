using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        //biriminin short olmasının seebebi veritabanındaki dbo.Products tablosundaki UnitsInStock
        //classının smallint değerine karşılık gelir.

    }
}
