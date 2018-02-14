namespace DFPlayerEditor.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbPlayerList = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFindGame = new System.Windows.Forms.Button();
            this.lblNovaHQ = new System.Windows.Forms.Label();
            this.btnRes640 = new System.Windows.Forms.Button();
            this.lblSetResolution = new System.Windows.Forms.Label();
            this.btnRes800 = new System.Windows.Forms.Button();
            this.btnRes1024 = new System.Windows.Forms.Button();
            this.lblPlayerList = new System.Windows.Forms.Label();
            this.lblSetGamma = new System.Windows.Forms.Label();
            this.trackBarGama = new System.Windows.Forms.TrackBar();
            this.lblGammaText = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.lblSetResolutionText = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGama)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlayerList
            // 
            this.lbPlayerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(0)))));
            this.lbPlayerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPlayerList.ForeColor = System.Drawing.Color.Lime;
            this.lbPlayerList.FormattingEnabled = true;
            this.lbPlayerList.Location = new System.Drawing.Point(12, 28);
            this.lbPlayerList.Name = "lbPlayerList";
            this.lbPlayerList.Size = new System.Drawing.Size(231, 117);
            this.lbPlayerList.TabIndex = 0;
            this.lbPlayerList.SelectedIndexChanged += new System.EventHandler(this.lbPlayerList_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Lime;
            this.btnClose.Location = new System.Drawing.Point(185, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFindGame
            // 
            this.btnFindGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindGame.BackgroundImage")));
            this.btnFindGame.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnFindGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindGame.ForeColor = System.Drawing.Color.Lime;
            this.btnFindGame.Location = new System.Drawing.Point(96, 278);
            this.btnFindGame.Name = "btnFindGame";
            this.btnFindGame.Size = new System.Drawing.Size(76, 23);
            this.btnFindGame.TabIndex = 4;
            this.btnFindGame.Text = "Find Game Path";
            this.btnFindGame.UseVisualStyleBackColor = true;
            this.btnFindGame.Click += new System.EventHandler(this.btnFindGame_Click);
            // 
            // lblNovaHQ
            // 
            this.lblNovaHQ.AutoSize = true;
            this.lblNovaHQ.BackColor = System.Drawing.Color.Transparent;
            this.lblNovaHQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovaHQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaHQ.ForeColor = System.Drawing.Color.Lime;
            this.lblNovaHQ.Location = new System.Drawing.Point(60, 312);
            this.lblNovaHQ.Name = "lblNovaHQ";
            this.lblNovaHQ.Size = new System.Drawing.Size(124, 13);
            this.lblNovaHQ.TabIndex = 5;
            this.lblNovaHQ.Text = "(c) 2018 Novahq.net";
            this.lblNovaHQ.Click += new System.EventHandler(this.lblNovaHQ_Click);
            // 
            // btnRes640
            // 
            this.btnRes640.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRes640.BackgroundImage")));
            this.btnRes640.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRes640.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes640.ForeColor = System.Drawing.Color.Lime;
            this.btnRes640.Location = new System.Drawing.Point(12, 174);
            this.btnRes640.Name = "btnRes640";
            this.btnRes640.Size = new System.Drawing.Size(72, 23);
            this.btnRes640.TabIndex = 6;
            this.btnRes640.Text = "640x480";
            this.btnRes640.UseVisualStyleBackColor = true;
            this.btnRes640.Click += new System.EventHandler(this.btnSetRes640_Click);
            // 
            // lblSetResolution
            // 
            this.lblSetResolution.AutoSize = true;
            this.lblSetResolution.BackColor = System.Drawing.Color.Transparent;
            this.lblSetResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetResolution.ForeColor = System.Drawing.Color.Lime;
            this.lblSetResolution.Location = new System.Drawing.Point(9, 153);
            this.lblSetResolution.Name = "lblSetResolution";
            this.lblSetResolution.Size = new System.Drawing.Size(94, 13);
            this.lblSetResolution.TabIndex = 7;
            this.lblSetResolution.Text = "Set Resolution:";
            // 
            // btnRes800
            // 
            this.btnRes800.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRes800.BackgroundImage")));
            this.btnRes800.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRes800.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes800.ForeColor = System.Drawing.Color.Lime;
            this.btnRes800.Location = new System.Drawing.Point(91, 174);
            this.btnRes800.Name = "btnRes800";
            this.btnRes800.Size = new System.Drawing.Size(72, 23);
            this.btnRes800.TabIndex = 8;
            this.btnRes800.Text = "800x600";
            this.btnRes800.UseVisualStyleBackColor = true;
            this.btnRes800.Click += new System.EventHandler(this.btnSetRes800_Click);
            // 
            // btnRes1024
            // 
            this.btnRes1024.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRes1024.BackgroundImage")));
            this.btnRes1024.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRes1024.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes1024.ForeColor = System.Drawing.Color.Lime;
            this.btnRes1024.Location = new System.Drawing.Point(171, 174);
            this.btnRes1024.Name = "btnRes1024";
            this.btnRes1024.Size = new System.Drawing.Size(73, 23);
            this.btnRes1024.TabIndex = 9;
            this.btnRes1024.Text = "1024x768";
            this.btnRes1024.UseVisualStyleBackColor = true;
            this.btnRes1024.Click += new System.EventHandler(this.btnSetRes1024_Click);
            // 
            // lblPlayerList
            // 
            this.lblPlayerList.AutoSize = true;
            this.lblPlayerList.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerList.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayerList.Location = new System.Drawing.Point(9, 7);
            this.lblPlayerList.Name = "lblPlayerList";
            this.lblPlayerList.Size = new System.Drawing.Size(97, 13);
            this.lblPlayerList.TabIndex = 10;
            this.lblPlayerList.Text = "Current Players:";
            // 
            // lblSetGamma
            // 
            this.lblSetGamma.AutoSize = true;
            this.lblSetGamma.BackColor = System.Drawing.Color.Transparent;
            this.lblSetGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetGamma.ForeColor = System.Drawing.Color.Lime;
            this.lblSetGamma.Location = new System.Drawing.Point(9, 203);
            this.lblSetGamma.Name = "lblSetGamma";
            this.lblSetGamma.Size = new System.Drawing.Size(126, 13);
            this.lblSetGamma.TabIndex = 11;
            this.lblSetGamma.Text = "Set Gamma (50-450):";
            // 
            // trackBarGama
            // 
            this.trackBarGama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(0)))));
            this.trackBarGama.LargeChange = 1;
            this.trackBarGama.Location = new System.Drawing.Point(12, 224);
            this.trackBarGama.Maximum = 450;
            this.trackBarGama.Minimum = 50;
            this.trackBarGama.Name = "trackBarGama";
            this.trackBarGama.Size = new System.Drawing.Size(232, 45);
            this.trackBarGama.TabIndex = 13;
            this.trackBarGama.Value = 150;
            this.trackBarGama.Scroll += new System.EventHandler(this.trackBarGama_Scroll);
            // 
            // lblGammaText
            // 
            this.lblGammaText.AutoSize = true;
            this.lblGammaText.BackColor = System.Drawing.Color.Transparent;
            this.lblGammaText.ForeColor = System.Drawing.Color.Lime;
            this.lblGammaText.Location = new System.Drawing.Point(132, 203);
            this.lblGammaText.Name = "lblGammaText";
            this.lblGammaText.Size = new System.Drawing.Size(55, 13);
            this.lblGammaText.TabIndex = 14;
            this.lblGammaText.Text = "#gamma#";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveConfig.BackgroundImage")));
            this.btnSaveConfig.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.ForeColor = System.Drawing.Color.Lime;
            this.btnSaveConfig.Location = new System.Drawing.Point(12, 278);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(72, 23);
            this.btnSaveConfig.TabIndex = 15;
            this.btnSaveConfig.Text = "Save df.cfg";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // lblSetResolutionText
            // 
            this.lblSetResolutionText.AutoSize = true;
            this.lblSetResolutionText.BackColor = System.Drawing.Color.Transparent;
            this.lblSetResolutionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetResolutionText.ForeColor = System.Drawing.Color.Lime;
            this.lblSetResolutionText.Location = new System.Drawing.Point(97, 153);
            this.lblSetResolutionText.Name = "lblSetResolutionText";
            this.lblSetResolutionText.Size = new System.Drawing.Size(54, 13);
            this.lblSetResolutionText.TabIndex = 16;
            this.lblSetResolutionText.Text = "#current#";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.BackColor = System.Drawing.Color.Transparent;
            this.lblFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacebook.ForeColor = System.Drawing.Color.Lime;
            this.lblFacebook.Location = new System.Drawing.Point(62, 331);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(121, 13);
            this.lblFacebook.TabIndex = 20;
            this.lblFacebook.Text = "DF Facebook Group";
            this.lblFacebook.Click += new System.EventHandler(this.lblFacebook_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DFPlayerEditor.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(262, 350);
            this.Controls.Add(this.lblFacebook);
            this.Controls.Add(this.lblSetResolutionText);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.lblGammaText);
            this.Controls.Add(this.trackBarGama);
            this.Controls.Add(this.lblSetGamma);
            this.Controls.Add(this.lblPlayerList);
            this.Controls.Add(this.btnRes1024);
            this.Controls.Add(this.btnRes800);
            this.Controls.Add(this.lblSetResolution);
            this.Controls.Add(this.btnRes640);
            this.Controls.Add(this.lblNovaHQ);
            this.Controls.Add(this.btnFindGame);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbPlayerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DF1 Player Editor v1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawListBoxBorder);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFindGame;
        private System.Windows.Forms.Label lblNovaHQ;
        public System.Windows.Forms.ListBox lbPlayerList;
        private System.Windows.Forms.Button btnRes640;
        private System.Windows.Forms.Label lblSetResolution;
        private System.Windows.Forms.Button btnRes800;
        private System.Windows.Forms.Button btnRes1024;
        private System.Windows.Forms.Label lblPlayerList;
        private System.Windows.Forms.Label lblSetGamma;
        private System.Windows.Forms.TrackBar trackBarGama;
        private System.Windows.Forms.Label lblGammaText;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label lblSetResolutionText;
        private System.Windows.Forms.Label lblFacebook;
    }
}

