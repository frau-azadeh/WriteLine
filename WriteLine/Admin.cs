using System;
using System.Collections.Generic;
using System.Text;

namespace WriteLine
{
    class Admin : IMInterface2
    {
        public string HelloAdmin(string name)
        {
            return "Hello Admin" + name;
        }
    }
}
