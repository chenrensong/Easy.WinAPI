using System;

namespace Easy.WinAPI
{
    public class WindowInfo
    {
        public IntPtr hWnd { get; set; }

        public string SzWindowName { get; set; }

        public string SzClassName { get; set; }
    }
}
