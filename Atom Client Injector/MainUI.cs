using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atom_Client_Injector
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void discordBtn_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/RUSTeNu");
        }

        private void githubBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/echohackcmd/Atom-Client-Releases");
        }

        private void injectBtn_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFileCompleted += Client_DownloadFileCompleted;
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;

            Client.DownloadFileAsync(new Uri("https://github.com/EchoHackCmd/Atom-Client-Releases/releases/latest/download/Atom.Client.dll"), "Atom Client.dll");
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if(!downloadProgress.Visible) downloadProgress.Visible = true;
            downloadProgress.Maximum = int.Parse((e.BytesReceived / 100).ToString());
            downloadProgress.Value += e.ProgressPercentage;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Memory.InjectDLL(Directory.GetCurrentDirectory().ToString() + "/Atom Client.dll");
            downloadProgress.Value = 0;
            downloadProgress.Visible = false;
        }

        private void betaUIBtn_Click(object sender, EventArgs e)
        {
            BetaUI BetaForm = new BetaUI();
            Hide();
            BetaForm.StartPosition = FormStartPosition.Manual;
            BetaForm.Location = Location;
            BetaForm.ShowDialog();
            Close();
        }
    }
}
