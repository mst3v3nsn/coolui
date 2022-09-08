using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace coolui
{
    public partial class SettingsItem : UserControl
    {
        public SettingsItem()
        {
            InitializeComponent();
            comboBoxTargetConfig.Items.Add("lab");
        }

        #region Properties

        private string _appsPath;
        private string _toolsPath;
        private string _docsPath;
        private string _vmsPath;
        private string _config;

        [Category("Custom Props")]
        public string AppsPath
        {
            get { return _appsPath; }
            set { _appsPath = value; textBoxAppsPath.Text = value; }
        }

        [Category("Custom Props")]
        public string ToolsPath
        {
            get { return _toolsPath; }
            set { _toolsPath = value; textBoxToolsPath.Text = value; }
        }

        [Category("Custom Props")]
        public string DocsPath
        {
            get { return _docsPath; }
            set { _docsPath = value; textBoxDocsPath.Text = value; }
        }

        [Category("Custom Props")]
        public string VMsPath
        {
            get { return _vmsPath; }
            set { _vmsPath = value; textBoxVMsPath.Text = value; }
        }

        [Category("Custom Props")]
        public string TargetConfig
        {
            get { return _config; }
            set { _config = value; comboBoxTargetConfig.Text = value; }
        }

        #endregion

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AppsPath = textBoxAppsPath.Text;
            Properties.Settings.Default.ToolsPath = textBoxToolsPath.Text;
            Properties.Settings.Default.DocsPath = textBoxDocsPath.Text;
            Properties.Settings.Default.VMsPath = textBoxVMsPath.Text;
            Properties.Settings.Default.TargetConfig = comboBoxTargetConfig.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
