using System;
using System.Collections.Generic;
using System.Text;

namespace Mphones.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Memory { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
