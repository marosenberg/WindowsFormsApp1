using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void WithdrawlTest()
        {
            decimal amt = 25;
            BankAccount b = new BankAccount(50);
            b.Withdrawl(amt);
            Assert.AreEqual(amt, b.AccountBalance);
        }

        [TestMethod()]
        public void WithdrawlTestOverdraw()
        {
            decimal amt = 100;
            BankAccount b = new BankAccount(50);
            decimal expected = b.AccountBalance;
            b.Withdrawl(amt);
            Assert.AreEqual(expected, b.AccountBalance);
        }
    }
}