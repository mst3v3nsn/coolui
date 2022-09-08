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
using System.ComponentModel.Composition.Registration;

namespace coolui
{
    public partial class NewForm : Form
    {
        public BackgroundWorker backgroundWorker1;

        // point to track mouse movement
        Point lastPoint;
        // getter and setter for FileInfo List Files
        public static List<FileInfo> Files { get; set; }
        // extension predicate list for Apps
        public static List<string> appExts = new List<string> { ".exe", ".ps1", ".lnk" };
        // extension predicate list for Tools
        public static List<string> toolExts = new List<string> { ".exe", ".ps1", ".lnk" };
        // entension predicate list for VMs
        public static List<string> vmExts = new List<string> { ".lnk" };
        // entension predicate list for Docs
        public static List<string> docExts = new List<string> { ".pdf", ".docx", ".doc", ".lnk", ".txt" , ".xlsx", ".vsd"};
        // default apps folder
        public static string appsFolder = @"C:\Test\Applications";
        // default tools folder
        public static string toolsFolder = @"C:\Test\Tools";
        // default VMs folder
        public static string vmsFolder = @"C:\Test\VMs";
        // default docs folder
        public static string docsFolder = @"C:\Test\Docs";
        // path to powershell 7 executable installed on system
        public static string powershellexe = @"C:\Program Files\PowerShell\7\pwsh.exe";
        // list sorted control variable
        public bool listSorted { get; set; }
        // hide panel control variable
        public bool hidePanel { get; set; }
        public static bool appButtonSelected { get; set; }
        public bool appSelected { get; set; }
        public bool toolsSelected { get; set; }
        public bool vmSelected { get; set; }
        public bool docSelected { get; set; }
        public bool helpClicked { get; set; }

        public NewForm()
        {
            InitializeComponent();

            panelHighlight.Height = buttonApps.Height;
            panelHighlight.Top = buttonApps.Top;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonApps.Location.Y);
            panelSearch.Visible = false;
            buttonHideControl.Visible = false;

            appSelected = false;
            toolsSelected = false;
            vmSelected = false;
            docSelected = false;
            helpClicked = false;
        }

        private void PopulateSettings()
        {
            // Create SettingsItem array of size 1
            SettingsItem[] settingItem = new SettingsItem[1];
            // Create new SettingsItem object
            settingItem[0] = new SettingsItem();

            // check if saved settings exist for AppsPath
            if ((string)Settings.Default.AppsPath == "")
            {
                // set AppsPath and set saved setting for AppsPath with default
                settingItem[0].AppsPath = appsFolder;
                Settings.Default.AppsPath = appsFolder;
            }
            else
            {
                // set AppsPath with saved settings
                settingItem[0].AppsPath = (string)Settings.Default.AppsPath;
            }

            // check if saved settings exist for ToolsPath
            if ((string)Settings.Default.ToolsPath == "")
            {
                // set ToolsPath and set saved setting for ToolsPath with default
                settingItem[0].ToolsPath = toolsFolder;
                Settings.Default.ToolsPath = toolsFolder;
            }
            else
            {
                // set ToolsPath with saved settings
                settingItem[0].ToolsPath = (string)Settings.Default.ToolsPath;
            }

            // check if saved settings exist for VMsPath
            if ((string)Settings.Default.VMsPath == "")
            {
                // set ToolsPath and set saved setting for VMsPath with default
                settingItem[0].VMsPath = vmsFolder;
                Settings.Default.VMsPath = vmsFolder;
            }
            else
            {
                // set VMssPath with saved settings
                settingItem[0].VMsPath = (string)Settings.Default.VMsPath;
            }

            // check if saved settings exist for DocsPath
            if ((string)Settings.Default.DocsPath == "")
            {
                // set DocsPath and set saved setting for DocsPath with default
                settingItem[0].DocsPath = docsFolder;
                Settings.Default.DocsPath = docsFolder;

            }
            else
            {
                // set DocsPath with saved settings
                settingItem[0].DocsPath = (string)Settings.Default.DocsPath;
            }

            // check if saved settings exist for TargetConfig
            if ((string)Settings.Default.TargetConfig == "")
            {
                // set DocsPath and set saved setting for DocsPath with default
                Settings.Default.TargetConfig = "lab";

            }
            else
            {
                // set DocsPath with saved settings
                settingItem[0].TargetConfig = (string)Settings.Default.TargetConfig;
            }

            // add settings object to flow layout panel
            flowLayoutPanel.Controls.Add(settingItem[0]);
            // save settings
            Settings.Default.Save();
        }

        private void GetListOfFiles(string folder, List<string> extensions)
        {
            // return all files matching extensions predicate within all directories of folder specified
            string[] fileStrings = Directory.GetFiles(String.Format(@"{0}", folder), "*.*", SearchOption.AllDirectories)
                .Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();

            // Create FileInfo List based on size of files within specified directory
            List<FileInfo> files = new List<FileInfo>(fileStrings.Length + GetCountOfFilesInShortcut(fileStrings, extensions));

            // iterate through fileStrings array
            foreach (string entry in fileStrings)
            {
                if (Path.GetExtension(entry) == ".lnk")
                {
                    // initialize new IWshShell3 object
                    IWshShell3 wsh = new WshShellClass();
                    // create shortcut object
                    IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}", entry));

                    // create FileAttributes object for shortcut
                    FileAttributes attr = System.IO.File.GetAttributes(shortcut.TargetPath);

                    // check to ensure the shortcut file represents a directory or a file
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        // create an array of files within all directories that match the extention predicate list
                        string[] strings = Directory.GetFiles(shortcut.TargetPath, "*.*", SearchOption.AllDirectories)
                            .Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();
                        
                        // iterate through strings array
                        foreach (string item in strings)
                        {
                            // create new FileInfo object and add to files list
                            FileInfo fi1 = new FileInfo(item);
                            files.Add(fi1);
                        }
                    }
                    else
                    {
                        // create new FileInfo object and add to files list
                        FileInfo fi2 = new FileInfo(entry);
                        files.Add(fi2);
                    }
                }
                else
                {
                    // create new FileInfo object and add to files list
                    FileInfo fi = new FileInfo(entry);
                    files.Add(fi);
                }
            }
            // copy List
            Files = files;
        }

        private void PopulateFlowControlList()
        {
            // build flow layout list
            BuildFlowLayoutList(Files);
            // set listsorted variable to false
            listSorted = false;
        }

        private Image GetIconBitMap(string extension)
        {
            // create windows registry path object
            object registeredExecutable = Registry.ClassesRoot.OpenSubKey(extension).GetValue(null);

            // create sub-registry value object from registry
            object command = Registry.ClassesRoot
                .OpenSubKey(registeredExecutable.ToString())
                .OpenSubKey("shell")
                .OpenSubKey("Open")
                .OpenSubKey("command").GetValue(null);

            // format registry entry and extract path to executable
            var from = command.ToString().IndexOf("C:");
            var to = command.ToString().IndexOf(".exe", StringComparison.CurrentCultureIgnoreCase);
            string commandString = String.Format(@"{0}", command.ToString()[from..(to + 4)]);

            // extract icon linked to executable and convert to bitmap of size (32,32)
            Icon ico = Icon.ExtractAssociatedIcon(String.Format(@"{0}", commandString));
            Bitmap newBitMap = new Bitmap(ico.ToBitmap(), new Size(32, 32));
            
            // return bitmap
            return newBitMap;
        }

        private Image ConvertPathToBitMap(string path)
        {
            // extract icon from linked executable and convert to bitmap of size (23,32)
            Icon ico = Icon.ExtractAssociatedIcon(String.Format(@"{0}", path));
            Bitmap newBitMap = new Bitmap(ico.ToBitmap(), new Size(32, 32));

            // return bitmap
            return newBitMap;
        }

        private int GetCountOfFilesInShortcut(string[] fileStrings, List<string> extensions)
        {
            // initialize count variable
            int extraLength = 0;
            // iterate through array 
            foreach (string entry in fileStrings)
            {
                // check is a shortcut
                if (Path.GetExtension(entry) == ".lnk")
                {
                    // initialize new IWshShell3 object
                    IWshShell3 wsh = new WshShellClass();
                    // create shortcut object
                    IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(String.Format(@"{0}", entry));

                    // create FileAttributes object for shortcut
                    FileAttributes attr = System.IO.File.GetAttributes(shortcut.TargetPath);
                    // check to ensure the shortcut file represents a directory or a file
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        // return all files matching extensions predicate within all directories of folder specified
                        string[] strings = Directory.GetFiles(shortcut.TargetPath, "*.*", SearchOption.AllDirectories)
                            .Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();
                        // iterate through array
                        foreach (string item in strings)
                        {
                            // increment count variable
                            extraLength++;
                        }
                    }
                }
            }
            // return file count
            return extraLength;
        }

        private void SearchList(string query)
        {
            // clear flow layout panel
            flowLayoutPanel.Controls.Clear();
            // search list using current query string 
            List<FileInfo> filesFound = new List<FileInfo>(Files.FindAll(x => x.Name.ToLower().Contains(query.ToLower())));
            // rebuild flow layout list
            BuildFlowLayoutList(filesFound);
        }

        private void SortList()
        {
            // clear flow layout panel
            flowLayoutPanel.Controls.Clear();
            // sort list by Name
            List<FileInfo> filesFound = new List<FileInfo>(Files.OrderBy(x => x.Name));
            // rebuild flow layout list
            BuildFlowLayoutList(filesFound);
            // update sorted variable to True
            listSorted = true;
        }

        private void BuildFlowLayoutList(List<FileInfo> filesFound)
        {
            // create ListItem array for size of FilesFound 
            ListItem[] listItems = new ListItem[filesFound.Count];

            // iterate through indexes
            for (int i = 0; i < listItems.Length; i++)
            {
                // create new ListItem
                listItems[i] = new ListItem();
                // set icon based on file extentsion
                if (filesFound[i].Extension == ".ps1")
                {
                    // set icon after conversion
                    listItems[i].Icon = ConvertPathToBitMap(powershellexe);
                    listItems[i].Importance = 5;

                    if(System.IO.File.Exists(filesFound[i].DirectoryName + "\\info.json"))
                    {
                        AppInfo app = new AppInfo(filesFound[i].DirectoryName);

                        listItems[i].Info = app.Info;
                    }
                    else
                    {
                        listItems[i].Info = "No information file available!";
                    }
                }
                else if (filesFound[i].Extension == ".exe")
                {
                    //set icon after conversion
                    listItems[i].Icon = ConvertPathToBitMap(String.Format(@"{0}\{1}", filesFound[i].DirectoryName, filesFound[i].Name));
                    listItems[i].Importance = 4;
                    listItems[i].Info = "";
                }
                else if (filesFound[i].Extension == ".lnk")
                {
                    // create FileAttributes object and ensure the .lnk file does not represent a directory
                    FileAttributes attr = System.IO.File.GetAttributes(String.Format(@"{0}\{1}", filesFound[i].DirectoryName, filesFound[i].Name));
                    if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
                    {
                        // set icon after conversion
                        listItems[i].Icon = ConvertPathToBitMap(String.Format(@"{0}\{1}", filesFound[i].DirectoryName, filesFound[i].Name));
                        listItems[i].Importance = 3;
                        listItems[i].Info = "";
                    }
                }
                else
                {
                    // set icon after conversion
                    listItems[i].Icon = GetIconBitMap(filesFound[i].Extension);
                    listItems[i].Importance = 3;
                    listItems[i].Info = "";
                }

                // set extension
                listItems[i].Extension = filesFound[i].Extension;
                // set access
                listItems[i].Access = filesFound[i].LastAccessTime.ToString();
                // set app name
                listItems[i].AppName = filesFound[i].Name;
                // set app path
                listItems[i].AppPath = filesFound[i].DirectoryName;

                // add ListItem to flow layout panel
                flowLayoutPanel.Controls.Add(listItems[i]);
            }
        }

        private void SetHidePanel()
        {
            if (hidePanel == true)
            {
                panelSearch.Visible = false;
            }
            else
            {
                panelSearch.Visible = true;
            }
        }

        private void buttonApps_Click(object sender, EventArgs e)
        {
            // Initialize panel upon button click
            panelHighlight.Height = buttonApps.Height;
            panelHighlight.Top = buttonApps.Top;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonApps.Location.Y);
            SetHidePanel();
            buttonHideControl.Visible = true;
            // clear text
            textBoxSearch.Text = "";
            appButtonSelected = true;

            appSelected = true;
            toolsSelected = false;
            vmSelected = false;
            docSelected = false;

            // clear flow panel
            flowLayoutPanel.Controls.Clear();
            // get list of files with Extensions within specified directory
            GetListOfFiles(Settings.Default.AppsPath, appExts);
            // populate flow control list
            PopulateFlowControlList();
        }

        private void buttonTools_Click(object sender, EventArgs e)
        {
            // Initialize panel upon button click
            panelHighlight.Height = buttonTools.Height;
            panelHighlight.Top = buttonTools.Height;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonTools.Location.Y);
            SetHidePanel();
            buttonHideControl.Visible = true;
            // clear text
            textBoxSearch.Text = "";

            appSelected = false;
            toolsSelected = true;
            vmSelected = false;
            docSelected = false;

            // clear flow panel
            flowLayoutPanel.Controls.Clear();
            // get list of files with Extensions within specified directory
            GetListOfFiles(Settings.Default.ToolsPath, toolExts);
            // populate flow control list
            PopulateFlowControlList();
        }

        private void buttonVMs_Click(object sender, EventArgs e)
        {
            // Initialize panel upon button click
            panelHighlight.Height = buttonVMs.Height;
            panelHighlight.Top = buttonVMs.Height;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonVMs.Location.Y);
            SetHidePanel();
            buttonHideControl.Visible = true;
            // clear text
            textBoxSearch.Text = "";

            appSelected = false;
            toolsSelected = false;
            vmSelected = true;
            docSelected = false;

            // clear flow panel
            flowLayoutPanel.Controls.Clear();
            // get list of files with Extensions within specified directory
            GetListOfFiles(Settings.Default.VMsPath, vmExts);
            // populate flow control list
            PopulateFlowControlList();
        }

        private void buttonDocs_Click(object sender, EventArgs e)
        {
            // Initialize panel upon button click
            panelHighlight.Height = buttonDocs.Height;
            panelHighlight.Top = buttonDocs.Height;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonDocs.Location.Y);
            SetHidePanel();
            buttonHideControl.Visible = true;
            // clear text
            textBoxSearch.Text = "";

            appSelected = false;
            toolsSelected = false;
            vmSelected = false;
            docSelected = true;

            // clear flow panel
            flowLayoutPanel.Controls.Clear();
            // get list of files with Extensions within specified directory
            GetListOfFiles(Settings.Default.DocsPath, docExts);
            // populate flow control list
            PopulateFlowControlList();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            // Initialize panel upon button click
            panelHighlight.Top = buttonSettings.Height;
            panelHighlight.Height = buttonSettings.Height;
            panelHighlight.Location = new Point(panelHighlight.Location.X, buttonSettings.Location.Y);
            panelSearch.Visible = false;
            buttonHideControl.Visible = false;

            appSelected = false;
            toolsSelected = false;
            vmSelected = false;
            docSelected = false;

            // clear flow panel
            flowLayoutPanel.Controls.Clear();
            // populate settings
            PopulateSettings();
        }

        private void NewForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Catch left mouse hold on object within UI
            if (e.Button == MouseButtons.Left)
            {   
                // update X position
                this.Left += e.X - lastPoint.X;
                // update Y position
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void NewForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Update position of mouse drag
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // exit UI upon buttonExit click
            this.Close();
        }

        private void buttonHideControl_Click(object sender, EventArgs e)
        {
            // hide/unhide searchbar
            if (panelSearch.Visible == true) 
            {
                // hide bar and change image to up
                panelSearch.Visible = false;
                buttonHideControl.Image = Resources.sort_up_32px;
                hidePanel = true;
            }
            else
            {
                // unhide bar and change image to down
                panelSearch.Visible = true;
                buttonHideControl.Image = Resources.sort_down_32px;
                hidePanel = false;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // determine state of searchbar is not empty
            if (string.IsNullOrEmpty(textBoxSearch.Text) == false)
            {
                // search list using query string
                SearchList(this.textBoxSearch.Text);
            }
            else
            {
                // clear flow panel
                flowLayoutPanel.Controls.Clear();
                // repopulate list
                PopulateFlowControlList();
            }
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            // ensure text is present upon clear text button click
            if (textBoxSearch.Text != "")
            {
                // clear text
                textBoxSearch.Text = "";
                // clear flow panel
                flowLayoutPanel.Controls.Clear();
                // repopulate list
                PopulateFlowControlList();
            }
        }

        private void buttonSortAZ_Click(object sender, EventArgs e)
        {
            // check if list is already sorted
            if (listSorted == false)
            {
                // sort list
                SortList();
            }
        }

        public bool getAppButtonSelected()
        {
            if (getButtonSelection() == "app")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getButtonSelection()
        {
            if (appSelected == true)
            {
                return "app";
            }
            else if (toolsSelected == true)
            {
                return "tool";
            }
            else if (vmSelected == true)
            {
                return "vm";
            }
            else if (docSelected == true)
            {
                return "doc";
            }
            else
            {
                return "none";
            }
        }

        private string SettingsPathLookup(string type)
        {
            if (type == "app")
            {
                return Settings.Default.AppsPath;
            }
            else if (type == "tool")
            {
                return Settings.Default.ToolsPath;
            }
            else if (type == "vm")
            {
                return Settings.Default.VMsPath;
            }
            else if (type == "doc")
            {
                return Settings.Default.DocsPath;
            }
            else
            {
                return null;
            }
        }

        private void refreshList()
        {
            string type = getButtonSelection();
            if (type == "app")
            {
                this.buttonApps.PerformClick();
            }
            else if (type == "tool")
            {
                this.buttonTools.PerformClick();
            }
            else if (type == "vm")
            {
                this.buttonVMs.PerformClick();
            }
            else if (type == "doc")
            {
                this.buttonDocs.PerformClick();
            }
        }

        private void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void flowLayoutPanel_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (getButtonSelection() != "none")
            {
                string dropPath = SettingsPathLookup(getButtonSelection());

                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                string file = Path.GetFileName(s[0]);

                Directory.Move(s[0], dropPath + "\\" + file);
                refreshList();
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            HelpPanel modal = new HelpPanel();
            modal.Parent = this.Parent;
            modal.StartPosition = FormStartPosition.CenterParent;
            modal.ShowDialog();
        }

    }
}
