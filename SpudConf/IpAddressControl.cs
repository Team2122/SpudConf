using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Tator.SpudConf
{
    internal class IPAddressControl : TextBox
    {
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = (Font)value.Clone();
            }
        }

        public IPAddress IPAddress
        {
            get
            {
                return IPAddress.Parse(Text);
            }
            set
            {
                Text = value.ToString();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var p = base.CreateParams;
                p.ClassName = "SysIpAddress32";
                return p;
            }
        }

        protected override Boolean IsInputKey(Keys keyData)
        {
            return base.IsInputKey(keyData) || keyData == Keys.Left || keyData == Keys.Right;
        }
    }
}