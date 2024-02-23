using State.ExemploIdeal;
using State.ExemploNaoIdeal;
using System;
using System.Windows.Forms;

namespace State
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmExemploNaoIdeal());
            //Application.Run(new frmExemploIdeal());
        }
    }
}
