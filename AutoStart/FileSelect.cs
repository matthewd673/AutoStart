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
    public partial class FileSelect : Form
    {
        public FileSelect()
        {
            InitializeComponent();
        }

        public Manager manager;

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select File";
            openDialog.ValidateNames = true;

            if (openDialog.ShowDialog() == DialogResult.OK)
                PathInput.Text = openDialog.FileName;
        }

        private void HandlerBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select Handler";
            openDialog.ValidateNames = true;
            openDialog.Filter = "Executables (*.exe)|*.exe";

            if (openDialog.ShowDialog() == DialogResult.OK)
                HandlerInput.Text = openDialog.FileName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            XElement title = new XElement("title", NameInput.Text);
            XElement path = new XElement("path", PathInput.Text);
            XElement handler = new XElement("handler", HandlerInput.Text);
            XElement enabled = new XElement("run", "True");

            XElement action = new XElement("action", title, path, handler, enabled);
            action.SetAttributeValue("type", "file");
            action.SetAttributeValue("id", SaveData.generateId());

            SaveData.data.Root.Add(action);
            SaveData.saveData();

            manager.reloadList();

            Hide();
        }
    }
}
