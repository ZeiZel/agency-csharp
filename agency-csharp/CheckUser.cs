using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agency_csharp
{
    public class CheckUser
    {
        public string Login { get; set; }

        public bool IsAdmin { get; }
        public bool IsEmployee { get; }

        public string Status => IsAdmin ? "Admin" : (IsEmployee ? "Employee" : "User");

        public CheckUser(string login, bool isAdmin, bool isEmployee)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
            IsEmployee = isEmployee;
        }
    }
}
