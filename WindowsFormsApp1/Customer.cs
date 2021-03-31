using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Customer: Person
    {
        public decimal CreditLimit { get; set; }

        public override void CallOnPhone(string phonenumber)
        {
            base.CallOnPhone(phonenumber);
        }
    }
}
