using System.Windows.Forms;
using System.Drawing;

namespace PasswordGenerator
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabelGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ilanix13");
        }

        private void labelAbout_Click(object sender, System.EventArgs e)
        {

        }
    }
}
