using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Model;

namespace TeaShop.Controllers
{
    public enum LoginResult
    {
        Done,
        WrongPassword,
        WrongEmail
    }

    public enum RegisterResult
    {
        Done,
        UserExists
    }

    public class UserController
    {
        public static event Action OnUserLoggedIn;
        public static event Action OnUserLoggedOut;
        public static bool IsLoggedIn => _currentUser != null;
        public static bool IsAdmin => _currentUser != null ? _currentUser.IsAdmin : false;

        private const string _adminStatus = "Менеджер";

        private static User _currentUser;
        private static List<User> _users = new List<User>();

        public static void Init()
        {
            _users = DBController.GetUsers();
        }

        public static void Save()
        {
            DBController.SetUsers(_users);
        }

        public static LoginResult LoginUser(string email, string password)
        {
            User user = GetUserByEmail(email);

            if(user == null)
            {
                return LoginResult.WrongEmail;
            }

            if(password != user.Password)
            {
                return LoginResult.WrongPassword;
            }

            _currentUser = user;
            OnUserLoggedIn?.Invoke();
            return LoginResult.Done;
        }

        public static void LogoutUser()
        {
            _currentUser = null;
            OnUserLoggedOut?.Invoke();
        }

        public static RegisterResult RegisterUser(string email, string password, string shopName, string firstname, string lastname,
            string phoneNumber, string status)
        {
            if(GetUserByEmail(email) != null)
            {
                return RegisterResult.UserExists;
            }

            User user = new User();
            user.Email = email;
            user.Password = password;

            Employee employee = EmployeeController.CreateEmployee(shopName, firstname, lastname, phoneNumber, status);
            user.EmployeeId = employee.EmployeeId;
            user.IsAdmin = employee.Status == _adminStatus;

            _users.Add(user);
            return RegisterResult.Done;
        }

        public static void DeleteUser(string shopName, int id)
        {
            var user = _users.Find(u => u.EmployeeId == id);
            if(user != null)
                _users.Remove(user);

            EmployeeController.DeleteEmployee(shopName, id);
        }

        public static void BeginWork(string shopName, DateTime dateTime)
        {
            if (!IsLoggedIn)
                return;

            EmployeeController.BeginWork(shopName, _currentUser.EmployeeId, dateTime);
        }

        public static void EndWork(string shopName, DateTime dateTime)
        {
            if (!IsLoggedIn)
                return;

            EmployeeController.EndWork(shopName, _currentUser.EmployeeId, dateTime);
        }

        private static User GetUserByEmail(string email)
        {
            return _users.Find(user => user.Email == email);
        }
    }
}
