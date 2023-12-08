using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Model
{
    public class User
    {
        public int EmployeeId { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
