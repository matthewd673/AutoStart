using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoStart
{
    public partial class LogViewer : Form
    {
        public LogViewer()
        {
            InitializeComponent();
        }

        string[] logContents;

        private void LogViewer_Load(object sender, EventArgs e)
        {
            logContents = new string[0];

            if (File.Exists("log.txt"))
            {
                logContents = File.ReadAllLines("log.txt");
            }

            foreach(string item in logContents)
            {
                LogList.Items.Add(item);
            }

        }

        private void LogList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetailView.Text = logContents[LogList.SelectedIndex];
        }
    }
}
