using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Login
    {
        /* Get dan Set untuk class Login */
        public string username { get; set; } // Username
        public string password { get; set; } // Password

        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Login()
        {

        }

    }
}
