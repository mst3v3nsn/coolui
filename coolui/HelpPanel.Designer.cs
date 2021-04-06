namespace coolui
{
    partial class HelpPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpPanel));
            this.panelHelp = new System.Windows.Forms.Panel();
            this.labelHelp = new System.Windows.Forms.Label();
            this.buttonCloseHelp = new System.Windows.Forms.Button();
            this.flowLayoutPanelHelp = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHelp
            // 
            this.panelHelp.Controls.Add(this.labelHelp);
            this.panelHelp.Controls.Add(this.buttonCloseHelp);
            this.panelHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHelp.Location = new System.Drawing.Point(0, 0);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(1032, 36);
            this.panelHelp.TabIndex = 0;
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHelp.Location = new System.Drawing.Point(12, 6);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(55, 21);
            this.labelHelp.TabIndex = 1;
            this.labelHelp.Text = "Help";
            // 
            // buttonCloseHelp
            // 
            this.buttonCloseHelp.Location = new System.Drawing.Point(988, 7);
            this.buttonCloseHelp.Name = "buttonCloseHelp";
            this.buttonCloseHelp.Size = new System.Drawing.Size(32, 23);
            this.buttonCloseHelp.TabIndex = 0;
            this.buttonCloseHelp.Text = "X";
            this.buttonCloseHelp.UseVisualStyleBackColor = true;
            this.buttonCloseHelp.Click += new System.EventHandler(this.buttonCloseHelp_Click);
            // 
            // flowLayoutPanelHelp
            // 
            this.flowLayoutPanelHelp.AutoScroll = true;
            this.flowLayoutPanelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelHelp.Location = new System.Drawing.Point(0, 36);
            this.flowLayoutPanelHelp.Name = "flowLayoutPanelHelp";
            this.flowLayoutPanelHelp.Size = new System.Drawing.Size(1032, 488);
            this.flowLayoutPanelHelp.TabIndex = 1;
            // 
            // HelpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1032, 524);
            this.Controls.Add(this.flowLayoutPanelHelp);
            this.Controls.Add(this.panelHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpPanel";
            this.Opacity = 0.9D;
            this.Text = "Help";
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Button buttonCloseHelp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHelp;
    }
}