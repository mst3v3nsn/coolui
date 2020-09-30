namespace coolui
{
    public partial class ListItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListItem));
            this.panelButton = new System.Windows.Forms.Panel();
            this.appButton = new System.Windows.Forms.Button();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.appButton);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(97, 86);
            this.panelButton.TabIndex = 0;
            // 
            // appButton
            // 
            this.appButton.FlatAppearance.BorderSize = 0;
            this.appButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.appButton.Image = ((System.Drawing.Image)(resources.GetObject("appButton.Image")));
            this.appButton.Location = new System.Drawing.Point(0, 0);
            this.appButton.Name = "appButton";
            this.appButton.Size = new System.Drawing.Size(96, 84);
            this.appButton.TabIndex = 2;
            this.appButton.Text = "App";
            this.appButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.appButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.appButton.UseVisualStyleBackColor = true;
            this.appButton.Click += new System.EventHandler(this.appButton_Click);
            this.appButton.MouseHover += new System.EventHandler(this.appButton_MouseHover);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panelButton);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(98, 86);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button appButton;
    }
}
