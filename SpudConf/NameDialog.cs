using System.Windows.Forms;

namespace Tator.SpudConf
{
    public partial class NameDialog : Form
    {
        public NameDialog()
        {
            InitializeComponent();
        }

        public string UserName { get { return this.textBoxName.Text; } set { this.textBoxName.Text = value; } }

        public void SelectAll()
        {
            this.textBoxName.SelectAll();
        }
    }
}