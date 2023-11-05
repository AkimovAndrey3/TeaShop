using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop
{
   public class Product
    {
        public string category { get; set; }
        public ProductItem product { get; set; }

        public Product()
        {
            product = new ProductItem();
        }
    }
}
