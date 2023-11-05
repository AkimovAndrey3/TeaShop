using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop
{
   public class OrderLineitem
    {
       public Product product { get; set; }
       public int price { get; set; }

       public OrderLineitem()
        {
            product = new Product();
            product.product.name = "";
            product.product.date_create = "2000";
            product.product.id = 0;
            product.product.producer = "";
            product.product.price = 0;
            product.product.count = 0;
            product.product.description = "";
            product.category = "";


        }
    }
}
