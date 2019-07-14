using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Easy.WinAPI
{

    public struct CopyDataStruct
    {
        public IntPtr dwData; //可以是任意值
        public int cbData;    //指定lpData内存区域的字节数
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpData; //发送给目录窗口所在进程的数据
    }

    public enum WM_SYSCOMMAND_WPARAM
    {
        SC_FIRST = 0xF000,

        // Sizes the window.
        SC_SIZE = SC_FIRST,

        // Moves the window.
        SC_MOVE = SC_FIRST + 0x10,

        // Minimizes the window.
        SC_MINIMIZE = SC_FIRST + 0x20,

        // Maximizes the window.
        SC_MAXIMIZE = SC_FIRST + 0x30,

        // Moves to the next window.
        SC_NEXTWINDOW = SC_FIRST + 0x40,

        // Moves to the previous window.
        SC_PREVWINDOW = SC_FIRST + 0x50,

        // Closes the window.
        SC_CLOSE = SC_FIRST + 0x60,

        //Scrolls vertically
        SC_VSCROLL = SC_FIRST + 0x70,

        // Scrolls horizontally.
        SC_HSCROLL = SC_FIRST + 0x80,

        // Retrieves the window menu as a result of a mouse click.
        SC_MOUSEMENU = SC_FIRST + 0x90,

        // Retrieves the window menu as a result of a keystroke.
        // For more information, see the Remarks section.
        SC_KEYMENU = SC_FIRST + 0x100,

        SC_ARRANGE = SC_FIRST + 0x110,

        // Restores the window to its normal position and size.
        SC_RESTORE = SC_FIRST + 0x120,

        // Activates the Start menu.
        SC_TASKLIST = SC_FIRST + 0x130,

        // Executes the screen saver application specified 
        // in the [boot] section of the System.ini file.
        SC_SCREENSAVE = SC_FIRST + 0x140,

        // Activates the window associated with the application-specified hot key. 
        // The lParam parameter identifies the window to activate.
        SC_HOTKEY = SC_FIRST + 0x150,

        // Selects the default item; 
        // the user double-clicked the window menu.
        SC_DEFAULT = SC_FIRST + 0x160,

        // Sets the state of the display.
        // This command supports devices that have power-saving features,
        // such as a battery-powered personal computer.
        // The lParam parameter can have the following values:
        // -1 - the display is powering on
        //  1 - the display is going to low power
        //  2 - the display is being shut off
        SC_MONITORPOWER = SC_FIRST + 0x170,

        // Changes the cursor to a question mark with a pointer. 
        // If the user then clicks a control in the dialog box, 
        // the control receives a WM_HELP message.
        SC_CONTEXTHELP = SC_FIRST + 0x180,

        SC_SEPARATOR = 0xF00F
    }
}
