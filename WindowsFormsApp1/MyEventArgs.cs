using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MyEventArgs : EventArgs
    {
        public decimal Bal { get; set; }
        public MyEventArgs(decimal Bal) : base()
        {
            this.Bal = Bal;
        }
    }
}
