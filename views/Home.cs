using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalExecuter.lib;

namespace LocalExecuter.views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void createRunner_Click(object sender, EventArgs e)
        {
           string name = runnerName.Text;
           runner.CreateRunnerFile(name);
        }
    }
}
