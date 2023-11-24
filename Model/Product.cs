using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop
{
   public class Product
    {
        public string Category { get; set; }
        public ProductItem Item { get; set; }

        public Product()
        {
            Item = new ProductItem();
        }
    }
}
