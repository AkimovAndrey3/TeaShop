using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TeaShop.Model;

namespace TeaShop
{
   public class DBController
    {
        private static List<Shop> _shops = new List<Shop>();
        private static List<User> _users = new List<User>();

        private static readonly string _filename = "DataBase.xml";

        public static void LoadFromFile()
        {
            XmlDocument document = new XmlDocument();
            document.Load(_filename);

            foreach (XmlNode shopNode in document.ChildNodes[0].ChildNodes[0].ChildNodes)
            {
                Shop shopItem = new Shop();

                shopItem.Name = shopNode.ChildNodes[0].InnerText;
                shopItem.PhoneNumber = shopNode.ChildNodes[1].InnerText;
                shopItem.Website = shopNode.ChildNodes[2].InnerText;
                shopItem.Adress = shopNode.ChildNodes[3].InnerText;
                shopItem.BeginWork = shopNode.ChildNodes[4].InnerText;
                shopItem.EndWork = shopNode.ChildNodes[5].InnerText;

                foreach (XmlNode ProductNode in shopNode.ChildNodes[6].ChildNodes)
                {

                    Product productItem = new Product();

                    productItem.Item.Name = ProductNode.ChildNodes[0].InnerText;
                    productItem.Item.CreationDate = ProductNode.ChildNodes[1].InnerText;
                    productItem.Item.Id = Int32.Parse(ProductNode.ChildNodes[2].InnerText);
                    productItem.Item.Producer = ProductNode.ChildNodes[3].InnerText;
                    productItem.Item.Price = Int32.Parse(ProductNode.ChildNodes[4].InnerText);
                    productItem.Item.Count = Int32.Parse(ProductNode.ChildNodes[5].InnerText);
                    productItem.Item.Description = ProductNode.ChildNodes[6].InnerText;
                    productItem.Category = ProductNode.ChildNodes[7].InnerText;
                   
                    shopItem.AddProduct(productItem);
                }

                foreach (XmlNode EmployeeNode in shopNode.ChildNodes[7].ChildNodes)
                {
                    Employee employeeItem = new Employee();

                    employeeItem.EmployeeId = int.Parse(EmployeeNode.ChildNodes[0].InnerText);
                    employeeItem.FirstName = EmployeeNode.ChildNodes[1].InnerText;
                    employeeItem.LastName = EmployeeNode.ChildNodes[2].InnerText;
                    employeeItem.PhoneNumber = EmployeeNode.ChildNodes[3].InnerText;
                    employeeItem.Status = EmployeeNode.ChildNodes[4].InnerText;
                    employeeItem.WorkBegin = EmployeeNode.ChildNodes[5].InnerText;
                    employeeItem.WorkEnd = EmployeeNode.ChildNodes[6].InnerText;

                    shopItem.AddEmployee(employeeItem);
                }

                foreach (XmlNode OrderNode in shopNode.ChildNodes[8].ChildNodes)
                {
                    Order OrderItem = new Order();

                    OrderItem.OrderNumber = Int32.Parse(OrderNode.ChildNodes[0].InnerText);
                    OrderItem.Description = OrderNode.ChildNodes[1].InnerText;

                    foreach(XmlNode OLineNode in OrderNode.ChildNodes[2].ChildNodes)
                    {
                        OrderLineitem orderLineitem = new OrderLineitem();

                        orderLineitem.Product.Item.Name = OLineNode.ChildNodes[0].InnerText;
                        orderLineitem.Product.Item.CreationDate = OLineNode.ChildNodes[1].InnerText;
                        orderLineitem.Product.Item.Id = Int32.Parse(OLineNode.ChildNodes[2].InnerText);
                        orderLineitem.Product.Item.Producer = OLineNode.ChildNodes[3].InnerText;
                        orderLineitem.Product.Item.Price = Int32.Parse(OLineNode.ChildNodes[4].InnerText);
                        orderLineitem.Product.Item.Count = Int32.Parse(OLineNode.ChildNodes[5].InnerText);
                        orderLineitem.Product.Item.Description = OLineNode.ChildNodes[6].InnerText;
                        orderLineitem.Product.Category = OLineNode.ChildNodes[7].InnerText;

                        OrderItem.AddOrderLineItem(orderLineitem);
                    }
                    OrderItem.TotalPrice = Int32.Parse(OrderNode.ChildNodes[3].InnerText);

                    shopItem.AddOrder(OrderItem);
                }
                _shops.Add(shopItem);
            }

            foreach (XmlNode userNode in document.ChildNodes[0].ChildNodes[1].ChildNodes)
            {
                User user = new User();
                user.EmployeeId = int.Parse(userNode.ChildNodes[0].InnerText);
                user.IsAdmin = bool.Parse(userNode.ChildNodes[1].InnerText);
                user.Email = userNode.ChildNodes[2].InnerText;
                user.Password = userNode.ChildNodes[3].InnerText;
                _users.Add(user);
            }
        }
      
        public static void SaveToFile()
        {
            XmlDocument document = new XmlDocument();

            document.Load(_filename);
            document.RemoveAll();

            XmlNode BaseNode = document.CreateElement("Base");

            XmlNode shopsNode = document.CreateElement("shops");

            foreach (Shop shop in _shops)
            {
                XmlNode ShopNode = document.CreateElement("shop");

                XmlNode ShopNameNode = document.CreateElement("name");
                ShopNameNode.InnerText = shop.Name;
                ShopNode.AppendChild(ShopNameNode);

                XmlNode PhoneNode = document.CreateElement("PhoneNumber");
                PhoneNode.InnerText = shop.PhoneNumber;
                ShopNode.AppendChild(PhoneNode);

                XmlNode WebSiteNode = document.CreateElement("website");
                WebSiteNode.InnerText = shop.Website;
                ShopNode.AppendChild(WebSiteNode);

                XmlNode AdressNode = document.CreateElement("adress");
                AdressNode.InnerText = shop.Adress;
                ShopNode.AppendChild(AdressNode);

                XmlNode StartTimeNode = document.CreateElement("BeginWork");
                StartTimeNode.InnerText = shop.BeginWork;
                ShopNode.AppendChild(StartTimeNode);

                XmlNode StopTimeNode = document.CreateElement("EndWork");
                StopTimeNode.InnerText = shop.EndWork;
                ShopNode.AppendChild(StopTimeNode);

                XmlNode GoodsNode = document.CreateElement("products");
                XmlNode EmployeesNode = document.CreateElement("employees");
                XmlNode OrdersNode = document.CreateElement("orders");

                foreach (Product prod in shop.GetGoods())
                {
                    XmlNode ProductNode = document.CreateElement("product");

                    XmlNode NameNode = document.CreateElement("name");
                    NameNode.InnerText = prod.Item.Name;
                    ProductNode.AppendChild(NameNode);

                    XmlNode DateNode = document.CreateElement("date_create");
                    DateNode.InnerText = prod.Item.CreationDate;
                    ProductNode.AppendChild(DateNode);

                    XmlNode IndexNode = document.CreateElement("index");
                    IndexNode.InnerText = prod.Item.Id.ToString();
                    ProductNode.AppendChild(IndexNode);

                    XmlNode ProducerNode = document.CreateElement("producer");
                    ProducerNode.InnerText = prod.Item.Producer;
                    ProductNode.AppendChild(ProducerNode);

                    XmlNode PriceNode = document.CreateElement("price");
                    PriceNode.InnerText = prod.Item.Price.ToString();
                    ProductNode.AppendChild(PriceNode);

                    XmlNode CountNode = document.CreateElement("count");
                    CountNode.InnerText = prod.Item.Count.ToString();
                    ProductNode.AppendChild(CountNode);

                    XmlNode ParamsNode = document.CreateElement("params");
                    ParamsNode.InnerText = prod.Item.Description;
                    ProductNode.AppendChild(ParamsNode);

                    XmlNode TypeNode = document.CreateElement("type");
                    TypeNode.InnerText = prod.Category;
                    ProductNode.AppendChild(TypeNode);

                    GoodsNode.AppendChild(ProductNode);
                }
                foreach(Employee employer in shop.GetEmployees() )
                {
                    XmlNode EmployerNode = document.CreateElement("employer");

                    XmlNode EmployeeIdNode = document.CreateElement("employeeId");
                    EmployeeIdNode.InnerText = employer.EmployeeId.ToString();
                    EmployerNode.AppendChild(EmployeeIdNode);

                    XmlNode FnameNode = document.CreateElement("firstName");
                    FnameNode.InnerText = employer.FirstName;
                    EmployerNode.AppendChild(FnameNode);

                    XmlNode LnameNode = document.CreateElement("lastName");
                    LnameNode.InnerText = employer.LastName;
                    EmployerNode.AppendChild(LnameNode);

                    XmlNode PhoneNumNode = document.CreateElement("PhoneNumber");
                    PhoneNumNode.InnerText = employer.PhoneNumber;
                    EmployerNode.AppendChild(PhoneNumNode);

                    XmlNode StatusNode = document.CreateElement("status");
                    StatusNode.InnerText = employer.Status.ToString();
                    EmployerNode.AppendChild(StatusNode);

                    XmlNode BeginWorkNode = document.CreateElement("workBegin");
                    BeginWorkNode.InnerText = employer.WorkBegin;
                    EmployerNode.AppendChild(BeginWorkNode);

                    XmlNode EndWorkNode = document.CreateElement("workEnd");
                    EndWorkNode.InnerText = employer.WorkEnd;
                    EmployerNode.AppendChild(EndWorkNode);

                    EmployeesNode.AppendChild(EmployerNode);
                }

                foreach(Order order in shop.GetOrders())
                {
                    XmlNode OrderNode = document.CreateElement("order");

                    XmlNode IndexNode = document.CreateElement("index");
                    IndexNode.InnerText = order.OrderNumber.ToString();
                    OrderNode.AppendChild(IndexNode);

                    XmlNode DescrNode = document.CreateElement("descr");
                    DescrNode.InnerText = order.Description;
                    OrderNode.AppendChild(DescrNode);

                    XmlNode OrderItemsNode = document.CreateElement("orderLineItems");

                    foreach (OrderLineitem order_field in order.GetOrdersFields())
                    {
                        XmlNode OLineNode = document.CreateElement("orderLineItem");

                        XmlNode NameNode = document.CreateElement("name");
                        NameNode.InnerText = order_field.Product.Item.Name;
                        OLineNode.AppendChild(NameNode);

                        XmlNode DateNode = document.CreateElement("date_create");
                        DateNode.InnerText = order_field.Product.Item.CreationDate;
                        OLineNode.AppendChild(DateNode);

                        XmlNode IndNode = document.CreateElement("index");
                        IndNode.InnerText = order_field.Product.Item.Id.ToString();
                        OLineNode.AppendChild(IndNode);

                        XmlNode ProducerNode = document.CreateElement("producer");
                        ProducerNode.InnerText = order_field.Product.Item.Producer;
                        OLineNode.AppendChild(ProducerNode);

                        XmlNode CostNode = document.CreateElement("price");
                        CostNode.InnerText = order_field.Product.Item.Price.ToString();
                        OLineNode.AppendChild(CostNode);

                        XmlNode CountNode = document.CreateElement("count");
                        CountNode.InnerText = 1.ToString();
                        OLineNode.AppendChild(CountNode);

                        XmlNode ParamsNode = document.CreateElement("params");
                        ParamsNode.InnerText = order_field.Product.Item.Description;
                        OLineNode.AppendChild(ParamsNode);

                        XmlNode TypeNode = document.CreateElement("type");
                        TypeNode.InnerText = order_field.Product.Category;
                        OLineNode.AppendChild(TypeNode);

                        OrderItemsNode.AppendChild(OLineNode);
                    }
                    OrderNode.AppendChild(OrderItemsNode);
                    XmlNode PriceNode = document.CreateElement("totalPrice");
                    PriceNode.InnerText = order.TotalPrice.ToString();
                    OrderNode.AppendChild(PriceNode);
                    OrdersNode.AppendChild(OrderNode);

                }
                ShopNode.AppendChild(GoodsNode);
                ShopNode.AppendChild(EmployeesNode);
                ShopNode.AppendChild(OrdersNode);
                shopsNode.AppendChild(ShopNode);
            }

            XmlNode usersNode = document.CreateElement("users");

            foreach (User user in _users)
            {
                XmlNode userNode = document.CreateElement("users");

                XmlNode employeeIdNode = document.CreateElement("employeeId");
                employeeIdNode.InnerText = user.EmployeeId.ToString();
                userNode.AppendChild(employeeIdNode);

                XmlNode isAdminNode = document.CreateElement("isAdmin");
                isAdminNode.InnerText = user.IsAdmin.ToString();
                userNode.AppendChild(isAdminNode);

                XmlNode emailNode = document.CreateElement("email");
                emailNode.InnerText = user.Email;
                userNode.AppendChild(emailNode);

                XmlNode passwordNode = document.CreateElement("password");
                passwordNode.InnerText = user.Password;
                userNode.AppendChild(passwordNode);

                usersNode.AppendChild(userNode);
            }

            BaseNode.AppendChild(shopsNode);
            BaseNode.AppendChild(usersNode);
            document.AppendChild(BaseNode);
            document.Save(_filename);
        }

        public static void AddShopDB(Shop newShop)
        {
            ShopController.AddShop(newShop, _shops);
        }

        public static void DeleteShopDB(string shopToDelete)
        {
            ShopController.DeleteShop(shopToDelete, _shops);
        }

        public static IReadOnlyCollection<Shop> GetShops()
        {
            return _shops.AsReadOnly();
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            foreach (Shop shop in _shops)
            {
                employees.AddRange(shop.GetEmployees());
            }
            return employees;
        }
        public static List<User> GetUsers()
        {
            return new List<User>(_users);
        }
        public static void SetUsers(List<User> users)
        {
            _users = users;
        }

        public static void AddProductDB(string shopName, Product newProduct)
        {
            ShopController.AddProduct(shopName, newProduct, _shops);
        }

        public static void DeleteProductDB(string shopName, int index)
        {
            ShopController.DeleteProduct(shopName, index, _shops);
        }

        public static void AddEmployeeDB(string shopName, Employee newEmployee)
        {
            ShopController.AddEmployee(shopName, newEmployee, _shops);
        }

        public static void UpdateEmployeeDB(string shopName, int oldEmployee, Employee newEmployee)
        {
            ShopController.UpdateEmployee(shopName, oldEmployee, newEmployee, _shops);
        }

        public static void DeleteEmployeeDB(string shopName, string firstName, string lastName)
        {
            ShopController.DeleteEmployee(shopName, firstName, lastName, _shops);
        }

        public static void AddOrderDB(string shopName, Order newOrder)
        {
            ShopController.AddOrder(shopName, newOrder, _shops);
        }

        public static void DeleteOrderDB(string shopName, int number)
        {
            ShopController.DeleteOrder(shopName, number, _shops);
        }
    }
}
