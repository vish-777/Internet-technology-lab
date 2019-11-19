using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputeBonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d1;
            double.TryParse(SalaryBox.Text, out d1);

            string perLevel = Performance.Text;

            int level = Convert.ToInt32(perLevel[perLevel.Length - 1])-48;

            double bonus = 0;
            
            if(level == 1)
            {
                bonus = 0.1 * d1;
            }
            else if(level >= 2 && level <= 4)
            {
                bonus = 0.09 * d1;
            }
            else if(level >=5 && level <= 7)
            {
                bonus = 0.07 * d1;
            }
            else
            {
                bonus = 0.05 * d1;
            }

            BonusText.Text = "Bonus: " + bonus;
        }

        private void Performance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
