using Easy.WinAPI.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Easy.WinAPI
{
    public class EasyWinAPI
    {
        #region 封装API方法
        /// <summary>
        /// 找到句柄
        /// </summary>
        /// <param name="IpClassName">类名</param>
        /// <returns></returns>
        public static IntPtr GetHandle(string IpClassName)
        {
            return WinAPIWrapper.FindWindow(IpClassName, null);
        }

        /// <summary>
        /// 找到句柄
        /// </summary>
        /// <param name="p">坐标</param>
        /// <returns></returns>
        public static IntPtr GetHandle(Point p)
        {
            return WinAPIWrapper.WindowFromPoint(p);
        }

        //鼠标位置的坐标
        public static Point GetCursorPosPoint()
        {
            Point p = new Point();
            if (WinAPIWrapper.GetCursorPos(out p))
            {
                return p;
            }
            return default(Point);
        }

        /// <summary>
        /// 子窗口句柄
        /// </summary>
        /// <param name="hwndParent">父窗口句柄</param>
        /// <param name="hwndChildAfter">前一个同目录级同名窗口句柄</param>
        /// <param name="lpszClass">类名</param>
        /// <returns></returns>
        public static IntPtr GetChildHandle(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass)
        {
            return WinAPIWrapper.FindWindowEx(hwndParent, hwndChildAfter, lpszClass, null);
        }

        /// <summary>
        /// 全部子窗口句柄
        /// </summary>
        /// <param name="hwndParent">父窗口句柄</param>
        /// <param name="className">类名</param>
        /// <returns></returns>
        public static List<IntPtr> GetChildHandles(IntPtr hwndParent, string className)
        {
            List<IntPtr> resultList = new List<IntPtr>();
            for (IntPtr hwndClient = GetChildHandle(hwndParent, IntPtr.Zero, className); hwndClient != IntPtr.Zero; hwndClient = GetChildHandle(hwndParent, hwndClient, className))
            {
                resultList.Add(hwndClient);
            }
            return resultList;
        }

        /// <summary>
        /// 给窗口发送内容
        /// </summary>
        /// <param name="hWnd">句柄</param>
        /// <param name="lParam">要发送的内容</param>
        public static void SetText(IntPtr hWnd, string lParam)
        {
            WinAPIWrapper.SendMessage(hWnd, WinAPIWrapper.WM_SETTEXT, IntPtr.Zero, lParam);
        }

        /// <summary>
        /// 获得窗口内容或标题
        /// </summary>
        /// <param name="hWnd">句柄</param>
        /// <returns></returns>
        public static string GetText(IntPtr hWnd)
        {
            StringBuilder result = new StringBuilder(128);
            WinAPIWrapper.GetWindowText(hWnd, result, result.Capacity);
            return result.ToString();
        }

        /// <summary>
        /// 找类名
        /// </summary>
        /// <param name="hWnd">句柄</param>
        /// <returns></returns>
        public static string GetClassName(IntPtr hWnd)
        {
            StringBuilder lpClassName = new StringBuilder(128);
            if (WinAPIWrapper.GetClassName(hWnd, lpClassName, lpClassName.Capacity) == 0)
            {
                throw new Exception("not found IntPtr!");
            }
            return lpClassName.ToString();
        }

        /// <summary>
        /// 窗口在屏幕位置
        /// </summary>
        /// <param name="hWnd">句柄</param>
        /// <returns></returns>
        public static Rectangle GetWindowRect(IntPtr hWnd)
        {
            Rectangle result = default(Rectangle);
            WinAPIWrapper.GetWindowRect(hWnd, ref result);
            return result;
        }

        /// <summary>
        /// 窗口相对屏幕位置转换成父窗口位置
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static Rectangle ScreenToClient(IntPtr hWnd, Rectangle rect)
        {
            Rectangle result = rect;
            WinAPIWrapper.ScreenToClient(hWnd, ref result);
            return result;
        }

        /// <summary>
        /// 窗口大小
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static Rectangle GetClientRect(IntPtr hWnd)
        {
            Rectangle result = default(Rectangle);
            WinAPIWrapper.GetClientRect(hWnd, ref result);
            return result;
        }

        public static void GetInfo(IntPtr vHandle)
        {
            WinAPIWrapper.SendMessage(vHandle, WinAPIWrapper.WM_COMMAND, WinAPIWrapper.IDM_VIEWSOURCE, (int)vHandle);
        }

        /// <summary>
        /// 真实的鼠标操作
        /// </summary>
        /// <param name="dwFlags"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <returns></returns>
        public static int DeviceMouseEvent(int dwFlags, int dx, int dy)
        {
            return WinAPIWrapper.mouse_event(dwFlags, dx, dy, 0, 0);
        }

        public static void MouseClick(IntPtr vHandle, int x, int y)
        {
            var lParam = ((y << 16) | x); // The coordinates 
            var wParam = 0; // Additional parameters for the click (e.g. Ctrl) 
            WinAPIWrapper.SendMessage(vHandle, WinAPIWrapper.WM_LBUTTONDOWN, wParam, lParam); // Mouse button down 
            WinAPIWrapper.SendMessage(vHandle, WinAPIWrapper.WM_LBUTTONUP, wParam, lParam); // Mouse button up 
            //SendMessage(handle, upCode, wParam, lParam); // Mouse button up 
        }

        public static void MouseEvent(IntPtr vHandle, uint msg, int x, int y)
        {
            var lParam = ((y << 16) | x); // The coordinates 
            var wParam = 0; // Additional parameters for the click (e.g. Ctrl) 
            WinAPIWrapper.SendMessage(vHandle, msg, wParam, lParam); // Mouse button down 
            //SendMessage(vHandle, Win32ApiWrapper.WM_LBUTTONUP, wParam, lParam); // Mouse button up 
            //SendMessage(handle, upCode, wParam, lParam); // Mouse button up 
        }

        public static int MakeLParam(int LoWord, int HiWord)
        {
            //var lParam = ((y << 16) | x); // The coordinates 
            //var wParam = 1; // Additional parameters for the click (e.g. Ctrl) 
            return ((HiWord << 16) | (LoWord & 0xffff));
        }

        /// <summary>
        /// 获取桌面所有的窗口
        /// </summary>
        /// <returns></returns>
        public static WindowInfo[] GetAllDesktopWindows()
        {
            List<WindowInfo> wndList = new List<WindowInfo>();
            WinAPIWrapper.EnumWindows(delegate (IntPtr hWnd, int lParam)
            {
                WindowInfo wnd = new WindowInfo();
                StringBuilder sb = new StringBuilder(256);
                wnd.hWnd = hWnd;
                WinAPIWrapper.GetWindowTextW(hWnd, sb, sb.Capacity);
                wnd.SzWindowName = sb.ToString();
                WinAPIWrapper.GetClassNameW(hWnd, sb, sb.Capacity);
                wnd.SzClassName = sb.ToString();
                wndList.Add(wnd);
                return true;
            }, 0);
            return wndList.ToArray();
        }


        public static List<WindowInfo> GetWindowByParentHwndAndClassName(IntPtr parentHwnd, string className)
        {
            List<WindowInfo> wndList = new List<WindowInfo>();
            WinAPIWrapper.EnumChildWindows(parentHwnd, delegate (IntPtr hWnd, int lParam)
            {
                WindowInfo wnd = new WindowInfo();
                StringBuilder sb = new StringBuilder(256);
                wnd.hWnd = hWnd;
                WinAPIWrapper.GetWindowTextW(hWnd, sb, sb.Capacity);
                wnd.SzWindowName = sb.ToString();
                WinAPIWrapper.GetClassNameW(hWnd, sb, sb.Capacity);
                wnd.SzClassName = sb.ToString();
                wndList.Add(wnd);
                return true;
            }, 0);
            return wndList.Where(o => o.SzClassName == className).ToList();
        }

        public static List<WindowInfo> GetChildWindowsByParentHwnd(IntPtr parentHwnd)
        {
            List<WindowInfo> childWndList = new List<WindowInfo>();
            WinAPIWrapper.EnumChildWindows(parentHwnd, delegate (IntPtr hWnd, int lParam)
            {
                WindowInfo wnd = new WindowInfo();
                StringBuilder sb = new StringBuilder(256);
                wnd.hWnd = hWnd;
                WinAPIWrapper.GetWindowTextW(hWnd, sb, sb.Capacity);
                wnd.SzWindowName = sb.ToString();
                WinAPIWrapper.GetClassNameW(hWnd, sb, sb.Capacity);
                wnd.SzClassName = sb.ToString();
                childWndList.Add(wnd);
                return true;
            }, 0);
            return childWndList;
        }

        /// <summary>
        /// 注册热键
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="modifiers"></param>
        /// <returns></returns>
        public static bool RegisterHotKey(IntPtr handle, int id, EasyModifierKeys modifiers, EasyKey key)
        {
            var virtualCode = EasyKeyInterop.VirtualKeyFromKey(key);
            return RegisterHotKey(handle, id, (uint)virtualCode, (uint)modifiers);
        }

        /// <summary>
        /// 注册热键
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="id"></param>
        /// <param name="virtualCode"></param>
        /// <param name="modifiers"></param>
        /// <returns></returns>
        public static bool RegisterHotKey(IntPtr handle, int id, uint modifiers, uint virtualCode)
        {
            return WinAPIWrapper.RegisterHotKey(handle, id, (uint)modifiers, virtualCode);
        }

        /// <summary>
        /// 反注册热键
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool UnRegisterHotKey(IntPtr handle, int id)
        {
            return WinAPIWrapper.UnregisterHotKey(handle, id);
        }

        /// <summary>
        /// 获取某 URL 的 Cookie 返回字符串
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string GetCookie(string Url)
        {
            uint Datasize = 1024;
            StringBuilder cookieData = new StringBuilder((int)Datasize);
            if (!WinAPIWrapper.InternetGetCookieEx(Url, null, cookieData, ref Datasize, 0x2000, IntPtr.Zero))
            {
                if (Datasize < 0)
                {
                    return null;
                }
                cookieData = new StringBuilder((int)Datasize);
                if (!WinAPIWrapper.InternetGetCookieEx(Url, null, cookieData, ref Datasize, 0x00002000, IntPtr.Zero))
                {
                    return null;
                }
            }
            return cookieData.ToString();
        }

        /// <summary>
        /// 全局修改UserAgent
        /// </summary>
        public static void SetUserAgent(string userAgent)
        {
            WinAPIWrapper.UrlMkSetSessionOption(WinAPIWrapper.URLMON_OPTION_USERAGENT, userAgent, userAgent.Length, 0);
        }

        //private static string GetDefaultUserAgent()
        //{
        //    WebBrowser wb = new WebBrowser();
        //    wb.Navigate("about:blank");
        //    while (wb.IsBusy) Application.DoEvents();
        //    object window = wb.Document.Window.DomWindow;
        //    Type wt = window.GetType();
        //    object navigator = wt.InvokeMember("navigator", BindingFlags.GetProperty,
        //        null, window, new object[] { });
        //    Type nt = navigator.GetType();
        //    object userAgent = nt.InvokeMember("userAgent", BindingFlags.GetProperty,
        //        null, navigator, new object[] { });
        //    return userAgent.ToString();
        //}

        #endregion


    }
}
