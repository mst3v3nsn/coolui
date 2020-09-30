using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using IWshRuntimeLibrary;
using PowerShell = System.Management.Automation.PowerShell;
using System.IO;
using Microsoft.Win32;

namespace coolui
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties

        public string powershellexe = @"C:\Program Files\PowerShell\7\pwsh.exe";
        private string cmd = @"cmd.exe";
        private string _name;
        private string _path;
        private Image _icon;
        private string _access;
        private string _arguments;
        private string _extension;

        [Category("Custom Props")]
        public string AppName
        {
            get { return _name; }
            set 
            { 
                _name = value;
                string newValue = value.Substring(0, value.LastIndexOf("."));
                appButton.Text = newValue; 
            }
        }

        [Category("Custom Props")]
        public string AppPath
        {
            get { return _path; }
            set { _path = value;}
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; appButton.Image = value; }
        }

        [Category("Custom Props")]
        public string Access
        {
            get { return _access; }
            set { _access = value; }
        }

        [Category("Custom Props")]
        public string Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }

        [Category("Custom Props")]
        public string Arguments
        {
            get { return _arguments; }
            set { _arguments = value; }
        }
        #endregion

        private void appButton_Click(object sender, EventArgs e)
        {
            if (Extension == ".ps1")
            {
                Process.Start(powershellexe, String.Format(@"{0}\{1} {2}", AppPath, AppName, Arguments));
            }
            else if (Extension == ".exe")
            {
                Process.Start(cmd, String.Format(@"{0}\{1} {2}", AppPath, AppName, Arguments));
            }
            else if (Extension == ".lnk")
            {
                IWshShell3 wsh = new WshShellClass();
                IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}\{1}", AppPath, AppName));
                string targetPath = shortcut.TargetPath;
                string argumentString = shortcut.Arguments;
                Process.Start(String.Format(@"{0}", targetPath), argumentString);
            }
            else if (Extension == ".pdf" || Extension == ".docx" || Extension == ".doc")
            {
                RunCommandString();
            }
            else if (Extension == ".txt")
            {
                Process.Start(@"notepad.exe", String.Format(@"{0}\{1} {2}", AppPath, AppName, Arguments));
            }
        }

        private void RunCommandString()
        {
            object registeredExecutable = Registry.ClassesRoot.OpenSubKey(Extension).GetValue(null);

            object command = Registry.ClassesRoot
                .OpenSubKey(registeredExecutable.ToString())
                .OpenSubKey("shell")
                .OpenSubKey("Open")
                .OpenSubKey("command")
                .GetValue(null);

            var from = command.ToString().IndexOf("C:");
            var to = command.ToString().IndexOf(".exe", StringComparison.CurrentCultureIgnoreCase);
            var toArgs = command.ToString().IndexOf("/");
            var fromArgs = command.ToString().IndexOf("\"%1\"");
            string commandString = String.Format(@"{0}", command.ToString()[from..(to + 4)]);

            ProcessStartInfo info = new ProcessStartInfo();
            if (command.ToString()[(to + 4)..(fromArgs)].Contains("/") == true)
            {
                string extraArguments = command.ToString()[toArgs..(fromArgs + 4)];
                string args = extraArguments.Replace("\"%1\"", String.Format("\"{0}\\{1}\"", AppPath, AppName));
                info.FileName = commandString;
                info.Arguments = args;
            }
            else
            {
                string extraArguments = command.ToString()[(to + 5)..(fromArgs + 4)];
                string args = extraArguments.Replace("\"%1\"", String.Format("\"{0}\\{1}\"", AppPath, AppName));
                info.FileName = commandString;
                info.Arguments = args;
            }
            Process.Start(info);
        }

        private void appButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            if (Extension == ".lnk")
            {
                IWshShell3 wsh = new WshShellClass();
                IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}\{1}", AppPath, AppName));
                string targetPath = shortcut.TargetPath;
                string argumentString = shortcut.Arguments;
                toolTip.SetToolTip(this.appButton, String.Format(@"{0} {1}", targetPath, argumentString));
            }
            else
            {
                toolTip.SetToolTip(this.appButton, String.Format(@"{0}\{1}", AppPath, AppName));
            }
        }
    }
}
