using System;
using System.Collections.Generic;


namespace TeaShop
{
    public class Shop
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Adress { get; set; }
        public string BeginWork { get; set; }
        public string EndWork { get; set; }

        private List<Product> _productList { get; set; }
        private List<Employee> _employees { get; set; }
        private List<Order> _orders { get; set; }

        public int CountGoods
        {
            get { return _productList.Count; }
        }
        public int CountEmployees
        {
            get { return _employees.Count; }
        }

        public int CountOrders
        {
            get { return _orders.Count; }
        }

        public Shop()
        {
            _productList = new List<Product>();
            _employees = new List<Employee>();
            _orders = new List<Order>();
        }

        public bool AddProduct(Product newProduct)
        {
            foreach (Product product in _productList)
            {
                if (product.Item.Name == newProduct.Item.Name)
                    return false;
            }
            _productList.Add(newProduct);
            return true;
        }

        public bool DeleteProduct(int index)
        {
            foreach (Product product in _productList)
            {
                if (index == product.Item.Id)
                {
                    return _productList.Remove(product);
                }
            }
            return false;
        }

        public IReadOnlyCollection<Product> GetGoods()
        {
            return _productList.AsReadOnly();
        }

        public IReadOnlyCollection<Employee> GetEmployees()
        {
            return _employees.AsReadOnly();
        }

        public IReadOnlyCollection<Order> GetOrders()
        {
            return _orders.AsReadOnly();
        }

        public bool AddEmployee(Employee newEmployee)
        {
            foreach (Employee employee in _employees)
            {
                if ((employee.FirstName == newEmployee.FirstName) && (employee.LastName == newEmployee.LastName))
                    return false;
            }
            _employees.Add(newEmployee);
            return true;
        }

        public bool DeleteEmployee(string firstName, string lastName)
        {
            foreach (Employee employee in _employees)
            {
                if ((employee.FirstName == firstName) && (employee.LastName == lastName))
                {
                    return _employees.Remove(employee);
                }
            }
            return false;
        }

        public bool AddOrder(Order newOrder)
        {
            foreach (Order order in _orders)
            {
                if (order.OrderNumber == newOrder.OrderNumber)
                    return false;
            }
            _orders.Add(newOrder);
            return true;
        }

        public bool DeleteOrder(int number)
        {
            foreach (Order product in _orders)
            {
                if (number == product.OrderNumber)
                {
                    return _orders.Remove(product);
                }
            }
            return false;
        }
    }
}