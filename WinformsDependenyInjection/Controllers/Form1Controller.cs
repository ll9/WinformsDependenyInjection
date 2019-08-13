using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsDependenyInjection.Services;

namespace WinformsDependenyInjection.Controllers
{
    public class Form1Controller
    {
        private readonly IPathService _pathService;

        public Form1Controller(IPathService pathService)
        {
            _pathService = pathService;
        }

        public string GetPath()
        {
            return _pathService.GetPath();
        }
    }
}
