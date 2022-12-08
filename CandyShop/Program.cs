using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyShop
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CandyShopSystem sys_obj = new CandyShopSystem();
            sys_obj.CandyCatalog = new List<Candy>();
            Form1.candySystem = sys_obj;
            Application.Run(new Form1());
        }
    }
}
