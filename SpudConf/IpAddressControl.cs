using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Net;

namespace Tator.SpudConf
{
    class IPAddressControl : TextBox
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var p = base.CreateParams;
                p.ClassName = "SysIpAddress32";
                return p;
            }
        }

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

        protected override Boolean IsInputKey(Keys keyData)
        {
            return base.IsInputKey(keyData) || keyData == Keys.Left || keyData == Keys.Right;
        }
    }
}
