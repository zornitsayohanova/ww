using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopApp.Data;

namespace WindowsFormsApp2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (ShopContext context = new ShopContext())
            {
                DbInitializer.Initialize(context);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
