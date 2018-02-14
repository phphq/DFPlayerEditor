using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using DFPlayerEditor.Classes;

namespace DFPlayerEditor.Forms
{
    public partial class Editor : Form
    {
 
        private TextBox FocusedTextbox;

        private readonly string LoadedGamePath;

        private readonly Player LoadedPlayer;

        private readonly Dictionary<int, TextBox> TextBoxDict;

        public Editor(string path, Player player)
        {
            InitializeComponent();

            LoadedGamePath = path;
            LoadedPlayer = player;

            TextBoxDict = new Dictionary<int, TextBox>
            {
                { 0, tbMacro0 },
                { 1, tbMacro1 },
                { 2, tbMacro2 },
                { 3, tbMacro3 },
                { 4, tbMacro4 },
                { 5, tbMacro5 },
                { 6, tbMacro6 },
                { 7, tbMacro7 },
                { 8, tbMacro8 },
                { 9, tbMacro9 },
            };

        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void Editor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }

        private void DrawTextBoxLines(object sender, PaintEventArgs e)
        {

            var p = new Pen(Color.Lime, 1);
            var g = e.Graphics;

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    g.DrawRectangle(p, new Rectangle(control.Location.X - 2, control.Location.Y - 2, control.Width + 2, control.Height + 3));

            }

            g.Dispose();

        }

        private void Editor_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    control.Enter += TextBox_Focused;
            }

            tbPlayerName.Text = LoadedPlayer.Name;

            var i = 0;
            foreach (var macro in LoadedPlayer.Macros)
            {

                if (!TextBoxDict.ContainsKey(i))
                    continue;

                TextBoxDict[i].Text = macro;
                i++;
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var f = new Main();
            f.Show();
        }

        private void TextBox_Focused(object sender, EventArgs e)
        {
            FocusedTextbox = (TextBox)sender;
        }

        private void InsertCharToTextBox(string specialChar)
        {
            if (FocusedTextbox == null)
                return;

            var startAt = FocusedTextbox.SelectionStart;

            FocusedTextbox.Text = FocusedTextbox.Text.Insert(startAt, specialChar);

            if (FocusedTextbox.Text.Length > FocusedTextbox.MaxLength)
                FocusedTextbox.Text = FocusedTextbox.Text.Substring(0, FocusedTextbox.MaxLength);

            FocusedTextbox.Select(startAt + 1, 0);
            FocusedTextbox.Focus();
        }

        private void btnOpenCharmap_Click(object sender, EventArgs e)
        {
            string charMapFile;

            if (File.Exists(@"C:\Windows\System32\charmap.exe"))
            {
                charMapFile = @"C:\Windows\System32\charmap.exe";

            }
            else if (File.Exists(@"C:\Windows\charmap.exe"))
            {
                charMapFile = @"C:\Windows\charmap.exe";
            }
            else
            {
                MessageBox.Show("Cannot locate charmap.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var p = new Process
            {
                StartInfo = { FileName = charMapFile }
            };

            p.Start();
        }

        private void btnEmote_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (!Config.EmoteDict.ContainsKey(button.Name))
                return;

            InsertCharToTextBox(Config.EmoteDict[button.Name]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var writeData = new List<PlayerSaveFile>();

            var playerOffset = Config.PlayerStartOffset;

            writeData.Add(new PlayerSaveFile
            {
                Offset = Config.PlayerNewOffset,
                Length = 1,
                String = "1"
            });

            writeData.Add(new PlayerSaveFile
            {
                Offset = playerOffset,
                Length = Config.PlayerNameMaxLength,
                String = tbPlayerName.Text
            });

            var i = 0;
            foreach (var macro in TextBoxDict)
            {
                var macroOffset = Config.PlayerMacroOffset + (Config.PlayerMacroNextOffset * i);

                writeData.Add(new PlayerSaveFile
                {
                    Offset = macroOffset,
                    Length = Config.PlayerMacroMaxLength,
                    String = macro.Value.Text
                });

                i++;
            }

            var result = FileFunctions.WriteToSaveFile(Path.Combine(LoadedGamePath, Config.PlayerFiles[LoadedPlayer.Index]), writeData);

            if (!result.Success)
            {
                MessageBox.Show(result.ErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnClose_Click(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}