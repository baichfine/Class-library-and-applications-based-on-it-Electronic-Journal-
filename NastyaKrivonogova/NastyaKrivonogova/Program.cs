using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NastyaKrivonogova
{
    static class Program
    {
        public static Form1 Form1;
        public static Form2 Form2;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.Form1 = new Form1(true);
            Program.Form2 = new Form2();
            Application.Run(Program.Form2);
        }
    }
}
