using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsDependenyInjection.Services;

namespace WinformsDependenyInjection.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IPathService)).To(typeof(PathService));
        }
    }
}
