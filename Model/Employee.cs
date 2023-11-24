using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop
{
  public  class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string Experience { get; set; }
        public string WorkBegin { get; set; }
        public string WorkEnd { get; set; }

        public static bool operator !=(Employee left, Employee right)
        {
            if ((left.PhoneNumber != right.PhoneNumber) ||
                (left.LastName != right.LastName) ||
                (left.FirstName != right.FirstName))
                return true;
            else 
                return false;
        }
        public static bool operator ==(Employee left, Employee right)
        {
            if ((left.PhoneNumber == right.PhoneNumber) &&
                (left.LastName == right.LastName) &&
                (left.FirstName == right.FirstName)) 
                return true;
            else 
                return false;
        }
    }
}
