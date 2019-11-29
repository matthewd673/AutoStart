using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStart
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            CloseDialogCheck.Checked = Properties.Settings.Default.AutoCloseDialog;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoCloseDialog = CloseDialogCheck.Checked;
            Properties.Settings.Default.Save();

            Hide();
        }
    }
}
