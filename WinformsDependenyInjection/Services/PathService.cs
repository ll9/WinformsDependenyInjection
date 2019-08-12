using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsDependenyInjection.Services
{
    public class PathService : IPathService
    {
        public string GetPath()
        {
            return "Path";
        }
    }
}
