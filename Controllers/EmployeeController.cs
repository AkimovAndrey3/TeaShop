using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Controllers
{
    public class EmployeeController
    {
        public bool IsLoggedIn => _currentEmployee != null;

        private Employee _currentEmployee;
        private static List<Employee> _employees;

        public static void Init()
        {
            _employees = DBController.GetEmployees();
        }

        public static Employee CreateEmployee(string shopName, string firstname, string lastname, 
            string phoneNumber, string status)
        {
            Employee employee = new Employee();

            employee.EmployeeId = GenerateEmployeeId();
            employee.FirstName = firstname; 
            employee.LastName = lastname;
            employee.PhoneNumber = phoneNumber;
            employee.Status = status;
            employee.WorkBegin = DateTime.Now.ToString();
            employee.WorkEnd = DateTime.Now.ToString();

            _employees.Add(employee);

            DBController.AddEmployeeDB(shopName, employee);

            return employee;
        }

        public static void DeleteEmployee(string shopName, int id)
        {
            var employee = _employees.Find(e => e.EmployeeId == id);

            if(employee as object != null)
            {
                DBController.DeleteEmployeeDB(shopName, employee.FirstName, employee.LastName);
            }
        }

        public static Employee GetEmployeeById(int id) 
        {
            return _employees.Find(e => e.EmployeeId == id);
        }

        public static void BeginWork(string shopName, int employeeId, DateTime dateTime)
        {
            Employee employee = GetEmployeeById(employeeId);
            if (employee as object == null)
                return;

            employee.WorkBegin = dateTime.ToString();

            DBController.UpdateEmployeeDB(shopName, employeeId, employee);
        }

        public static void EndWork(string shopName, int employeeId, DateTime dateTime)
        {
            Employee employee = GetEmployeeById(employeeId);
            if (employee as object == null)
                return;

            employee.WorkEnd = dateTime.ToString();
            DBController.UpdateEmployeeDB(shopName, employeeId, employee);
        }

        private static int GenerateEmployeeId()
        {
            return _employees.Count;
        }

        
    }
}
