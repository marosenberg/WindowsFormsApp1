using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(decimal amount) : base(amount)
        {
        }
        public SavingsAccount() : base(0M)
        {
        }
        public decimal InterestRate { get; set; }

    }
}
