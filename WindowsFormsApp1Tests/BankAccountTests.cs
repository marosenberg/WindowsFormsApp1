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
            decimal initialDep = 50;
            decimal amt = 30;
            BankAccount b = new BankAccount(initialDep);
            b.Withdrawl(amt);
            decimal expected = initialDep - amt;
            Assert.AreEqual(expected, b.AccountBalance);
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