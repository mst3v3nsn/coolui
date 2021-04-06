using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace coolui
{
    public partial class HelpItem : UserControl
    {
        public HelpItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _entry;

        [Category("Custom Props")]
        public string Item
        {
            // get path
            get { return _entry; }
            // set path
            set { 
                    _entry = value; 
                    labelHelpItem.Text = value;
            }
        }

        #endregion
    }
}
