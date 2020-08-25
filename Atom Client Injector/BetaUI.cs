using System;
using System.Windows.Forms;

namespace Atom_Client_Injector
{
    public partial class BetaUI : Form
    {
        String DLLPath;

        public BetaUI()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void mainUIBtn_Click(object sender, EventArgs e)
        {
            MainUI MainForm = new MainUI();
            Hide();
            MainForm.StartPosition = FormStartPosition.Manual;
            MainForm.Location = Location;
            MainForm.ShowDialog();
            Close();
        }

        private void locateDllBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog DLLPath = new OpenFileDialog();
            if (DLLPath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (DLLPath.SafeFileName.ToLower().EndsWith(".dll"))
                {
                    this.DLLPath = DLLPath.FileName;
                }
                else
                {
                    MessageBox.Show("You did not specify a .DLL file!", "Error");
                }
            }
            else
            {
                MessageBox.Show("You did not specify a file!", "Error");
            }
        }

        private void injectBtn_Click_1(object sender, EventArgs e)
        {
            if (DLLPath != null)
            {
                Memory.InjectDLL(DLLPath);
            }
            else
            {
                MessageBox.Show("You did not specify the DLL!", "Error");
            }
        }

        private void discordBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/RUSTeNu");
        }

        private void githubBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/echohackcmd/Atom-Client-Releases");
        }
    }
}