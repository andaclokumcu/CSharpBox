using System;
using System.Collections.Generic;
using System.Text;

namespace Linq__Join_and_DTO_
{
    class ProductDto //daha detay
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        //Yukarıdakiler bize lazım olan kriterler

        public string CategoryName { get; set; } 
        
//Product sınıfında olmayan bir özellik eklemek istiyoruz.Category sınıfından bir kriter bu. Burada sınıfları join etmemiz gerekiyor.İki classı ilişkilendirmiş olduk.
    }
}
