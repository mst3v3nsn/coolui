namespace coolui
{
    partial class HelpItem
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
            this.panelHelpItem = new System.Windows.Forms.Panel();
            this.labelHelpItem = new System.Windows.Forms.Label();
            this.panelHelpItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHelpItem
            // 
            this.panelHelpItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHelpItem.Controls.Add(this.labelHelpItem);
            this.panelHelpItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHelpItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelHelpItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHelpItem.Location = new System.Drawing.Point(0, 0);
            this.panelHelpItem.Name = "panelHelpItem";
            this.panelHelpItem.Padding = new System.Windows.Forms.Padding(2);
            this.panelHelpItem.Size = new System.Drawing.Size(1025, 62);
            this.panelHelpItem.TabIndex = 0;
            // 
            // labelHelpItem
            // 
            this.labelHelpItem.AutoSize = true;
            this.labelHelpItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHelpItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHelpItem.Location = new System.Drawing.Point(2, 2);
            this.labelHelpItem.Margin = new System.Windows.Forms.Padding(2);
            this.labelHelpItem.MaximumSize = new System.Drawing.Size(958, 0);
            this.labelHelpItem.Name = "labelHelpItem";
            this.labelHelpItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHelpItem.Size = new System.Drawing.Size(52, 21);
            this.labelHelpItem.TabIndex = 0;
            this.labelHelpItem.Text = "label1";
            this.labelHelpItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HelpItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panelHelpItem);
            this.Name = "HelpItem";
            this.Size = new System.Drawing.Size(1025, 62);
            this.panelHelpItem.ResumeLayout(false);
            this.panelHelpItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHelpItem;
        private System.Windows.Forms.Label labelHelpItem;
    }
}
