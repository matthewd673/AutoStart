using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AutoStart
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

            //same as resize code
            ItemPanel.Width = Width;
            ItemPanel.Height = Height - ItemPanel.Location.Y;

            reloadList();

        }

        public void reloadList()
        {
            SaveData.loadData();

            ItemPanel.Controls.Clear();

            foreach (var action in SaveData.data.Descendants("action"))
            {
                ExecutionItem newItem = new ExecutionItem();
                string title = "";
                string path = "";
                bool enabled = false;
                string handler = "";

                string type = (string)action.Attribute("type");
                foreach (var titleProp in action.Descendants("title"))
                    title = titleProp.Value;
                foreach (var pathProp in action.Descendants("path"))
                    path = pathProp.Value;
                foreach (var runProp in action.Descendants("run"))
                {
                    if (runProp.Value == "True")
                        enabled = true;
                }
                foreach (var handlerProp in action.Descendants("handler"))
                    handler = handlerProp.Value;

                if (path.Contains("\\"))
                    path = path.Split('\\')[path.Split('\\').Count() - 1];

                if (handler.Contains("\\"))
                    handler = handler.Split('\\')[handler.Split('\\').Count() - 1];

                if (handler != "")
                {
                    if (handler == "(default)")
                        handler = "default"; //so it looks right
                    path += " (" + handler + ")";
                }

                newItem.SetProperties(title, path, enabled, type);
                newItem.manager = this;
                newItem.id = (string)action.Attribute("id");

                ItemPanel.Controls.Add(newItem);

            }
        }

        private void Manager_Resize(object sender, EventArgs e)
        {
            ItemPanel.Width = Width;
            ItemPanel.Height = Height - ItemPanel.Location.Y;

            foreach(ExecutionItem item in ItemPanel.Controls)
            {
                item.Width = ItemPanel.Width - 40;
            }

        }

        private void NewCommand_Click(object sender, EventArgs e)
        {
            CommandSelect newCom = new CommandSelect();
            newCom.manager = this;
            newCom.Show();
        }

        private void NewProgram_Click(object sender, EventArgs e)
        {
            ProgramSelect newProg = new ProgramSelect();
            newProg.manager = this;
            newProg.Show();
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            FileSelect newFile = new FileSelect();
            newFile.manager = this;
            newFile.Show();
        }

        private void AddDropdown_ButtonClick(object sender, EventArgs e)
        {
            launchEditor(AddDropdown.Text.ToLower());
        }

        void launchEditor(string type)
        {
            switch(type)
            {
                case "program":
                    ProgramSelect newProg = new ProgramSelect();
                    newProg.manager = this;
                    newProg.Show();
                    break;
                case "command":
                    CommandSelect newCom = new CommandSelect();
                    newCom.manager = this;
                    newCom.Show();
                    break;
                case "file":
                    FileSelect newFile = new FileSelect();
                    newFile.manager = this;
                    newFile.Show();
                    break;
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Execute exe = new Execute();
            exe.Show();
        }

        private void AddProgramItem_Click(object sender, EventArgs e)
        {
            AddDropdown.Text = AddProgramItem.Text;
            launchEditor("program");
        }

        private void AddCommandItem_Click(object sender, EventArgs e)
        {
            AddDropdown.Text = AddCommandItem.Text;
            launchEditor("command");
        }

        private void AddFileItem_Click(object sender, EventArgs e)
        {
            AddDropdown.Text = AddFileItem.Text;
            launchEditor("file");
        }

        private void XmlButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("launch.xml"))
                Process.Start("launch.xml");
            else
                MessageBox.Show("The launch file (launch.xml) does not exist. It will be created once you add or modify an action.", "Cannot view XML");
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
