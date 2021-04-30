using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public delegate void OverdrawDelegate(object sender, MyEventArgs e);
    public class BankAccount : IBankAccount
    {
        public event OverdrawDelegate Overdraw;

        private void OverdrawEvent()
        {
            if (Overdraw != null)
            {
                MyEventArgs e = new MyEventArgs(actBalance);
                Overdraw(this, e);
            }
        }
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
        public virtual void Withdrawl(decimal amount)
        {
            if (amount > actBalance)
            {
                OverdrawEvent();
            }
            actBalance -= amount;
        }
        private decimal actBalance;
        public decimal AccountBalance
        {
            get { return actBalance; }
        }
    }
}
