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
    public partial class Form1 : Form
    {
        private Form2 _a { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = 0;
            using (Form2.iniciarThread())
            {
                while (true)
                {
                    a++;
                    label1.Text = a.ToString();
                    label1.Update();
                    Thread.Sleep(1000);

                    if (a > 2)
                        break;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
