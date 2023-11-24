using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop
{
    public class OrderLineitem
    {
        public Product Product { get; set; }

        public OrderLineitem()
        {
            Product = new Product();
            Product.Item.Name = "";
            Product.Item.CreationDate = "2000";
            Product.Item.Id = 0;
            Product.Item.Producer = "";
            Product.Item.Price = 0;
            Product.Item.Count = 0;
            Product.Item.Description = "";
            Product.Category = "";

        }
    }
}
