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
    public partial class Execute : Form
    {
        public Execute()
        {
            InitializeComponent();
        }

        Timer closeTimer = new Timer();

        private void Execute_Load(object sender, EventArgs e)
        {
            SaveData.loadData();

            int maxActions = SaveData.data.Descendants("action").Count();

            ExecuteProgress.Maximum = maxActions;
            ExecuteProgress.Value = 0;

            File.WriteAllText("log.txt", "Begin execution (" + DateTime.Now + ")" + Environment.NewLine);

            foreach (var action in SaveData.data.Descendants("action"))
            {
                ExecuteProgress.Value++;
                ExecuteText.Text = "Executing... " + ExecuteProgress.Value.ToString() + "/" + ExecuteProgress.Maximum.ToString();

                bool run = false;
                foreach(var enabledProp in action.Descendants("run"))
                {
                    if (enabledProp.Value == "True")
                        run = true;
                    else
                        log("Skipping disabled action " + (string)action.Attribute("id"));
                }

                if (run)
                {
                    if ((string)action.Attribute("type") == "program")
                    {
                        string path = "";

                        foreach (var pathProp in action.Descendants("path"))
                            path = pathProp.Value;

                        if (safePath(path))
                            Process.Start(path);
                        else
                            log("Failed to execute program at path " + path);
                    }
                    else if ((string)action.Attribute("type") == "command")
                    {
                        List<string> commands = new List<string>();

                        foreach (var commandProp in action.Descendants("command"))
                        {
                            commands.Add(commandProp.Value);
                        }

                        Process shellProcess = new Process();
                        shellProcess.StartInfo.FileName = "cmd.exe";
                        shellProcess.StartInfo.RedirectStandardInput = true;
                        shellProcess.StartInfo.UseShellExecute = false;

                        shellProcess.Start();

                        using (StreamWriter input = shellProcess.StandardInput)
                        {
                            if(input.BaseStream.CanWrite)
                            {
                                foreach(string command in commands)
                                {
                                    input.WriteLine(command);
                                }
                            }
                        }

                    }
                    else if ((string)action.Attribute("type") == "file")
                    {
                        string path = "";

                        foreach (var pathProp in action.Descendants("path"))
                            path = pathProp.Value;

                        if (safePath(path))
                        {
                            string handler = "(default)";

                            foreach (var handlerProp in action.Descendants("handler"))
                                handler = handlerProp.Value;

                            if(handler == "(default)")
                                Process.Start(path);
                            else
                            {
                                Process.Start(handler, path);
                            }
                        }
                        else
                            log("Failed to load file at path " + path);

                    }
                    else
                    {
                        log("Could not execute action with unrecognized type (check launch.xml to troubleshoot)");
                    }
                }
            }

            log("Complete (" + DateTime.Now + ")");

            if (File.ReadAllLines("log.txt").Length > 2) //something noteworthy happened
            {
                ExecuteText.Font = new Font(ExecuteText.Font, FontStyle.Italic);
                ExecuteText.Text = "Completed " + maxActions.ToString() + " with messages (click to view log)";
            }
            else
            {
                ExecuteText.Text = "Completed " + maxActions.ToString() + " (click to view log)";
            }

            if (Properties.Settings.Default.AutoCloseDialog)
            {
                closeTimer.Interval = 3000;
                closeTimer.Start();
                closeTimer.Tick += CloseTimer_Tick;
            }

        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            Hide();
        }

        void log(string text)
        {
            File.AppendAllText("log.txt", text + Environment.NewLine);
        }

        bool safePath(string path)
        {
            return (path != "" && File.Exists(path));
        }

        private void ExecuteText_Click(object sender, EventArgs e)
        {
            LogViewer viewer = new LogViewer();
            viewer.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
