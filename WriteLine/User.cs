using System;
using System.Collections.Generic;
using System.Text;

namespace WriteLine
{
    class User:IMInterface1
    {
        //public string name;
        //public string family;
        //public int age;

        //public User(string name, string family, int age)
        //{
        //    this.name = name;
        //    this.family = family;
        //    this.age = age;
        //}

        public string HelloUser(string name)
        {
            return "Hello user" + name;
        }
    }
}
