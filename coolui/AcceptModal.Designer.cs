namespace coolui
{
    partial class AcceptModal
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
            this.panelDialog = new System.Windows.Forms.Panel();
            this.labelWarning = new System.Windows.Forms.Label();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.panelDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDialog
            // 
            this.panelDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDialog.Controls.Add(this.labelWarning);
            this.panelDialog.Controls.Add(this.buttonNo);
            this.panelDialog.Controls.Add(this.buttonYes);
            this.panelDialog.Controls.Add(this.labelMessage);
            this.panelDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDialog.Location = new System.Drawing.Point(0, 0);
            this.panelDialog.Name = "panelDialog";
            this.panelDialog.Size = new System.Drawing.Size(362, 119);
            this.panelDialog.TabIndex = 0;
            this.panelDialog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dialog_MouseDown);
            this.panelDialog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dialog_MouseMove);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Gold;
            this.labelWarning.Location = new System.Drawing.Point(11, 28);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(336, 13);
            this.labelWarning.TabIndex = 2;
            this.labelWarning.Text = "Running this application can have adverse effects to the system!";
            this.labelWarning.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dialog_MouseDown);
            this.labelWarning.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dialog_MouseMove);
            // 
            // buttonNo
            // 
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.Location = new System.Drawing.Point(192, 59);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonYes.Location = new System.Drawing.Point(100, 59);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 23);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMessage.Location = new System.Drawing.Point(129, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(105, 21);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Are you sure?";
            this.labelMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dialog_MouseDown);
            this.labelMessage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dialog_MouseMove);
            // 
            // AcceptModal
            // 
            this.AcceptButton = this.buttonYes;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CancelButton = this.buttonYes;
            this.ClientSize = new System.Drawing.Size(362, 119);
            this.ControlBox = false;
            this.Controls.Add(this.panelDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcceptModal";
            this.Text = "Message";
            this.TopMost = true;
            this.panelDialog.ResumeLayout(false);
            this.panelDialog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDialog;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonNo;
    }
}