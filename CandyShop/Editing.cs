using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyShop
{
    public partial class Editing : Form
    {
        public static int editIndex;
        public Editing()
        {
            InitializeComponent();
        }

        private void IndexSubmit_Click(object sender, EventArgs e)
        {
            IndexSubmit.Visible = false;
            textBox1.Visible = false;
            EditLabel.Visible = false;
            string nameEdit = textBox1.Text;
            editIndex = -1;
            bool occEdit = Helper.CheckOccurence(nameEdit);
            if (occEdit)
            {
                for (int i = 0; i < Form1.candySystem.CandyCatalog.Count(); i++)
                    if (Form1.candySystem.CandyCatalog[i].name == nameEdit)
                        editIndex = i;
                EditEnd.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                dateTimePicker1.Visible = true;
                textBox2.Text = Form1.candySystem.CandyCatalog[editIndex].name;
                textBox3.Text = Form1.candySystem.CandyCatalog[editIndex].price.ToString();
                textBox4.Text = Form1.candySystem.CandyCatalog[editIndex].manufacturer.name;
                textBox5.Text = Form1.candySystem.CandyCatalog[editIndex].manufacturer.country;
                dateTimePicker1.Value = Form1.candySystem.CandyCatalog[editIndex].packageDate;
            }
            else { 
                MessageBox.Show("There is no such candy in the list");
                this.Close();
            }
        }

        private void EditEnd_Click(object sender, EventArgs e)
        {
            Manufacturer manEdit = new Manufacturer();

            manEdit.name = textBox4.Text;
            manEdit.country = textBox5.Text;
            Candy editSample = new Candy(textBox2.Text, decimal.Parse(textBox3.Text), dateTimePicker1.Value, manEdit);
            Form1.candySystem.EditCandy(editSample);
        }
    }
}
