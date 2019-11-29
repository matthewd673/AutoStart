using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AutoStart
{
    public partial class ExecutionItem : UserControl
    {
        public ExecutionItem()
        {
            InitializeComponent();
        }

        public Manager manager;
        public string id;

        private void ExecutionItem_Load(object sender, EventArgs e)
        {

        }

        public void SetProperties(string title, string path, bool enabled, string type)
        {
            TitleLabel.Text = title;
            PathLabel.Text = path;
            EnabledCheck.Checked = enabled;

            switch(type)
            {
                case "program":
                    Icon.Image = IconList.Images[1];
                    break;
                case "command":
                    Icon.Image = IconList.Images[2];
                    break;
                case "file":
                    Icon.Image = IconList.Images[3];
                    break;
                default:
                    Icon.Image = IconList.Images[0];
                    break;
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this action?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //delet
                XElement removeAction = new XElement("artifact");
                foreach(var action in SaveData.data.Descendants("action"))
                {
                    if ((string)action.Attribute("id") == id)
                        removeAction = action;
                }
                removeAction.Remove();
                SaveData.saveData();
                manager.reloadList();
            }
        }

        private void EnabledCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveData.data != null)
            {
                string state = "True";
                if (!EnabledCheck.Checked)
                    state = "False";

                foreach (var action in SaveData.data.Descendants("action"))
                {
                    if ((string)action.Attribute("id") == id)
                    {
                        foreach (var enabledProp in action.Descendants("run"))
                        {
                            enabledProp.Value = state;
                        }
                    }
                }

                SaveData.saveData();
            }

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            ActionViewer viewer = new ActionViewer();
            viewer.id = id;
            viewer.Show();
        }
        
    }
}
