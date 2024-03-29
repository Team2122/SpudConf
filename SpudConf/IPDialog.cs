﻿using System;
using System.Text;
using System.Windows.Forms;

namespace Tator.SpudConf
{
    public partial class IPDialog : Form
    {
        public IPDialog()
        {
            InitializeComponent();
            maskedTextBoxTeamNumber_TextChanged(this, new EventArgs());
        }

        public string IPAddress
        {
            get { return ipAddressControl1.Text; }
            set { ipAddressControl1.Text = value; }
        }

        public string TeamNumber
        {
            get { return maskedTextBoxTeamNumber.Text; }
            set { maskedTextBoxTeamNumber.Text = value; }
        }

        private void maskedTextBoxTeamNumber_TextChanged(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var teamId = maskedTextBoxTeamNumber.Text;
            var selectionStart = maskedTextBoxTeamNumber.SelectionStart;
            var seletionLength = maskedTextBoxTeamNumber.SelectionLength;
            teamId = new String('0', 4 - teamId.Length) + teamId;
            //maskedTextBoxTeamNumber.Text = teamId;
            //maskedTextBoxTeamNumber.Select(selectionStart, seletionLength);
            sb.Append("10.");
            sb.Append(teamId.Substring(0, 2));
            sb.Append(".");
            sb.Append(teamId.Substring(2, 2));
            sb.Append(".2");
            ipAddressControl1.Text = sb.ToString();
        }
    }
}