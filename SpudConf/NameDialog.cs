using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tator.SpudConf
{
    public partial class NameDialog : Form
    {
        public string UserName { get { return this.textBoxName.Text; } set { this.textBoxName.Text = value; } }

        public NameDialog()
        {
            InitializeComponent();
        }

        public void SelectAll()
        {
            this.textBoxName.SelectAll();
        }
    }
}
