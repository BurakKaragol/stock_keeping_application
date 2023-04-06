using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_keeping_application
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            // For Testing the specified forms on start uncomment the required line below
            //Application.Run(new ActiveStockStatus());
            //Application.Run(new AmountControlForm());
            //Application.Run(new MovementHistoryForm());
            Application.Run(new MoveStockForm());
            //Application.Run(new PrepareProductForm());
            //Application.Run(new ProducePartForm());
            //Application.Run(new RecipeControlForm());
            //Application.Run(new SettingsForm());
        }
    }
}
