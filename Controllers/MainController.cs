using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Controllers;

namespace TeaShop
{
    public class MainController
    {
        public delegate void WorkDone();
        public event WorkDone Update;

        private List<Shop> _shops;
        private int _countShop;

        public MainController()
        {
            DBController.LoadFromFile();

            EmployeeController.Init();
            UserController.Init();

            UserController.OnUserLoggedIn += EmitUpdate;
            UserController.OnUserLoggedOut += EmitUpdate;

            _shops = new List<Shop>(DBController.GetShops());
            _countShop = _shops.Count;
        }

        private void EmitUpdate()
        {
            Update?.Invoke();
        }

        public void Save()
        {
            UserController.Save();
            DBController.SaveToFile();
        }

        private void Signal(object sender, EventArgs e)
        {
            _shops = new List<Shop>(DBController.GetShops());
            Update?.Invoke();
        }

        public void AddShop()
        {
            AddShopForm addShop = new AddShopForm();
            addShop.FormClosed += Signal;
            addShop.Show();
        }

        public void DeleteShop()
        {
            DeleteShopForm deleteShop = new DeleteShopForm();
            deleteShop.FormClosed += Signal;
            deleteShop.Show();
        }

        public IReadOnlyList<Shop> GetShops()
        {
            return _shops.AsReadOnly();
        }

        public void ProductsInfo(string shopName)
        {
            foreach (Shop shopItem in _shops)
            {
                if (shopItem.Name == shopName)
                {
                    List<Product> products = new List<Product>(shopItem.GetGoods());
                    InfoAboutProductsForm ProdInfo = new InfoAboutProductsForm(shopName, products);
                    ProdInfo.FormClosed += Signal;
                    ProdInfo.Show();                 
                }
            }
        }

        public void EmployeeInfo(string shopName)
        {
            foreach (Shop shopItem in _shops)
            {
                if (shopItem.Name == shopName)
                {
                    List<Employee> employees = new List<Employee>(shopItem.GetEmployees());
                    InfoAboutEmployeesForm prodInfo = new InfoAboutEmployeesForm(shopName, employees);
                    prodInfo.FormClosed += Signal;
                    prodInfo.Show();

                }
            }
        }

        public void OrderInfo(string shopName)
        {
            foreach (Shop shopItem in _shops)
            {
                if (shopItem.Name == shopName)
                {
                    List<Order> orders = new List<Order>(shopItem.GetOrders());
                    InfoAboutOrdersForm prodInfo = new InfoAboutOrdersForm(shopName, orders);
                    prodInfo.FormClosed += Signal;
                    prodInfo.Show();
                }
            }
        }
    }
}
