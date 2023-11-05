using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop
{
    public class MainContr
    {
        //Список магазинов
        private List<Shop> shops;
        //Делегат событий для обновления
        public delegate void workDone();
        public event workDone update;

        public int CountShop;
        public MainContr()
        {
            ContrDB.Load_from_file();
            shops = new List<Shop>(ContrDB.GetShops());
            CountShop = shops.Count;
        }

        //Метод сохранения БД
        public void Save()
        {
            ContrDB.Save_from_file();
        }

        //Обработчик промежуточных форм
        private void Signal(object sender, EventArgs e)
        {
            shops = new List<Shop>(ContrDB.GetShops());
            update();
        }

        //Метод добавление магазина
        public void AddShop()
        {
            AddShopForm addShop = new AddShopForm();
            addShop.FormClosed += Signal;
            addShop.Show();
        }

        //Метод удаления магазина
        public void DeleteShop()
        {
            DeleteShopForm deleteShop = new DeleteShopForm();
            deleteShop.FormClosed += Signal;
            deleteShop.Show();
        }

        //Метод получения списка магазинов
        public IReadOnlyList<Shop> GetShop()
        {
            return shops.AsReadOnly();
        }

        public void ProductsInfo(string shop_name)
        {
            foreach (Shop shopItem in shops)
            {
                if (shopItem.name == shop_name)
                {
                List<Product> products = new List<Product>(shopItem.GetGoods());
                InfoAboutProductsForm ProdInfo = new InfoAboutProductsForm(shop_name, products);
                ProdInfo.FormClosed += Signal;
                ProdInfo.Show();                 
                }
            }
        }

        public void EmployeeInfo(string shop_name)
        {
            foreach (Shop shopItem in shops)
            {
                if (shopItem.name == shop_name)
                {
                    List<Employee> employees = new List<Employee>(shopItem.GetEmployees());
                    InfoAboutEmployeesForm ProdInfo = new InfoAboutEmployeesForm(shop_name, employees);
                    ProdInfo.FormClosed += Signal;
                    ProdInfo.Show();

                }
            }
        }

        public void OrderInfo(string shop_name)
        {
            foreach (Shop shopItem in shops)
            {
                if (shopItem.name == shop_name)
                {
                    List<Order> orders = new List<Order>(shopItem.GetOrders());
                    InfoAboutOrdersForm ProdInfo = new InfoAboutOrdersForm(shop_name, orders);
                    ProdInfo.FormClosed += Signal;
                    ProdInfo.Show();
                }
            }
        }
    }
}
