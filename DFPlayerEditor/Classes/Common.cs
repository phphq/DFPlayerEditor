using System.Diagnostics;

namespace DFPlayerEditor.Classes
{
    public static class Common
    {
        public static void GoToNovaHq()
        {
            Process.Start(Config.NoavHqUrlApp);
        }

    }

}