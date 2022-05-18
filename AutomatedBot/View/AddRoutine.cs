using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedBot.View
{
    public partial class AddRoutine : Form
    {
        public AddRoutine()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text, "DEVELOPER", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Done(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
