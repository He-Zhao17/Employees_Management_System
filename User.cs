using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees_Management_System
{
    public class User
    {
        public Int32 user_Id { get; set; }
        public String user_Name { get; set; }
        public String user_Password { get; set; }

        public override string ToString()
        {
            return "{user_id}    |    {user_Name}    |    {user_Password}";
        }
    }
}
