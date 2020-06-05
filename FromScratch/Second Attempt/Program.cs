using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Second_Attempt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Directory.Exists("Data\\Characters"))
                Directory.CreateDirectory("Data\\Characters");
            if (!Directory.Exists("Data\\Weapons"))
                Directory.CreateDirectory("Data\\Weapons");
            if (!Directory.Exists("Data\\Shields"))
                Directory.CreateDirectory("Data\\Shields");
            if (!Directory.Exists("Data\\Armor"))
                Directory.CreateDirectory("Data\\Armor");
            if (!Directory.Exists("Data\\Spells"))
                Directory.CreateDirectory("Data\\Spells");
            if (!Directory.Exists("Data\\Enchantments"))
                Directory.CreateDirectory("Data\\Enchantments");
            if (!Directory.Exists("Data\\Loot"))
                Directory.CreateDirectory("Data\\Loot");
            if (!Directory.Exists("Data\\Item"))
                Directory.CreateDirectory("Data\\Items");
            

            EnchantmentLogic.EnchantmentUtilities.startup();

            Application.Run(new StartupScreen ());
        }
    }
}
