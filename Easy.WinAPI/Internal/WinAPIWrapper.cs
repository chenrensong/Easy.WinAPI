using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Easy.WinAPI
{
    internal sealed class WinAPIWrapper
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern short GetKeyState(int nVirtKey);

        /// <summary>
        /// 注册热键
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="id"></param>
        /// <param name="modifiers"></param>
        /// <param name="virtualCode"></param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr handle, int id, uint modifiers, uint virtualCode);

        /// <summary>
        /// 反注册热键
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr handle, int id);

        [DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
        public static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);

        /// <summary>
        /// 获取当前WebBrowser登录后的Cookie字符串
        /// </summary>
        /// <param name="pchUrl"></param>
        /// <param name="pchCookieName"></param>
        /// <param name="pchCookieData"></param>
        /// <param name="pcchCookieData"></param>
        /// <param name="dwFlags"></param>
        /// <param name="lpReserved"></param>
        /// <returns></returns>
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetGetCookieEx(string pchUrl, string pchCookieName, StringBuilder pchCookieData, ref System.UInt32 pcchCookieData, int dwFlags, IntPtr lpReserved);

        public delegate bool WNDENUMPROC(IntPtr hWnd, int lParam);

        /// <summary>
        /// 鼠标 移动
        /// </summary>
        /// <param name="dwFlags"></param>
        /// <param name="dx">DX=需要移动的X*65536/取屏幕宽度 ()+1</param>
        /// <param name="dy">DY=需要移动的Y*65536/取屏幕高度 ()+1</param>
        /// <param name="cButtons"></param>
        /// <param name="dwExtraInfo"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("Gdi32.dll")]
        public extern static int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public extern static IntPtr GetWindow(IntPtr hWnd, int wCmd);

        [DllImport("user32.dll", EntryPoint = "GetParent")]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll ")]
        public static extern IntPtr FindWindowEx(IntPtr parent, IntPtr childe, string strclass, string FrmText);

        [DllImport("user32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int GetWindowTextW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, [Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, int lParam);

        [DllImport("user32.dll")]
        public static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern bool EnumChildWindows(IntPtr hWndParent, WNDENUMPROC lpEnumFunc, int lParam);

        [DllImport("user32.dll", EntryPoint = "WindowFromPoint", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr WindowFromPoint(Point pt);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowRect(IntPtr hwnd, ref Rectangle rc);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClientRect(IntPtr hwnd, ref Rectangle rc);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MoveWindow(IntPtr hwnd, int x, int y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int ScreenToClient(IntPtr hWnd, ref Rectangle rect);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);
        /// <summary>   
        /// 得到当前活动的窗口   
        /// </summary>   
        /// <returns></returns>   
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern System.IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendTxtMessage(int hWnd,
            // handle to destination window               
            int Msg, // message               
            int wParam, // first message parameter               
            char[] lParam             // int  lParam // second message parameter           
          );

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendTxtMessage(int hWnd,
          // handle to destination window               
          int Msg, // message               
          int wParam, // first message parameter               
          string lParam             // int  lParam // second message parameter           
          );

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(int hWnd, int Msg, int wParam, ref CopyDataStruct lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(
            int hWnd, // handle to destination window               
            int Msg, // message               
            int wParam, // first message parameter                
            int lParam // second message parameter         
            );

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        /// <summary>
        /// 得到光标的位置
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "GetCursorPos")]
        public static extern bool GetCursorPos(out Point pt);
        /// <summary>
        /// 移动光标的位置
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [DllImport("user32.dll")]
        public static extern void SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int Width, int Height, uint flags);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern bool SetWindowPos(IntPtr hWnd, int HWND_TOPMOST, int x, int y, int Width, int Height, uint flags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "PostMessage")]
        public static extern IntPtr PostMessage(IntPtr hwndParent, int hwndChildAfter, IntPtr wParam, string lpszWindow);


    }
}
