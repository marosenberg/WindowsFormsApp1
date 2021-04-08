using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BankAccount s;
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button1.MouseEnter += John;
            s = new BankAccount(100);
            s.Overdraw += S_Overdraw;
            s.Overdraw += S_Overdraw;
        }

        private void John(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Aqua;
        }

        private void S_Overdraw(object sender, MyEventArgs e)
        {
            label1.Text = label1.Text + "Event fired and Balance is: " + e.Bal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Withdrawl(decimal.Parse(myTextBox1.Text));
        }
    }
}
