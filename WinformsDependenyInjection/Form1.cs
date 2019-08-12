using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsDependenyInjection.Ninject;
using WinformsDependenyInjection.Services;

namespace WinformsDependenyInjection
{
    public partial class Form1 : Form
    {
        private readonly IPathService _pathService;

        public Form1(IPathService pathService)
        {
            InitializeComponent();
            _pathService = pathService;
            var path = _pathService.GetPath();

            var z = CompositionRoot.Resolve<Form1>();
            z.ShowDialog();
        }
    }
}
