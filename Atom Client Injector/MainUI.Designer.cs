namespace Atom_Client_Injector
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.panel2 = new System.Windows.Forms.Panel();
            this.atomLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.discordBtn = new System.Windows.Forms.Button();
            this.githubBtn = new System.Windows.Forms.Button();
            this.injectBtn = new System.Windows.Forms.Button();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.betaUIBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.atomLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 66);
            this.panel2.TabIndex = 0;
            // 
            // atomLabel
            // 
            this.atomLabel.AutoSize = true;
            this.atomLabel.Font = new System.Drawing.Font("Rockwell Nova Cond", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atomLabel.Location = new System.Drawing.Point(12, 9);
            this.atomLabel.Name = "atomLabel";
            this.atomLabel.Size = new System.Drawing.Size(74, 36);
            this.atomLabel.TabIndex = 0;
            this.atomLabel.Text = "Atom";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.betaUIBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 400);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.exitBtn);
            this.panel3.Controls.Add(this.discordBtn);
            this.panel3.Controls.Add(this.githubBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(100, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 66);
            this.panel3.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Gray;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Sienna;
            this.exitBtn.Location = new System.Drawing.Point(188, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(80, 40);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // discordBtn
            // 
            this.discordBtn.BackColor = System.Drawing.Color.Gray;
            this.discordBtn.FlatAppearance.BorderSize = 0;
            this.discordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discordBtn.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordBtn.ForeColor = System.Drawing.Color.Aquamarine;
            this.discordBtn.Location = new System.Drawing.Point(102, 12);
            this.discordBtn.Name = "discordBtn";
            this.discordBtn.Size = new System.Drawing.Size(80, 40);
            this.discordBtn.TabIndex = 1;
            this.discordBtn.Text = "Discord";
            this.discordBtn.UseVisualStyleBackColor = false;
            this.discordBtn.Click += new System.EventHandler(this.discordBtn_Click_1);
            // 
            // githubBtn
            // 
            this.githubBtn.BackColor = System.Drawing.Color.Gray;
            this.githubBtn.FlatAppearance.BorderSize = 0;
            this.githubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.githubBtn.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubBtn.ForeColor = System.Drawing.Color.Chartreuse;
            this.githubBtn.Location = new System.Drawing.Point(16, 12);
            this.githubBtn.Name = "githubBtn";
            this.githubBtn.Size = new System.Drawing.Size(80, 40);
            this.githubBtn.TabIndex = 0;
            this.githubBtn.Text = "Github";
            this.githubBtn.UseVisualStyleBackColor = false;
            this.githubBtn.Click += new System.EventHandler(this.githubBtn_Click);
            // 
            // injectBtn
            // 
            this.injectBtn.BackColor = System.Drawing.Color.Gray;
            this.injectBtn.FlatAppearance.BorderSize = 0;
            this.injectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.injectBtn.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectBtn.ForeColor = System.Drawing.Color.Navy;
            this.injectBtn.Location = new System.Drawing.Point(210, 260);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.Size = new System.Drawing.Size(150, 80);
            this.injectBtn.TabIndex = 3;
            this.injectBtn.Text = "Inject";
            this.injectBtn.UseVisualStyleBackColor = false;
            this.injectBtn.Click += new System.EventHandler(this.injectBtn_Click);
            // 
            // downloadProgress
            // 
            this.downloadProgress.ForeColor = System.Drawing.Color.Cyan;
            this.downloadProgress.Location = new System.Drawing.Point(210, 216);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(150, 38);
            this.downloadProgress.TabIndex = 4;
            this.downloadProgress.Visible = false;
            // 
            // betaUIBtn
            // 
            this.betaUIBtn.BackColor = System.Drawing.Color.Gray;
            this.betaUIBtn.FlatAppearance.BorderSize = 0;
            this.betaUIBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.betaUIBtn.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betaUIBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.betaUIBtn.Location = new System.Drawing.Point(12, 82);
            this.betaUIBtn.Name = "betaUIBtn";
            this.betaUIBtn.Size = new System.Drawing.Size(80, 40);
            this.betaUIBtn.TabIndex = 1;
            this.betaUIBtn.Text = "Beta";
            this.betaUIBtn.UseVisualStyleBackColor = false;
            this.betaUIBtn.Click += new System.EventHandler(this.betaUIBtn_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(560, 400);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.injectBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atom Injector | Main";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label atomLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button githubBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button discordBtn;
        private System.Windows.Forms.Button injectBtn;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.Button betaUIBtn;
    }
}