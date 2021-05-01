using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PasswordGenerator
{
    public partial class MainApp : Form
    {
        private static int passwordLength;
        private static readonly List<char> Symbols = new List<char>();

        private static readonly char[] Lower = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray();
        private static readonly char[] Upper = Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => (char)c).ToArray();
        private static readonly char[] Digits = Enumerable.Range('0', '9' - '0' + 1).Select(c => (char)c).ToArray();
        private static readonly char[] SpecSymb = Enumerable.Range('!', '/' - '!' + 1).Select(c => (char)c).ToArray();

        public MainApp()
        {
            InitializeComponent();
            comboBoxLength.SelectedIndex = 0;
        }
        private void PasswordParameters()
        {
            Symbols.Clear();

            if (chkBoxLower.Checked)
            {
                Symbols.AddRange(Lower);
            }

            if (chkBoxUpper.Checked)
            {
                Symbols.AddRange(Upper);
            }

            if (chkBoxNumber.Checked)
            {
                Symbols.AddRange(Digits);
            }

            if (chkBoxSym.Checked)
            {
                Symbols.AddRange(SpecSymb);
            }

            passwordLength = int.Parse(comboBoxLength.Text);
        }
        private void btnRes_Click(object sender, EventArgs e)
        {           
            textBoxRes.Clear();
            PasswordParameters();

            try
            {
                for (int i = 0; i < counter.Value; i++)
                {
                    textBoxRes.Text += PasswordFormation.GetPass(Symbols, passwordLength) + Environment.NewLine;
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
    }
}