using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanaban501app
{
    public delegate void Notify();

    internal static class Kanaban501
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GoalsDataBase db = new GoalsDataBase();
            Controller c = new Controller(db);
            Form1 f = new Form1(db);
            f.UpdateControllersData = c.InputHandler;
            c.UpdateTheView = f.HandelUpdateFromController;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(f);
        }
    }
}
