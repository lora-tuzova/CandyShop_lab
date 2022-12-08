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
    public partial class DetailedSearch : Form
    {
        public DetailedSearch()
        {
            InitializeComponent();
        }

        private void CheckSearchDetail_Click(object sender, EventArgs e)
        {
            switch (Searching.category) {
                case ("price"):
                    try {
                        decimal mPrice = decimal.Parse(SearchDetail.Text);
                    }
                    catch { 
                        MessageBox.Show("Incorrect price value");
                        this.Close();
                    }
                    SearchConfirmation.Enabled = true;
                    break;
                case ("name"):
                    try {
                        string pName = SearchDetail.Text;
                    }
                    catch { 
                        MessageBox.Show("Incorrect name fragment");
                        this.Close();
                    }
                    SearchConfirmation.Enabled = true;
                    break;
                case ("category"):
                    try {
                        string pCountry = SearchDetail.Text;
                    }
                    catch { 
                        MessageBox.Show("Incorrect country name");
                        this.Close();
                    }
                    SearchConfirmation.Enabled = true;
                    LocalRB.Visible = true;
                    ImportedRB.Visible = true;
                    RadiobuttonsLabel.Visible = true;
                    break;
                default:
                    MessageBox.Show("Category error");
                    break;
            }
        }

        private void SearchConfirmation_Click(object sender, EventArgs e)
        {
            switch (Searching.category)
            {
                case ("price"):
                    decimal minPrice = decimal.Parse(SearchDetail.Text);
                    Search.SearchOnPrice(minPrice);
                    this.Close();
                    break;
                case ("name"):
                    string partName = SearchDetail.Text;
                    Search.SearchOnName(partName);
                    this.Close();
                    break;
                case ("category"):
                    string partCountry;
                    if (LocalRB.Checked)
                    {
                        partCountry = SearchDetail.Text;
                        Search.SearchOnCategory(true,partCountry);
                    }
                    else if (ImportedRB.Checked)
                    {
                        partCountry = SearchDetail.Text;
                        Search.SearchOnCategory(false, partCountry);
                    }
                    else { MessageBox.Show("Radiobutton error"); }
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Category error");
                    break;
            }
        }
    }
}
