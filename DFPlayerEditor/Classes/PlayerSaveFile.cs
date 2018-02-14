
namespace DFPlayerEditor.Classes
{
    public class PlayerSaveFile
    {
        public int Offset { get; set; }
        public int Length { get; set; }
        public string String { get; set; }

        public PlayerSaveFile()
        {
            Offset = 0x0;
            Length = 0;
            String = "";
        }

    }

}