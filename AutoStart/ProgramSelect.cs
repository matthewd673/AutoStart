using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AutoStart
{
    public partial class ProgramSelect : Form
    {
        public ProgramSelect()
        {
            InitializeComponent();
        }

        public Manager manager;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            XElement title = new XElement("title", NameInput.Text);
            XElement path = new XElement("path", PathInput.Text);
            XElement enabled = new XElement("run", "True");

            XElement action = new XElement("action", title, path, enabled);
            action.SetAttributeValue("type", "program");
            action.SetAttributeValue("id", SaveData.generateId());

            SaveData.data.Root.Add(action);
            SaveData.saveData();

            manager.reloadList();            

            Hide();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select Program";
            openDialog.ValidateNames = true;
            openDialog.Filter = "Executables (*.exe)|*.exe";

            if (openDialog.ShowDialog() == DialogResult.OK)
                PathInput.Text = openDialog.FileName;

        }
    }
}
