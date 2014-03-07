using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tator.SpudConf
{
    public partial class StringDataEditor : DataEditor
    {
        public override string Key { get { return keyTextBox.Text; } set { keyTextBox.Text = value; } }
        public override string Value { get { return valueTextBox.Text; } set { valueTextBox.Text = value; } }

        public override string EditorName { get { return "String Editor"; } }

        public override event EventHandler ValueChanged;

        public StringDataEditor()
        {
            InitializeComponent();
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, new EventArgs());
        }
    }
}
