using System;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

using DFPlayerEditor.Forms;

namespace DFPlayerEditor
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

    }

    public static class Config
    {
        public static bool ProgramDebug;

        public static string ProgramName = "DF Player Editor";

        public static string ProgramVersion = Assembly.GetCallingAssembly().GetName().Version.Major + "." + Assembly.GetCallingAssembly().GetName().Version.Minor;

        public static string NoavHqUrl = "http://novahq.net/";
        public static string NoavHqUrlApp = NoavHqUrl + "?app=DFPlayerEditor" + ProgramVersion;

        public static string FacebookUrl = "https://www.facebook.com/groups/dfworld/";

        public static int PlayerStartOffset = 0x4;
        public static int PlayerNewOffset = 0x24;
        public static int PlayerNameMaxLength = 15;
        public static int PlayerMaxCount = 9;

        public static int PlayerMacroOffset = 0x4b0;
        public static int PlayerMacroNextOffset = 0x28;
        public static int PlayerMacroMaxCount = 10;
        public static int PlayerMacroMaxLength = 39;

        public static string DefaultGamePath1 = @"C:\Program Files\NovaLogic\Delta Force\";
        public static string DefaultGamePath2 = @"C:\Program Files (x86)\NovaLogic\Delta Force\";
        public static string ConfigFile = "df.cfg";

        public static Dictionary<int, string> PlayerFiles = new Dictionary<int, string>
        {
            {0, "player01.ply" },
            {1, "player02.ply" },
            {2, "player03.ply" },
            {3, "player04.ply" },
            {4, "player05.ply" },
            {5, "player06.ply" },
            {6, "player07.ply" },
            {7, "player08.ply" },
            {8, "player09.ply" },
            
        };

        public static Dictionary<string, string> EmoteDict = new Dictionary<string, string>
        {
            {"btnA", "\x01"}, //Mag
            {"btnN", "\x02"}, //North
            {"btnE", "\x04"}, //East
            {"btnS", "\x03"}, //South
            {"btnW", "\x05"}, //West
           
        };

    }

}