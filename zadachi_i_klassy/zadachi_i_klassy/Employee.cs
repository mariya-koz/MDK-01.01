using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachi_i_klassy
{
     class Employee
    {
        private int id_;
        private string full_name_;
        private string email_;

        public void GetId(int id)
        {
            id = id_;
        }

        public void GetFullName(string full_name) 
        {
            full_name= full_name_;
        }

        public void GetEmail(string email) 
        {
            email = email_;
        }
    }
}
