using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsDependenyInjection.Controllers;
using WinformsDependenyInjection.Ninject;
using WinformsDependenyInjection.Services;

namespace WinformsDependenyInjection
{
    public partial class Form1 : Form
    {
        private readonly Form1Controller _controller;
        private readonly Models.View viewModel;

        public Form1(Form1Controller controller, Models.View viewModel)
        {
            InitializeComponent();
            this._controller = controller;
            this.viewModel = viewModel;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_controller.GetPath());
            MessageBox.Show(viewModel.Name);
        }
    }
}
