using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsDependenyInjection.Ninject;

namespace WinformsDependenyInjection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CompositionRoot.Wire(new ApplicationModule());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(CompositionRoot.Resolve<Form1>());
        }
    }
}
