using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BankAccount
    {
        public BankAccount(decimal amount)
        {
            actBalance = amount;
        }
        public int AccountNumber { get; set; }
        private string actHolder;
        public string AccountHolder
        {
            get { return actHolder; }
            set 
            {
                if (value.Length < 3)
                {
                    throw new Exception();
                }
                actHolder = value; 
            }
        }
        public void Deposit(decimal amount)
        {
            actBalance += amount;
        }
        public void Withdrawl(decimal amount)
        {
            actBalance -= amount;
        }
        private decimal actBalance;
        public decimal AccountBalance
        {
            get { return actBalance; }
        }


    }
}
