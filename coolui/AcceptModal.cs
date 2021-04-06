using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace coolui
{
    public partial class AcceptModal : Form
    {
        Point lastPoint;

        public AcceptModal()
        {
            InitializeComponent();
        }

        private void Dialog_MouseMove(object sender, MouseEventArgs e)
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

        private void Dialog_MouseDown(object sender, MouseEventArgs e)
        {
            // Update position of mouse drag
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
