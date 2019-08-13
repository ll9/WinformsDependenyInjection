using Ninject;
using Ninject.Parameters;
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

            var view = CompositionRoot.Resolve<Form1>(new ConstructorArgument("viewModel", new Models.View { Name = "Hans" }));
            Application.Run(view);
        }
    }
}
