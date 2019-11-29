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
    public partial class CommandSelect : Form
    {
        public CommandSelect()
        {
            InitializeComponent();
        }

        public Manager manager;

        private void AddButton_Click(object sender, EventArgs e)
        {
            CommandList.Items.Add(CommandInput.Text);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            XElement title = new XElement("title", NameInput.Text);
            XElement path = new XElement("path", "(command)");
            XElement enabled = new XElement("run", "True");

            XElement commands = new XElement("commands");
            foreach(string command in CommandList.Items)
            {
                if(command != "")
                    commands.Add(new XElement("command", command));
            }

            XElement action = new XElement("action", title, path, enabled, commands);
            action.SetAttributeValue("type", "command");
            action.SetAttributeValue("id", SaveData.generateId());

            SaveData.data.Root.Add(action);
            SaveData.saveData();

            manager.reloadList();

            Hide();
        }

        private void CommandInput_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CommandList.Items.Add(CommandInput.Text);
                CommandInput.Text = "";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(CommandList.SelectedIndex >= 0 && CommandList.SelectedIndex < CommandList.Items.Count)
                CommandList.Items.RemoveAt(CommandList.SelectedIndex);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if(CommandList.SelectedIndex > 0 && CommandList.SelectedIndex < CommandList.Items.Count) //cannot remove 0th item
            {
                string above = (string)CommandList.Items[CommandList.SelectedIndex - 1];
                string current = (string)CommandList.Items[CommandList.SelectedIndex];
                CommandList.Items[CommandList.SelectedIndex - 1] = current;
                CommandList.Items[CommandList.SelectedIndex] = above;
                CommandList.SelectedIndex--;
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if(CommandList.SelectedIndex >= 0 && CommandList.SelectedIndex < CommandList.Items.Count - 1)
            {
                string below = (string)CommandList.Items[CommandList.SelectedIndex + 1];
                string current = (string)CommandList.Items[CommandList.SelectedIndex];
                CommandList.Items[CommandList.SelectedIndex + 1] = current;
                CommandList.Items[CommandList.SelectedIndex] = below;
                CommandList.SelectedIndex++;
            }
        }
    }
}
