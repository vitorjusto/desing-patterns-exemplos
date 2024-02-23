using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static Form2 iniciarThread()
        {
            var b = new Form2();
            Application.Run(b);

            return b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = 0;
            while (true)
            {
                a++;
                label1.Text = a.ToString();
                label1.Update();
                Thread.Sleep(1000);
            }
        }
    }
}
