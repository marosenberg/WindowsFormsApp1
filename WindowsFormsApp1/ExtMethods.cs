using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class ExtMethods
    {
        public static string AddOne(this int a, string message)
        {
            return message + (a + 1).ToString();
        }
    }
}
