﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop
{
   public class ShopContr
    {
        public delegate void workDone();
        public event workDone update;

        //Метод добавления магазина
        public static bool AddShop(Shop new_shop, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.name == new_shop.name)
                    return false;
            }
            shops.Add(new_shop);
            return true;
        }

        //Метод удаление магазина
        public static void DeleteShop(string shop_del, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.name == shop_del)
                {
                    shops.Remove(shop);
                    break;
                }
            }
        }

        //Метод добавления товара
        public static bool AddProduct(string _shop_name, Product _new_prod,  List<Shop> shops)
        {
            foreach (Shop s in shops)
            {
                if (s.name == _shop_name)
                {
                    return s.AddProduct(_new_prod);
                }
            }
            return false;
        }

        //Метод удаления товара
        public static void DeleteProduct(string _shop_name, int prod_id, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.name == _shop_name)
                {
                    shop.DeleteProduct(prod_id);
                    break;
                }
            }
        }

        //Метод добавления сторудника
        public static bool AddEmployee(string _shop_name, Employee _new_prod, List<Shop> shops)
        {
            foreach (Shop s in shops)
            {
                if (s.name == _shop_name)
                {
                    return s.AddEmployee(_new_prod);
                }
            }
            return false;
        }

        //Метод удаления сотрудника
        public static void DeleteEmployee(string _shop_name, string fname, string lname, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.name == _shop_name)
                {
                    shop.DeleteEmployee(fname, lname);
                    break;
                }
            }
        }

        public static bool AddOrder(string _shop_name, Order _new_order, List<Shop> shops)
        {
            foreach (Shop s in shops)
            {
                if (s.name == _shop_name)
                {
                    return s.AddOrder(_new_order);
                }
            }
            return false;
        }

        public static void DeleteOrder(string _shop_name, int i, List<Shop> shops)
        {
            foreach (Shop shop in shops)
            {
                if (shop.name == _shop_name)
                {
                    shop.DeleteOrder(i);
                    break;
                }
            }
        }
         public void Update(Object obj, EventArgs e)
        {

            update();
        }
    }
}
