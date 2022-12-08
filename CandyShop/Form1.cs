using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Converters;

namespace CandyShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static CandyShopSystem candySystem;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Candy example = Form1.candySystem.AddCandy();
            dataGridView1.Rows.Add(Form1.candySystem.CandyCatalog.Count(), example.name, example.price, example.packageDate, example.manufacturer.name, example.manufacturer.country);

        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            Deletion deletion = new Deletion();
            if (deletion.ShowDialog() == DialogResult.OK && Deletion.delIndex >= 0)
                dataGridView1.Rows.RemoveAt(Deletion.delIndex);
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            Editing editing = new Editing();
            if (editing.ShowDialog() == DialogResult.OK && Editing.editIndex >= 0)
                dataGridView1.Rows[Editing.editIndex].SetValues(Editing.editIndex + 1, candySystem.CandyCatalog[Editing.editIndex].name, candySystem.CandyCatalog[Editing.editIndex].price, candySystem.CandyCatalog[Editing.editIndex].packageDate, candySystem.CandyCatalog[Editing.editIndex].manufacturer.name, candySystem.CandyCatalog[Editing.editIndex].manufacturer.country);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Searching search = new Searching();
            search.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Helper.LoadToFile(candySystem.CandyCatalog);
        }

        private void FillGrid_Click(object sender, EventArgs e)
        {
            List<Candy> tempList = Helper.LoadFromFile();
            for (int i = 0; i < tempList.Count; i++)
            {
                candySystem.CandyCatalog.Add(tempList[i]);
                dataGridView1.Rows.Add(candySystem.CandyCatalog.Count(), tempList[i].name, tempList[i].price, tempList[i].packageDate, tempList[i].manufacturer.name, tempList[i].manufacturer.country);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }
    }

    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            base.DateTimeFormat = "dd/MM/yyyy";
        }
    }


    public class CandyShopSystem
    {
        public List<Candy> CandyCatalog;

        public Candy AddCandy()
        {
            Addition addition = new Addition();
            if (addition.ShowDialog() == DialogResult.OK)
            {
                Candy example = Form1.candySystem.CandyCatalog[Form1.candySystem.CandyCatalog.Count() - 1];
                return example;
            }
            else return null;
        }
        public void DeleteCandy()
        {
            if (Deletion.delIndex >= 0)
                Form1.candySystem.CandyCatalog.Remove(Form1.candySystem.CandyCatalog[Deletion.delIndex]);
            else MessageBox.Show("No candy with this name found");
        }
        public void EditCandy(Candy sample)
        {
            if (Editing.editIndex >= 0)
                Form1.candySystem.CandyCatalog[Editing.editIndex] = sample;
            else MessageBox.Show("No candy with this name found");
        }
        public void SerializeResult() { }
    }


    public class Candy
    {
        public string name { get; set; }
        public decimal price { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime packageDate { get; set; }
        public Manufacturer manufacturer { get; set; }


        public Candy(string name, decimal price, DateTime packageDate, Manufacturer manufacturer)
        {
            this.name = name;
            this.price = price;
            this.packageDate = packageDate;
            this.manufacturer = manufacturer;
        }
    }

    public class Manufacturer
    {
        public string name;
        public string country;
    }



    public class Search 
    {
        public static List<Candy> SearchOnPrice(decimal minPrice)
        {
            List<Candy> results = new List<Candy>();
            IEnumerable results1 = (from res in Form1.candySystem.CandyCatalog where res.price >= minPrice select res);
            foreach (Candy res in results1)
                results.Add(res);
                string list = "";
                for (int j = 0; j < results.Count; j++)
                {
                    list += JsonConvert.SerializeObject(results[j]);
                    list += "\n";
                }
                MessageBox.Show(list);
            return results;
        }
        public static List<Candy> SearchOnCategory(bool category, string country) { 
            List<Candy> results = new List<Candy>();
            IEnumerable results1 = from res in Form1.candySystem.CandyCatalog where ((res.manufacturer.country == country) == category) select res;
            foreach (Candy res in results1)
                results.Add(res);
            string list = "";
            for (int j = 0; j < results.Count; j++)
            {
                list += JsonConvert.SerializeObject(results[j]);
                list += "\n";
            }
            MessageBox.Show(list);
            return results;
        }
        public static List<Candy> SearchOnName(string name) {
            List<Candy> results = new List<Candy>();
            IEnumerable results1 = from res in Form1.candySystem.CandyCatalog where (res.name.Contains(name)) select res;
            foreach (Candy res in results1)
                results.Add(res);
            string list = "";
            for (int j = 0; j < results.Count; j++)
            {
                list += JsonConvert.SerializeObject(results[j]);
                list += "\n";
            }
            MessageBox.Show(list);
            return results;
        }
        }


        class Helper : Form1
        {
            public static bool CheckOccurence(string name)
            {
                bool occurence = false;
                for (int i = 0; i < candySystem.CandyCatalog.Count(); i++)
                    if (candySystem.CandyCatalog[i].name == name)
                        occurence = true;
                return occurence;
            }
            
            public static void LoadToFile(List<Candy> candyCatalog) {

            StreamWriter streamWriter = new StreamWriter("C:\\Users\\Admin\\source\\repos\\CandyShop_lab\\Candy_results.txt", false);
            string buffer;
            for (int i=0; i < candyCatalog.Count(); i++)
            {
                buffer = JsonConvert.SerializeObject(candyCatalog[i]);
                streamWriter.Write(buffer);
                streamWriter.WriteLine();
            }
            streamWriter.Close();
        }
            public static List<Candy> LoadFromFile() {            
                List<Candy> listCandy = JsonConvert.DeserializeObject<List<Candy>>(File.ReadAllText("C:\\Users\\Admin\\source\\repos\\CandyShop_lab\\Candy_journal.txt"));
            return listCandy;
            }
        }
    }