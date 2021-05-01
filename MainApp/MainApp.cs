using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            comboBoxLength.SelectedIndex = 0;
            radioButtonAll.Checked = true;
        }
        public void PasswordParameters()
        {
            PasswordFormation.Symbols.Clear();

            if (chkBoxLower.Checked)
            {
                PasswordFormation.Symbols.AddRange(PasswordFormation.Lower);
            }

            if (chkBoxUpper.Checked)
            {
                PasswordFormation.Symbols.AddRange(PasswordFormation.Upper);
            }

            if (chkBoxNumber.Checked)
            {
                PasswordFormation.Symbols.AddRange(PasswordFormation.Digits);
            }

            if (chkBoxSym.Checked)
            {
                PasswordFormation.Symbols.AddRange(PasswordFormation.SpecSymb);
            }

            PasswordFormation.passwordLength = int.Parse(comboBoxLength.Text);
        }
        private void btnRes_Click(object sender, EventArgs e)
        {           
            textBoxRes.Clear();
            PasswordParameters();

            try
            {
                for (int i = 0; i < counter.Value; i++)
                {
                    textBoxRes.Text += PasswordFormation.GetPass(PasswordFormation.Symbols, PasswordFormation.passwordLength) + Environment.NewLine;
                }

                textBoxRes.Text = textBoxRes.Text.Remove(textBoxRes.Text.LastIndexOf(Environment.NewLine));
            }

            catch
            {
                MessageBox.Show("Incorrect settings, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            try 
            {               
                Clipboard.SetText(textBoxRes.Text);
                MessageBox.Show("Copied to clipboard!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (ArgumentNullException)
            {
                MessageBox.Show("There is nothing to copy!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            textBoxRes.Clear();
            chkBoxLower.Checked = false;
            chkBoxUpper.Checked = false;
            chkBoxNumber.Checked = false;
            chkBoxSym.Checked = false;
            radioButtonCustom.Checked = true;
            comboBoxLength.SelectedIndex = 0;
            counter.Value = 5;
        }
        private void btntoFile_Click(object sender, EventArgs e)
        {
            if (textBoxRes.Text.Length != 0)
            {
                var path = Environment.CurrentDirectory;

                path += @"\..\..\passwords.txt";    
                
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(textBoxRes.Text);
                    fs.Write(info, 0, info.Length);
                }

                MessageBox.Show("Passwords saved to file «passwords.txt»!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }

            else
            {
                MessageBox.Show("There aren't passwords to write in file!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            textBoxRes.Lines = textBoxRes.Lines.OrderBy(l => l).ToArray();
        }

        #region additional
        private void AutoCheckEnabled()
        {          
           chkBoxLower.AutoCheck = true;
           chkBoxUpper.AutoCheck = true;
           chkBoxNumber.AutoCheck = true;
           chkBoxSym.AutoCheck = true;
        }
        private void AutoCheckDisabled()
        {
            chkBoxLower.AutoCheck = false;
            chkBoxUpper.AutoCheck = false;
            chkBoxNumber.AutoCheck = false;
            chkBoxSym.AutoCheck = false;
        }
        private void btnRes_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(btnRes, "Generate new password set");
        }
        private void btnCopy_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(btnCopy, "Copy password set to clipboard");
        }
        private void btnClean_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(btnClean, "Set defaults settings and clear fields");
        }
        private void btntoFile_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(btntoFile, "Write password set to passwords.txt");
        }
        private void btnSort_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(btnSort, "Sort password set");
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }
        private void radioButtonLetters_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxLower.Checked = true;
            chkBoxUpper.Checked = true;
            chkBoxNumber.Checked = false;
            chkBoxSym.Checked = false;
            AutoCheckDisabled();
        }
        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxLower.Checked = true;
            chkBoxUpper.Checked = true;
            chkBoxNumber.Checked = true;
            chkBoxSym.Checked = true;
            AutoCheckDisabled();
        }
        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            AutoCheckEnabled();
        }
        #endregion
    }
}