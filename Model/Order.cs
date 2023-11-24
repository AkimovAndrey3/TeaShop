using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public int TotalPrice { get; set; }
        public string Description { get; set; }

        public List<OrderLineitem> Products = new List<OrderLineitem>();

        public static bool operator !=(Order left, Order right)
        {
            if (left.OrderNumber != right.OrderNumber)
                return true;
            else 
                return false;
        }
        public static bool operator ==(Order left, Order right)
        {
            if (left.OrderNumber == right.OrderNumber)
                return true;
            else 
                return false;
        }

        public bool AddOrderLineItem(OrderLineitem newItem)
        {
            foreach (OrderLineitem product in Products)
            {
                if (product.Product == newItem.Product)
                    return false;
            }
            Products.Add(newItem);
            return true;
        }

        public bool DeleteOrderLineItem(string name)
        {
            foreach (OrderLineitem product in Products)
            {
                if (name == product.Product.Item.Name)
                {
                    return Products.Remove(product);
                }
            }
            return false;
        }

        public IReadOnlyCollection<OrderLineitem> GetOrdersFields()
        {
            return Products.AsReadOnly();
        }
    }
}
