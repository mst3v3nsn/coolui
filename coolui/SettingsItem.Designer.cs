using System.Configuration;
using System.Windows.Forms;

namespace coolui
{
    partial class SettingsItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsItem));
            this.panelSettings = new System.Windows.Forms.Panel();
            this.labelConfigTarget = new System.Windows.Forms.Label();
            this.comboBoxTargetConfig = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxVMsPath = new System.Windows.Forms.TextBox();
            this.labelVMsPath = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxDocsPath = new System.Windows.Forms.TextBox();
            this.labelDocsPath = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxToolsPath = new System.Windows.Forms.TextBox();
            this.labelToolsPath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxAppsPath = new System.Windows.Forms.TextBox();
            this.labelAppPath = new System.Windows.Forms.Label();
            this.panelSettings.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettings
            // 
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.labelConfigTarget);
            this.panelSettings.Controls.Add(this.comboBoxTargetConfig);
            this.panelSettings.Controls.Add(this.panel4);
            this.panelSettings.Controls.Add(this.buttonSave);
            this.panelSettings.Controls.Add(this.panel3);
            this.panelSettings.Controls.Add(this.panel2);
            this.panelSettings.Controls.Add(this.panel1);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(500, 402);
            this.panelSettings.TabIndex = 1;
            // 
            // labelConfigTarget
            // 
            this.labelConfigTarget.AutoSize = true;
            this.labelConfigTarget.Location = new System.Drawing.Point(38, 332);
            this.labelConfigTarget.Name = "labelConfigTarget";
            this.labelConfigTarget.Size = new System.Drawing.Size(188, 15);
            this.labelConfigTarget.TabIndex = 0;
            this.labelConfigTarget.Text = "Config Target (PowerShell Scripts):";
            // 
            // comboBoxTargetConfig
            // 
            this.comboBoxTargetConfig.FormattingEnabled = true;
            this.comboBoxTargetConfig.Location = new System.Drawing.Point(38, 350);
            this.comboBoxTargetConfig.Name = "comboBoxTargetConfig";
            this.comboBoxTargetConfig.Size = new System.Drawing.Size(86, 23);
            this.comboBoxTargetConfig.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBoxVMsPath);
            this.panel4.Controls.Add(this.labelVMsPath);
            this.panel4.Location = new System.Drawing.Point(12, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 67);
            this.panel4.TabIndex = 1;
            // 
            // textBoxVMsPath
            // 
            this.textBoxVMsPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxVMsPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.textBoxVMsPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxVMsPath.ForeColor = System.Drawing.Color.Turquoise;
            this.textBoxVMsPath.Location = new System.Drawing.Point(25, 28);
            this.textBoxVMsPath.Name = "textBoxVMsPath";
            this.textBoxVMsPath.Size = new System.Drawing.Size(407, 23);
            this.textBoxVMsPath.TabIndex = 1;
            // 
            // labelVMsPath
            // 
            this.labelVMsPath.AutoSize = true;
            this.labelVMsPath.Location = new System.Drawing.Point(25, 10);
            this.labelVMsPath.Name = "labelVMsPath";
            this.labelVMsPath.Size = new System.Drawing.Size(60, 15);
            this.labelVMsPath.TabIndex = 0;
            this.labelVMsPath.Text = "VMs Path:";
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(402, 312);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 61);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxDocsPath);
            this.panel3.Controls.Add(this.labelDocsPath);
            this.panel3.Location = new System.Drawing.Point(12, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 67);
            this.panel3.TabIndex = 1;
            // 
            // textBoxDocsPath
            // 
            this.textBoxDocsPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxDocsPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.textBoxDocsPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxDocsPath.ForeColor = System.Drawing.Color.Turquoise;
            this.textBoxDocsPath.Location = new System.Drawing.Point(25, 28);
            this.textBoxDocsPath.Name = "textBoxDocsPath";
            this.textBoxDocsPath.Size = new System.Drawing.Size(407, 23);
            this.textBoxDocsPath.TabIndex = 1;
            // 
            // labelDocsPath
            // 
            this.labelDocsPath.AutoSize = true;
            this.labelDocsPath.Location = new System.Drawing.Point(25, 10);
            this.labelDocsPath.Name = "labelDocsPath";
            this.labelDocsPath.Size = new System.Drawing.Size(98, 15);
            this.labelDocsPath.TabIndex = 0;
            this.labelDocsPath.Text = "Documents Path:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxToolsPath);
            this.panel2.Controls.Add(this.labelToolsPath);
            this.panel2.Location = new System.Drawing.Point(12, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 63);
            this.panel2.TabIndex = 1;
            // 
            // textBoxToolsPath
            // 
            this.textBoxToolsPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxToolsPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.textBoxToolsPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxToolsPath.ForeColor = System.Drawing.Color.Turquoise;
            this.textBoxToolsPath.Location = new System.Drawing.Point(25, 27);
            this.textBoxToolsPath.Name = "textBoxToolsPath";
            this.textBoxToolsPath.Size = new System.Drawing.Size(407, 23);
            this.textBoxToolsPath.TabIndex = 1;
            // 
            // labelToolsPath
            // 
            this.labelToolsPath.AutoSize = true;
            this.labelToolsPath.Location = new System.Drawing.Point(25, 9);
            this.labelToolsPath.Name = "labelToolsPath";
            this.labelToolsPath.Size = new System.Drawing.Size(64, 15);
            this.labelToolsPath.TabIndex = 0;
            this.labelToolsPath.Text = "Tools Path:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxAppsPath);
            this.panel1.Controls.Add(this.labelAppPath);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 65);
            this.panel1.TabIndex = 1;
            // 
            // textBoxAppsPath
            // 
            this.textBoxAppsPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxAppsPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.textBoxAppsPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxAppsPath.ForeColor = System.Drawing.Color.Turquoise;
            this.textBoxAppsPath.Location = new System.Drawing.Point(25, 29);
            this.textBoxAppsPath.Name = "textBoxAppsPath";
            this.textBoxAppsPath.Size = new System.Drawing.Size(407, 23);
            this.textBoxAppsPath.TabIndex = 1;
            // 
            // labelAppPath
            // 
            this.labelAppPath.AutoSize = true;
            this.labelAppPath.Location = new System.Drawing.Point(25, 11);
            this.labelAppPath.Name = "labelAppPath";
            this.labelAppPath.Size = new System.Drawing.Size(69, 15);
            this.labelAppPath.TabIndex = 0;
            this.labelAppPath.Text = "Apps Paths:";
            // 
            // SettingsItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panelSettings);
            this.Name = "SettingsItem";
            this.Size = new System.Drawing.Size(500, 402);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDocsPath;
        private System.Windows.Forms.Label labelDocsPath;
        private System.Windows.Forms.TextBox textBoxToolsPath;
        private System.Windows.Forms.Label labelToolsPath;
        private System.Windows.Forms.TextBox textBoxAppsPath;
        private System.Windows.Forms.Label labelAppPath;
        private System.Windows.Forms.Button buttonSave;
        private Panel panel4;
        private TextBox textBoxVMsPath;
        private Label labelVMsPath;
        private Label labelConfigTarget;
        private ComboBox comboBoxTargetConfig;
    }
}
