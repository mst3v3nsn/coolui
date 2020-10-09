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
            // initialize ListItem
            InitializeComponent();
        }

        private void ListItem_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #region Properties

        // path to executable of powershell 7 installed on system
        public string powershellexe = @"C:\Program Files\PowerShell\7\pwsh.exe";
        //private string cmd = @"cmd.exe";
        // string to represent name of file
        private string _name;
        // string to represent path
        private string _path;
        // image to represent the icon assocaited with file
        private Image _icon;
        // string that represents the last time a file was accessed
        private string _access;
        // string that represents the arguments assocatied for running a particular process/file
        private string _arguments;
        // string that represents the extension of a particular file
        private string _extension;

        [Category("Custom Props")]
        public string AppName
        {
            // get appName
            get { return _name; }
            // set appName
            set 
            { 
                _name = value;
                // strip extension from variable displayed within UI
                string newValue = value.Substring(0, value.LastIndexOf("."));
                // set UI property
                appButton.Text = newValue; 
            }
        }

        [Category("Custom Props")]
        public string AppPath
        {
            // get path
            get { return _path; }
            // set path
            set { _path = value;}
        }

        [Category("Custom Props")]
        public Image Icon
        {
            // get icon
            get { return _icon; }
            // set icon
            set { _icon = value; appButton.Image = value; }
        }

        [Category("Custom Props")]
        public string Access
        {
            // get access time
            get { return _access; }
            // set access time
            set { _access = value; }
        }

        [Category("Custom Props")]
        public string Extension
        {
            // get extension
            get { return _extension; }
            // set extension
            set { _extension = value; }
        }

        [Category("Custom Props")]
        public string Arguments
        {
            // get arguments
            get { return _arguments; }
            // set arguments
            set { _arguments = value; }
        }
        #endregion

        private void appButton_Click(object sender, EventArgs e)
        {
            // check extension
            if (Extension == ".ps1")
            {
                // format path for .ps1 scriptfile
                string scriptFile = String.Format(@"{0}\{1}", AppPath, AppName);
                
                // start process with create ProcessStartInfo object that was created and returned
                Process.Start(CreateStartProcessObject(powershellexe, $"-NoProfile -ExecutionPolicy unrestricted \"{scriptFile}\""));
            }
            else if (Extension == ".exe")
            {
                // start process with create ProcessStartInfo object that was created and returned
                Process.Start(CreateStartProcessObject(String.Format(@"{0}\{1}", AppPath, AppName), Arguments));
            }
            else if (Extension == ".lnk")
            {
                // create new IWshShell3 object
                IWshShell3 wsh = new WshShellClass();
                // create new shortcut object using specified path to executable of .lnk file extension
                IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}\{1}", AppPath, AppName));

                // start process with create ProcessStartInfo object that was created and returned
                Process.Start(CreateStartProcessObject(shortcut.TargetPath, shortcut.Arguments));
            }
            else if (Extension == ".pdf" || Extension == ".docx" || Extension == ".doc" || Extension == ".xlsx")
            {
                // start process with details found upon registry lookup
                RunCommandString();
            }
            else if (Extension == ".txt")
            {
                // start process with create ProcessStartInfo object that was created and returned
                Process.Start(CreateStartProcessObject("notepad.exe", String.Format(@"{0}\{1} {2}", AppPath, AppName, Arguments)));
            }
        }

        private ProcessStartInfo CreateStartProcessObject(string fileName, string arguments, string workingDirectory = @"C:\")
        {
            // create new ProcessStartInfo object and set input details
            var startInfo = new ProcessStartInfo()
            {
                FileName = fileName,
                Arguments = arguments,
                WorkingDirectory = workingDirectory,
                UseShellExecute = false
            };
            // return ProcessStartInfo object
            return startInfo;
        }

        private void RunCommandString()
        {
            // get root windows registry location for extension
            object registeredExecutable = Registry.ClassesRoot.OpenSubKey(Extension).GetValue(null);

            // get command string for executable linked to extension
            object command = Registry.ClassesRoot
                .OpenSubKey(registeredExecutable.ToString())
                .OpenSubKey("shell")
                .OpenSubKey("Open")
                .OpenSubKey("command")
                .GetValue(null);

            // process string linked to command of extension and trim for path of executable and arguments (if present)
            var from = command.ToString().IndexOf("C:");
            var to = command.ToString().IndexOf(".exe", StringComparison.CurrentCultureIgnoreCase);
            var toArgs = command.ToString().IndexOf("/");
            var fromArgs = command.ToString().IndexOf("\"%1\"");
            string commandString = String.Format(@"{0}", command.ToString()[from..(to + 4)]);
            
            // create new ProcessStartInfo object
            ProcessStartInfo info = new ProcessStartInfo();
            // check if argument present in command string
            if (command.ToString()[(to + 4)..(fromArgs)].Contains("/") == true)
            {
                // format command and argument strings then set into ProcessStartInfo object
                string extraArguments = command.ToString()[toArgs..(fromArgs + 4)];
                string args = extraArguments.Replace("\"%1\"", String.Format("\"{0}\\{1}\"", AppPath, AppName));
                info.FileName = commandString;
                info.Arguments = args;
            }
            else
            {
                // format command and argument strings then set into ProcessStartInfo object
                string extraArguments = command.ToString()[(to + 5)..(fromArgs + 4)];
                string args = extraArguments.Replace("\"%1\"", String.Format("\"{0}\\{1}\"", AppPath, AppName));
                info.FileName = commandString;
                info.Arguments = args;
            }

            // start process with ProcessStartInfo object that was created
            Process.Start(info);
        }

        private void appButton_MouseHover(object sender, EventArgs e)
        {
            // create new ToolTip object
            ToolTip toolTip = new ToolTip();
            // check if file extension represents a shortcut
            if (Extension == ".lnk")
            {
                // create new IWshShell3 object
                IWshShell3 wsh = new WshShellClass();
                // create new shortcut object using specified path to executable of .lnk file extension
                IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}\{1}", AppPath, AppName));
                
                // set ToolTip object details using shortcut attributes
                toolTip.SetToolTip(this.appButton, 
                    String.Format(@"{0} {1}" + 
                    Environment.NewLine +
                    Environment.NewLine +
                    "{2}", shortcut.TargetPath, shortcut.Arguments, shortcut.Description));
            }
            else
            {
                // set tooltip of regular file to path of executable
                toolTip.SetToolTip(this.appButton, String.Format(@"{0}\{1}", AppPath, AppName));
            }
        }
    }
}
