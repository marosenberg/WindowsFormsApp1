using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SavingsAccount : BankAccount, IDisposable
    {
        private bool disposedValue;

        public SavingsAccount(decimal amount) : base(amount)
        {
        }
        public SavingsAccount() : base(0M)
        {
        }
        public decimal InterestRate { get; set; }
        public override void Withdrawl(decimal amount)
        {
            using (SqlConnection s = new SqlConnection())
            {

            }
            SqlConnection sl;
            try
            {
                sl = new SqlConnection();
            }
            catch (ArgumentException)
            {

            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong");
            }
            finally
            {
               
            }
            if (amount > AccountBalance)
            {
                throw new Exception();
            }
            base.Withdrawl(amount);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~SavingsAccount()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }   
}
