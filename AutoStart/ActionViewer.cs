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
    public partial class ActionViewer : Form
    {
        public ActionViewer()
        {
            InitializeComponent();
        }

        public string id;

        private void ActionViewer_Load(object sender, EventArgs e)
        {

            foreach(var action in SaveData.data.Descendants("action"))
            {
                if((string)action.Attribute("id") == id)
                {
                    append("id: " + (string)action.Attribute("id"));
                    append("type: " + (string)action.Attribute("type"));
                    foreach (var prop in action.Descendants())
                    {
                        if(prop.Name != "commands")
                            append(prop.Name + ": " + prop.Value);
                        if (prop.Name == "title")
                            Text = "Action Viewer - " + prop.Value;
                    }
                }
                
            }

        }

        void append(string text)
        {
            Viewer.AppendText(text + Environment.NewLine);
        }

    }
}
