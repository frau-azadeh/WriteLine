using System;
using System.Collections.Generic;
using System.Text;

namespace WriteLine
{
    class Motor
    {
        private int _speed;

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > 120)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("your ride very fast!");
                    _speed = 0;
                    Console.ResetColor();
                }
                else
                {
                    _speed = value;
                }
            }
        }
    }
}
