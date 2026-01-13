using System.Drawing;

namespace SenSoutenance.Shared
{
    public static class StyleHelper
    {
        public static readonly Color Primary   = Color.FromArgb(41, 128, 185); // blue
        public static readonly Color Danger    = Color.FromArgb(231, 76, 60); // red
        public static readonly Color Success   = Color.FromArgb(39, 174, 96); // green
        public static readonly Color Warning   = Color.FromArgb(230, 126, 34); // orange
        public static readonly Color LightGray = Color.FromArgb(236, 240, 241);
        public static readonly Font   DefaultFont = new Font("Segoe UI", 9.75F);
    }
}
