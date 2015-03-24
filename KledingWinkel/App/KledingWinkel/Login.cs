using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KledingWinkelApp.Users
{
    class User
    {
        public string Name { get; private set; }
        public string Pass { get; private set; }
        public bool IsAdmin { get; private set; }
        public User(string n, string p, bool isadmin)
        {
            Name = n;
            Pass = p;
            IsAdmin = isadmin;
        }
    }
}
