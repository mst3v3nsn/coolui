namespace coolui
{
    partial class MPCMSForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MPCMSForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonVMs = new System.Windows.Forms.Button();
            this.buttonDocs = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonTools = new System.Windows.Forms.Button();
            this.buttonApps = new System.Windows.Forms.Button();
            this.MPCMS = new System.Windows.Forms.Panel();
            this.buttonMPCMS = new System.Windows.Forms.Button();
            this.panelHighlight = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonSortAZ = new System.Windows.Forms.Button();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonHideControl = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.MPCMS.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.buttonVMs);
            this.panelMenu.Controls.Add(this.buttonDocs);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonTools);
            this.panelMenu.Controls.Add(this.buttonApps);
            this.panelMenu.Controls.Add(this.MPCMS);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(152, 611);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseDown);
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseMove);
            // 
            // buttonVMs
            // 
            this.buttonVMs.FlatAppearance.BorderSize = 0;
            this.buttonVMs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVMs.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVMs.ForeColor = System.Drawing.Color.White;
            this.buttonVMs.Image = ((System.Drawing.Image)(resources.GetObject("buttonVMs.Image")));
            this.buttonVMs.Location = new System.Drawing.Point(0, 258);
            this.buttonVMs.Name = "buttonVMs";
            this.buttonVMs.Size = new System.Drawing.Size(152, 77);
            this.buttonVMs.TabIndex = 3;
            this.buttonVMs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVMs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonVMs.UseVisualStyleBackColor = true;
            this.buttonVMs.Click += new System.EventHandler(this.buttonVMs_Click);
            this.buttonVMs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseDown);
            this.buttonVMs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseMove);
            // 
            // buttonDocs
            // 
            this.buttonDocs.FlatAppearance.BorderSize = 0;
            this.buttonDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDocs.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDocs.ForeColor = System.Drawing.Color.White;
            this.buttonDocs.Image = ((System.Drawing.Image)(resources.GetObject("buttonDocs.Image")));
            this.buttonDocs.Location = new System.Drawing.Point(0, 341);
            this.buttonDocs.Name = "buttonDocs";
            this.buttonDocs.Size = new System.Drawing.Size(152, 77);
            this.buttonDocs.TabIndex = 3;
            this.buttonDocs.Text = "Documents";
            this.buttonDocs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDocs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDocs.UseVisualStyleBackColor = true;
            this.buttonDocs.Click += new System.EventHandler(this.buttonDocs_Click);
            this.buttonDocs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseDown);
            this.buttonDocs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseMove);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(0, 530);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(152, 77);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.Location = new System.Drawing.Point(-1, 424);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(152, 77);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            this.buttonSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseDown);
            this.buttonSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseMove);
            // 
            // buttonTools
            // 
            this.buttonTools.FlatAppearance.BorderSize = 0;
            this.buttonTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTools.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTools.ForeColor = System.Drawing.Color.White;
            this.buttonTools.Image = ((System.Drawing.Image)(resources.GetObject("buttonTools.Image")));
            this.buttonTools.Location = new System.Drawing.Point(0, 175);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(152, 77);
            this.buttonTools.TabIndex = 3;
            this.buttonTools.Text = "Tools";
            this.buttonTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTools.UseVisualStyleBackColor = true;
            this.buttonTools.Click += new System.EventHandler(this.buttonTools_Click);
            this.buttonTools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseDown);
            this.buttonTools.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseMove);
            // 
            // buttonApps
            // 
            this.buttonApps.FlatAppearance.BorderSize = 0;
            this.buttonApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApps.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApps.ForeColor = System.Drawing.Color.White;
            this.buttonApps.Image = ((System.Drawing.Image)(resources.GetObject("buttonApps.Image")));
            this.buttonApps.Location = new System.Drawing.Point(-2, 92);
            this.buttonApps.Name = "buttonApps";
            this.buttonApps.Size = new System.Drawing.Size(152, 77);
            this.buttonApps.TabIndex = 3;
            this.buttonApps.Text = "Apps";
            this.buttonApps.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonApps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonApps.UseVisualStyleBackColor = true;
            this.buttonApps.Click += new System.EventHandler(this.buttonApps_Click);
            this.buttonApps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseDown);
            this.buttonApps.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseMove);
            // 
            // MPCMS
            // 
            this.MPCMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MPCMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MPCMS.Controls.Add(this.buttonMPCMS);
            this.MPCMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.MPCMS.Location = new System.Drawing.Point(0, 0);
            this.MPCMS.Name = "MPCMS";
            this.MPCMS.Size = new System.Drawing.Size(150, 96);
            this.MPCMS.TabIndex = 0;
            // 
            // buttonMPCMS
            // 
            this.buttonMPCMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonMPCMS.FlatAppearance.BorderSize = 0;
            this.buttonMPCMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMPCMS.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonMPCMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonMPCMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonMPCMS.Image")));
            this.buttonMPCMS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMPCMS.Location = new System.Drawing.Point(0, 0);
            this.buttonMPCMS.Name = "buttonMPCMS";
            this.buttonMPCMS.Size = new System.Drawing.Size(152, 96);
            this.buttonMPCMS.TabIndex = 3;
            this.buttonMPCMS.Text = "Central UI";
            this.buttonMPCMS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMPCMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMPCMS.UseVisualStyleBackColor = false;
            this.buttonMPCMS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseDown);
            this.buttonMPCMS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseMove);
            // 
            // panelHighlight
            // 
            this.panelHighlight.AutoScroll = true;
            this.panelHighlight.AutoSize = true;
            this.panelHighlight.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelHighlight.Location = new System.Drawing.Point(0, 93);
            this.panelHighlight.Name = "panelHighlight";
            this.panelHighlight.Padding = new System.Windows.Forms.Padding(1);
            this.panelHighlight.Size = new System.Drawing.Size(7, 77);
            this.panelHighlight.TabIndex = 3;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AllowDrop = true;
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(170, 1);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(913, 577);
            this.flowLayoutPanel.TabIndex = 4;
            this.flowLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.flowLayoutPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            this.flowLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseDown);
            this.flowLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelHighlight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(152, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 611);
            this.panel1.TabIndex = 4;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSearch.Controls.Add(this.buttonSortAZ);
            this.panelSearch.Controls.Add(this.buttonClearSearch);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Location = new System.Drawing.Point(173, 581);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(912, 31);
            this.panelSearch.TabIndex = 5;
            // 
            // buttonSortAZ
            // 
            this.buttonSortAZ.FlatAppearance.BorderSize = 0;
            this.buttonSortAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortAZ.ForeColor = System.Drawing.Color.White;
            this.buttonSortAZ.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortAZ.Image")));
            this.buttonSortAZ.Location = new System.Drawing.Point(397, 3);
            this.buttonSortAZ.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSortAZ.Name = "buttonSortAZ";
            this.buttonSortAZ.Size = new System.Drawing.Size(25, 24);
            this.buttonSortAZ.TabIndex = 1;
            this.buttonSortAZ.UseVisualStyleBackColor = true;
            this.buttonSortAZ.Click += new System.EventHandler(this.buttonSortAZ_Click);
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.FlatAppearance.BorderSize = 0;
            this.buttonClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSearch.ForeColor = System.Drawing.Color.White;
            this.buttonClearSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonClearSearch.Image")));
            this.buttonClearSearch.Location = new System.Drawing.Point(329, 3);
            this.buttonClearSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(25, 24);
            this.buttonClearSearch.TabIndex = 1;
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.Size = new System.Drawing.Size(326, 27);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(1083, 1);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(44, 30);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonHideControl
            // 
            this.buttonHideControl.FlatAppearance.BorderSize = 0;
            this.buttonHideControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHideControl.ForeColor = System.Drawing.Color.White;
            this.buttonHideControl.Image = ((System.Drawing.Image)(resources.GetObject("buttonHideControl.Image")));
            this.buttonHideControl.Location = new System.Drawing.Point(1054, 581);
            this.buttonHideControl.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHideControl.Name = "buttonHideControl";
            this.buttonHideControl.Size = new System.Drawing.Size(29, 30);
            this.buttonHideControl.TabIndex = 1;
            this.buttonHideControl.UseVisualStyleBackColor = true;
            this.buttonHideControl.Click += new System.EventHandler(this.buttonHideControl_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlus.Image")));
            this.buttonPlus.Location = new System.Drawing.Point(1083, 37);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(44, 30);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // MPCMSForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1129, 611);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonHideControl);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MPCMSForm";
            this.Text = "Central UI";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MPCMSForm_MouseMove);
            this.panelMenu.ResumeLayout(false);
            this.MPCMS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel MPCMS;
        private System.Windows.Forms.Button buttonTools;
        private System.Windows.Forms.Button buttonApps;
        private System.Windows.Forms.Panel panelHighlight;
        private System.Windows.Forms.Button buttonMPCMS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonDocs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonHideControl;
        private System.Windows.Forms.Button buttonSortAZ;
        private System.Windows.Forms.Button buttonVMs;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonPlus;
    }
}

