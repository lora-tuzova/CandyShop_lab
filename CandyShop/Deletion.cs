using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CandyShop
{
    public partial class Deletion : Form
    {
        public static int delIndex;
        public Deletion()
        {
            InitializeComponent();
        }

        private void DeleteCandy_Click(object sender, EventArgs e)
        {
            string nameDel = textBox1.Text;
            int index=-1;
            bool occDel = Helper.CheckOccurence(nameDel);
            if (occDel)
                for (int i = 0; i < Form1.candySystem.CandyCatalog.Count(); i++)
                    if (Form1.candySystem.CandyCatalog[i].name == nameDel)
                        index = i;
            delIndex = index;
            Form1.candySystem.DeleteCandy();
        }
    }
}
