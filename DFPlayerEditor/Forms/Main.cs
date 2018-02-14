using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using DFPlayerEditor.Classes;
using DFPlayerEditor.Properties;

namespace DFPlayerEditor.Forms
{
    public partial class Main : Form
    {
        private string LoadedGamePath;

        private Dictionary<int, Player> PlayerList;

        private Dictionary<string, string> GameConfig;

        public Main()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }

        private void DrawListBoxBorder(object sender, PaintEventArgs e)
        {
            var lbBorder = e.Graphics;
            lbBorder.DrawRectangle(new Pen(Color.Lime, 1), 11, 26, 232, 120);
            lbBorder.Dispose();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            ResetAllFields();

            if (FileFunctions.TestPath(Settings.Default.GamePath))
            {
                LoadedGamePath = Settings.Default.GamePath;
                PopulateForm(Settings.Default.GamePath);
                return;
            }

            if (FileFunctions.TestPath(Config.DefaultGamePath1))
            {
                LoadedGamePath = Config.DefaultGamePath1;
                PopulateForm(Config.DefaultGamePath1);
                return;
            }

            if (FileFunctions.TestPath(Config.DefaultGamePath2))
            {
                LoadedGamePath = Config.DefaultGamePath2;
                PopulateForm(Config.DefaultGamePath2);
                return;
            }

            btnFindGame_Click(null, null);

        }

        private void PopulateForm(string path)
        {
            PlayerList = FileFunctions.LoadPlayerData(path);
            GameConfig = FileFunctions.LoadConfigData(path);

            foreach (var player in PlayerList)
            {
                lbPlayerList.Items.Add(player.Value.Name);
            }

            btnSaveConfig.Enabled = false;
            btnRes640.Enabled = true;
            btnRes800.Enabled = true;
            btnRes1024.Enabled = true;

            trackBarGama.Enabled = true;

            if (GameConfig.ContainsKey("game_res"))
            {

                int.TryParse(GameConfig["game_res"], out var gameRes);

                switch (gameRes)
                {
                    case 1:
                        lblSetResolutionText.Text = "320x240";
                        break;
                    case 2:
                        lblSetResolutionText.Text = "400x300";
                        break;
                    case 3:
                        lblSetResolutionText.Text = "512x682";
                        break;
                    case 4:
                        lblSetResolutionText.Text = "640x480";
                        break;
                    case 5:
                        lblSetResolutionText.Text = "800x600";
                        break;
                    case 6:
                        lblSetResolutionText.Text = "1024x768";
                        break;
                    default:
                        lblSetResolutionText.Text = "Unsupported/Unknown";
                        break;
                }

            }

            if (GameConfig.ContainsKey("gamma"))
            {

                int.TryParse(GameConfig["gamma"], out var gameGamma);

                if (gameGamma >= 50 && 450 >= gameGamma)
                {
                    trackBarGama.Value = gameGamma;
                    lblGammaText.Text = gameGamma.ToString();
                }
                else
                {
                    trackBarGama.Value = 128;
                    lblGammaText.Text = "Unknown/Unsupported";
                }

            }

        }

        private void ResetAllFields()
        {
            lblSetResolutionText.Text = "";
            lblGammaText.Text = "";
            trackBarGama.Value = 128;
            lbPlayerList.Items.Clear();
            btnSaveConfig.Enabled = false;
            btnRes640.Enabled = false;
            btnRes800.Enabled = false;
            btnRes1024.Enabled = false;
            btnSaveConfig.Enabled = false;
            trackBarGama.Enabled = false;
            btnSaveConfig.Enabled = false;
        }

        private void lbPlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var playerIndex = lbPlayerList.SelectedIndex;

            if (0 > playerIndex)
            {
                MessageBox.Show("Please select a player to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();

            Form editor = new Editor(LoadedGamePath, PlayerList[playerIndex]);
            editor.ShowDialog();
        }

        private void btnSetRes640_Click(object sender, EventArgs e)
        {
            GameConfig["game_res"] = "4";
            btnSaveConfig.Enabled = true;
        }

        private void btnSetRes800_Click(object sender, EventArgs e)
        {
            GameConfig["game_res"] = "5";
            btnSaveConfig.Enabled = true;
        }

        private void btnSetRes1024_Click(object sender, EventArgs e)
        {
            GameConfig["game_res"] = "6";
            btnSaveConfig.Enabled = true;
        }


        private void trackBarGama_Scroll(object sender, EventArgs e)
        {
            GameConfig["gamma"] = trackBarGama.Value.ToString();
            lblGammaText.Text = trackBarGama.Value.ToString();
            btnSaveConfig.Enabled = true;
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(LoadedGamePath))
            {
                btnSaveConfig.Enabled = false;
                return;
            }

            FileFunctions.WriteConfigLine(Path.Combine(LoadedGamePath, Config.ConfigFile), "game_res", GameConfig["game_res"]);
            FileFunctions.WriteConfigLine(Path.Combine(LoadedGamePath, Config.ConfigFile), "gamma", GameConfig["gamma"]);

            switch (GameConfig["game_res"])
            {
                case "4":
                    lblSetResolutionText.Text = "640x480";
                    break;
                case "5":
                    lblSetResolutionText.Text = "800x600";
                    break;
                case "6":
                    lblSetResolutionText.Text = "1024x768";
                    break;
                default:
                    lblSetResolutionText.Text = "Unknown/Unsupported";
                    break;
            }

            btnSaveConfig.Enabled = false;
            lbPlayerList.Focus();
            BringToFront();
        }

        private void btnFindGame_Click(object sender, EventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();

                if (result != DialogResult.OK || string.IsNullOrEmpty(fbd.SelectedPath))
                    return;

                if (!FileFunctions.TestPath(fbd.SelectedPath))
                {
                    MessageBox.Show(Config.ConfigFile + " or your player files are missing from " + fbd.SelectedPath + ". Please try opening and closing the game first, or select a different path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetAllFields();
                    return;
                }

                ResetAllFields();

                LoadedGamePath = fbd.SelectedPath;
                Settings.Default.GamePath = fbd.SelectedPath;
                Settings.Default.Save();

                PopulateForm(fbd.SelectedPath);

            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNovaHQ_Click(object sender, EventArgs e)
        {
            Common.GoToNovaHq();
        }

        private void lblFacebook_Click_1(object sender, EventArgs e)
        {
            Process.Start(Config.FacebookUrl);
        }

    }

}