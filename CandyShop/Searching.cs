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
    public partial class Searching : Form
    {
        public Searching()
        {
            InitializeComponent();
        }
        public static string category;
        private void SearchOption_Click(object sender, EventArgs e)
        {
            List<Candy> result = new List<Candy>();
            string option = SearchComboBox.Text;
            switch (option)
            {
                case ("Пошук за ціною"):
                    category = "price";
                    DetailedSearch detailedSearch = new DetailedSearch();
                    detailedSearch.Show();
                    MessageBox.Show("Please type in the minimal wanted price of the candy");
                    break;
                case ("Пошук за найменуванням"):
                    category = "name";
                    detailedSearch = new DetailedSearch();
                    detailedSearch.Show();
                    MessageBox.Show("Please type in the name (or part of it) of the candy");
                    break;
                case ("Пошук за країною походження"):
                    category = "category";
                    detailedSearch = new DetailedSearch();
                    detailedSearch.Show();
                    MessageBox.Show("Please type in the country you are interested in");
                    break;
                default:
                    MessageBox.Show("Incorrect searching category");
                    this.Close();
                    break;
            }

            
        }
    }
}
