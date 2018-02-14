using System.Collections.Generic;

namespace DFPlayerEditor.Classes
{
    public class Player
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public List<string> Macros { get; set; }

        public Player()
        {
            Index = -1;
            Name = "";
            Macros = new List<string>();

        }

    }

}