using coolui.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Microsoft.Win32;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace coolui
{
    public partial class MPCMSForm : Form
    {
        Point lastPoint;
        public static List<FileInfo> Files { get; set; }
        public static List<string> appExts = new List<string> { ".exe", ".ps1", ".lnk" };
        public static List<string> docExts = new List<string> { ".pdf", ".docx", ".doc", ".lnk", ".txt" };
        public static string appsFolder = @"C:\MPCMS\Applications";
        public static string toolsFolder = @"C:\MPCMS\Tools";
        public static string docsFolder = @"C:\MPCMS\Docs";
        public static string powershellexe = @"C:\Program Files\PowerShell\7\pwsh.exe";
        public bool listSorted { get; set; }

        public MPCMSForm()
        {
            InitializeComponent();
            panelHighlight.Height = buttonApps.Height;
            panelHighlight.Top = buttonApps.Top;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonApps.Location.Y);
            panelSearch.Visible = false;
            buttonHideControl.Visible = false;
        }

        private void PopulateSettings()
        {
            SettingsItem[] settingItem = new SettingsItem[1];
            settingItem[0] = new SettingsItem();

            if ((string)Settings.Default["AppsPath"] == "")
            {
                settingItem[0].AppsPath = appsFolder;
                Settings.Default["AppsPath"] = appsFolder;
            }
            else
            {
                settingItem[0].AppsPath = (string)Settings.Default["AppsPath"];
            }

            if ((string)Settings.Default["ToolsPath"] == "")
            {
                settingItem[0].ToolsPath = toolsFolder;
                Settings.Default["ToolsPath"] = toolsFolder;
            }
            else
            {
                settingItem[0].ToolsPath = (string)Properties.Settings.Default["ToolsPath"];
            }

            if ((string)Settings.Default["DocsPath"] == "")
            {
                settingItem[0].DocsPath = docsFolder;
                Settings.Default["DocsPath"] = docsFolder;

            }
            else
            {
                settingItem[0].DocsPath = (string)Properties.Settings.Default["DocsPath"];
            }
            flowLayoutPanel.Controls.Add(settingItem[0]);
            Settings.Default.Save();
        }

        private void GetListOfFiles(string folder, List<string> extensions)
        {
            string[] fileStrings = Directory.GetFiles(String.Format(@"{0}", folder), "*.*", SearchOption.AllDirectories)
                .Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();

            List<FileInfo> files = new List<FileInfo>(fileStrings.Length + GetCountOfFilesInShortcut(fileStrings, extensions));

            foreach (string entry in fileStrings)
            {
                if (Path.GetExtension(entry) == ".lnk")
                {
                    IWshShell3 wsh = new WshShellClass();
                    IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}", entry));

                    string target = shortcut.TargetPath;

                    FileAttributes attr = System.IO.File.GetAttributes(target);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        string[] strings = Directory.GetFiles(target, "*.*", SearchOption.AllDirectories)
                            .Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();
                        foreach (string item in strings)
                        {
                            FileInfo fi1 = new FileInfo(item);
                            files.Add(fi1);
                        }
                    }
                    else
                    {
                        FileInfo fi2 = new FileInfo(entry);
                        files.Add(fi2);
                    }
                }
                else
                {
                    FileInfo fi = new FileInfo(entry);
                    files.Add(fi);
                }
            }
            Files = files;
        }

        private void PopulateFlowControlList()
        {
            ListItem[] listItems = new ListItem[Files.Count];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                if (Files[i].Extension == ".ps1")
                {
                    listItems[i].Icon = ConvertPathToBitMap(powershellexe);
                }
                else if (Files[i].Extension == ".exe")
                {
                    //listItems[i].Icon = Resources.exe_32px;
                    listItems[i].Icon = ConvertPathToBitMap(String.Format(@"{0}\{1}", Files[i].DirectoryName, Files[i].Name));
                }
                else if (Files[i].Extension == ".lnk")
                {
                    FileAttributes attr = System.IO.File.GetAttributes(String.Format(@"{0}\{1}", Files[i].DirectoryName, Files[i].Name));
                    if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
                    {
                        IWshShell3 wsh = new WshShellClass();
                        IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}\{1}", Files[i].DirectoryName, Files[i].Name));
                        string target = shortcut.TargetPath;

                        listItems[i].Icon = ConvertPathToBitMap(target);
                    }
                }
                else
                {
                    listItems[i].Icon = GetIconBitMap(Files[i].Extension);
                }

                listItems[i].Extension = Files[i].Extension;
                listItems[i].Access = Files[i].LastAccessTime.ToString();
                listItems[i].AppName = Files[i].Name;
                listItems[i].AppPath = Files[i].DirectoryName;

                flowLayoutPanel.Controls.Add(listItems[i]);
            }
            listSorted = false;
        }

        private Image GetIconBitMap(string extension)
        {
            object registeredExecutable = Registry.ClassesRoot.OpenSubKey(extension).GetValue(null);

            object command = Registry.ClassesRoot
                .OpenSubKey(registeredExecutable.ToString())
                .OpenSubKey("shell")
                .OpenSubKey("Open")
                .OpenSubKey("command").GetValue(null);

            var from = command.ToString().IndexOf("C:");
            var to = command.ToString().IndexOf(".exe", StringComparison.CurrentCultureIgnoreCase);

            string commandString = String.Format(@"{0}", command.ToString()[from..(to + 4)]);

            Icon ico = Icon.ExtractAssociatedIcon(String.Format(@"{0}", commandString));
            Bitmap newBitMap = new Bitmap(ico.ToBitmap(), new Size(32, 32));
            return newBitMap;
        }

        private Image ConvertPathToBitMap(string path)
        {
            Icon ico = System.Drawing.Icon.ExtractAssociatedIcon(String.Format(@"{0}", path));
            Bitmap newBitMap = new Bitmap(ico.ToBitmap(), new Size(32, 32));
            return newBitMap;
        }

        private int GetCountOfFilesInShortcut(string[] fileStrings, List<string> extensions)
        {
            int extraLength = 0;
            foreach (string entry in fileStrings)
            {
                if (Path.GetExtension(entry) == ".lnk")
                {
                    IWshShell3 wsh = new WshShellClass();
                    IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}", entry));

                    string target = shortcut.TargetPath;

                    FileAttributes attr = System.IO.File.GetAttributes(target);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        string[] strings = Directory.GetFiles(target, "*.*", SearchOption.AllDirectories)
                            .Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();
                        foreach (string item in strings)
                        {
                            extraLength++;
                        }
                    }
                }
            }
            return extraLength;
        }

        private void SearchList(string query)
        {
            flowLayoutPanel.Controls.Clear();

            List<FileInfo> filesFound = new List<FileInfo>(Files.FindAll(x => x.Name.ToLower().Contains(query.ToLower())));

            ListItem[] listItems = new ListItem[filesFound.Count];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                if (filesFound[i].Extension == ".ps1")
                {
                    listItems[i].Icon = ConvertPathToBitMap(powershellexe);
                }
                else if (filesFound[i].Extension == ".exe")
                {
                    //listItems[i].Icon = Resources.exe_32px;
                    listItems[i].Icon = ConvertPathToBitMap(String.Format(@"{0}\{1}", filesFound[i].DirectoryName, filesFound[i].Name));
                }
                else if (filesFound[i].Extension == ".lnk")
                {
                    FileAttributes attr = System.IO.File.GetAttributes(String.Format(@"{0}\{1}", filesFound[i].DirectoryName, filesFound[i].Name));
                    if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
                    {
                        IWshShell3 wsh = new WshShellClass();
                        IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}\{1}", filesFound[i].DirectoryName, filesFound[i].Name));
                        string target = shortcut.TargetPath;

                        listItems[i].Icon = ConvertPathToBitMap(target);
                    }
                }
                else
                {
                    listItems[i].Icon = GetIconBitMap(filesFound[i].Extension);
                }

                listItems[i].Extension = filesFound[i].Extension;
                listItems[i].Access = filesFound[i].LastAccessTime.ToString();
                listItems[i].AppName = filesFound[i].Name;
                listItems[i].AppPath = filesFound[i].DirectoryName;

                flowLayoutPanel.Controls.Add(listItems[i]);
            }
        }

        private void SortList()
        {
            flowLayoutPanel.Controls.Clear();
            List<FileInfo> filesFound = new List<FileInfo>(Files.OrderBy(x => x.Name));

            ListItem[] listItems = new ListItem[filesFound.Count];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                if (filesFound[i].Extension == ".ps1")
                {
                    listItems[i].Icon = ConvertPathToBitMap(powershellexe);
                }
                else if (filesFound[i].Extension == ".exe")
                {
                    //listItems[i].Icon = Resources.exe_32px;
                    listItems[i].Icon = ConvertPathToBitMap(String.Format(@"{0}\{1}", filesFound[i].DirectoryName, filesFound[i].Name));
                }
                else if (filesFound[i].Extension == ".lnk")
                {
                    FileAttributes attr = System.IO.File.GetAttributes(String.Format(@"{0}\{1}", filesFound[i].DirectoryName, filesFound[i].Name));
                    if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
                    {
                        IWshShell3 wsh = new WshShellClass();
                        IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}\{1}", filesFound[i].DirectoryName, filesFound[i].Name));
                        string target = shortcut.TargetPath;

                        listItems[i].Icon = ConvertPathToBitMap(target);
                    }
                }
                else
                {
                    listItems[i].Icon = GetIconBitMap(filesFound[i].Extension);
                }

                listItems[i].Extension = filesFound[i].Extension;
                listItems[i].Access = filesFound[i].LastAccessTime.ToString();
                listItems[i].AppName = filesFound[i].Name;
                listItems[i].AppPath = filesFound[i].DirectoryName;

                flowLayoutPanel.Controls.Add(listItems[i]);
            }
            listSorted = true;
        }

        private void buttonApps_Click(object sender, EventArgs e)
        {
            panelHighlight.Height = buttonApps.Height;
            panelHighlight.Top = buttonApps.Top;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonApps.Location.Y);
            panelSearch.Visible = true;
            buttonHideControl.Visible = true;

            flowLayoutPanel.Controls.Clear();
            GetListOfFiles(Settings.Default.AppsPath, appExts);
            PopulateFlowControlList();
        }

        private void buttonTools_Click(object sender, EventArgs e)
        {
            panelHighlight.Height = buttonTools.Height;
            panelHighlight.Top = buttonTools.Height;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonTools.Location.Y);
            panelSearch.Visible = true;
            buttonHideControl.Visible = true;

            flowLayoutPanel.Controls.Clear();
            GetListOfFiles(Settings.Default.ToolsPath, appExts);
            PopulateFlowControlList();
        }

        private void buttonDocs_Click(object sender, EventArgs e)
        {
            panelHighlight.Height = buttonDocs.Height;
            panelHighlight.Top = buttonDocs.Height;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonDocs.Location.Y);
            panelSearch.Visible = true;
            buttonHideControl.Visible = true;

            flowLayoutPanel.Controls.Clear();
            GetListOfFiles(Settings.Default.DocsPath, docExts);
            PopulateFlowControlList();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelHighlight.Top = buttonSettings.Height;
            panelHighlight.Height = buttonSettings.Height;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonSettings.Location.Y);
            panelSearch.Visible = false;
            buttonHideControl.Visible = false;

            flowLayoutPanel.Controls.Clear();
            PopulateSettings();
        }

        private void MPCMSForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MPCMSForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHideControl_Click(object sender, EventArgs e)
        {
            if (panelSearch.Visible == true) 
            {
                panelSearch.Visible = false;
                buttonHideControl.Image = Resources.sort_up_32px;
            }
            else
            {
                panelSearch.Visible = true;
                buttonHideControl.Image = Resources.sort_down_32px;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text) == false)
            {
                SearchList(this.textBoxSearch.Text);
            }
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                textBoxSearch.Text = "";
                flowLayoutPanel.Controls.Clear();
                PopulateFlowControlList();
            }
        }

        private void buttonSortAZ_Click(object sender, EventArgs e)
        {
            if (listSorted == false)
            {
                SortList();
            }
        }
    }
}
