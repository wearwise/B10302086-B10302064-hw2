using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            int n = c1.GetNumber();
            label1.Text = n.ToString();
            for (int i = 0; i <= n; ++i)
            {
                if (c2.IsPrime(i))
                {
                    comboBox1.Items.Add(i);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedIndex.ToString();
        }

    }

}