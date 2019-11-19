using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = comboBox1.Text;
            string s2 = comboBox2.Text;

            string s3 = listBox1.Text;

            if(s1 != "" && s2 != "" && s3 != "")
            {
                textBox1.Text = "$ 200,000";
                label5.Text = "Thank you for purchasing!!";
            }
            else{
                label5.Text = "Enter all details";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";

            listBox1.Text = "";

            textBox1.Text = "";
            label5.Text = "";
        }
    }
}
