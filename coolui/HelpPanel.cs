using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace coolui
{
    public partial class HelpPanel : Form
    {
        public HelpPanel()
        {
            InitializeComponent();
            buildHelpItems();
        }

        public void buildHelpItems()
        {
            Help help = new Help();

            HelpItem[] items = new HelpItem[help.items.Count];

            for(int i = 0; i < items.Length; i++)
            {
                items[i] = new HelpItem();
                items[i].Item = help.items[i];

                flowLayoutPanelHelp.Controls.Add(items[i]);
            }

        }

        private void buttonCloseHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
