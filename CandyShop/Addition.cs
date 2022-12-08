using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyShop
{
    public partial class Addition : Form
    {
        public Addition()
        {
            InitializeComponent();
        }

        private void AdditionEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations, you've successfully added a new candy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Manufacturer man = new Manufacturer();
                man.name = textBox3.Text;
                man.country = textBox4.Text;
                Form1.candySystem.CandyCatalog.Add(new Candy(textBox1.Text, decimal.Parse(textBox2.Text), dateTimePicker1.Value, man));
            }
            catch { MessageBox.Show("Incorrect input"); }
            AdditionEnd.Enabled = true;
        }
    }
}
