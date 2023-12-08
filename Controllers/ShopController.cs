using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop
{
    public class ShopController
    {
        public delegate void WorkDone();
        public event WorkDone OnUpdate;

        public static bool AddShop(Shop newShop, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.Name == newShop.Name)
                    return false;
            }
            shops.Add(newShop);
            return true;
        }

        public static void DeleteShop(string shopToDelete, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.Name == shopToDelete)
                {
                    shops.Remove(shop);
                    break;
                }
            }
        }

        public static bool AddProduct(string shopName, Product newProduct,  List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.Name == shopName)
                {
                    return shop.AddProduct(newProduct);
                }
            }
            return false;
        }

        public static void DeleteProduct(string shopName, int prodcuctId, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.Name == shopName)
                {
                    shop.DeleteProduct(prodcuctId);
                    break;
                }
            }
        }

        public static bool AddEmployee(string shopName, Employee newEmployee, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.Name == shopName)
                {
                    return shop.AddEmployee(newEmployee);
                }
            }
            return false;
        }

        public static bool UpdateEmployee(string shopName, int oldEmployee, Employee newEmployee, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.Name == shopName)
                {
                    return shop.UpdateEmployee(oldEmployee, newEmployee);
                }
            }
            return false;
        }

        public static void DeleteEmployee(string shopName, string firstName, string lastName, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.Name == shopName)
                {
                    shop.DeleteEmployee(firstName, lastName);
                    break;
                }
            }
        }

        public static bool AddOrder(string shopName, Order newOrder, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.Name == shopName)
                {
                    return shop.AddOrder(newOrder);
                }
            }
            return false;
        }

        public static void DeleteOrder(string shopName, int number, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.Name == shopName)
                {
                    shop.DeleteOrder(number);
                    break;
                }
            }
        }
        public void Update(Object obj, EventArgs e)
        {
            OnUpdate?.Invoke();
        }
    }
}
