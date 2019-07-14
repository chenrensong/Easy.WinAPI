using System;
using System.Collections.Generic;
using System.Text;

namespace Easy.WinAPI.Input
{
    /// <summary>
    ///     Provides static methods to convert between Win32 VirtualKeys
    ///     and our EasyKey enum.
    /// </summary>
    public static class EasyKeyInterop
    {
        /// <summary>
        ///     Convert a Win32 VirtualKey into our EasyKey enum.
        /// </summary>
        public static EasyKey KeyFromVirtualKey(int virtualKey)
        {
            EasyKey key = EasyKey.None;
            switch (virtualKey)
            {
                case NativeMethods.VK_CANCEL:
                    key = EasyKey.Cancel;
                    break;

                case NativeMethods.VK_BACK:
                    key = EasyKey.Back;
                    break;

                case NativeMethods.VK_TAB:
                    key = EasyKey.Tab;
                    break;

                case NativeMethods.VK_CLEAR:
                    key = EasyKey.Clear;
                    break;

                case NativeMethods.VK_RETURN:
                    key = EasyKey.Return;
                    break;

                case NativeMethods.VK_PAUSE:
                    key = EasyKey.Pause;
                    break;

                case NativeMethods.VK_CAPITAL:
                    key = EasyKey.Capital;
                    break;

                case NativeMethods.VK_KANA:
                    key = EasyKey.KanaMode;
                    break;

                case NativeMethods.VK_JUNJA:
                    key = EasyKey.JunjaMode;
                    break;

                case NativeMethods.VK_FINAL:
                    key = EasyKey.FinalMode;
                    break;

                case NativeMethods.VK_KANJI:
                    key = EasyKey.KanjiMode;
                    break;

                case NativeMethods.VK_ESCAPE:
                    key = EasyKey.Escape;
                    break;

                case NativeMethods.VK_CONVERT:
                    key = EasyKey.ImeConvert;
                    break;

                case NativeMethods.VK_NONCONVERT:
                    key = EasyKey.ImeNonConvert;
                    break;

                case NativeMethods.VK_ACCEPT:
                    key = EasyKey.ImeAccept;
                    break;

                case NativeMethods.VK_MODECHANGE:
                    key = EasyKey.ImeModeChange;
                    break;

                case NativeMethods.VK_SPACE:
                    key = EasyKey.Space;
                    break;

                case NativeMethods.VK_PRIOR:
                    key = EasyKey.Prior;
                    break;

                case NativeMethods.VK_NEXT:
                    key = EasyKey.Next;
                    break;

                case NativeMethods.VK_END:
                    key = EasyKey.End;
                    break;

                case NativeMethods.VK_HOME:
                    key = EasyKey.Home;
                    break;

                case NativeMethods.VK_LEFT:
                    key = EasyKey.Left;
                    break;

                case NativeMethods.VK_UP:
                    key = EasyKey.Up;
                    break;

                case NativeMethods.VK_RIGHT:
                    key = EasyKey.Right;
                    break;

                case NativeMethods.VK_DOWN:
                    key = EasyKey.Down;
                    break;

                case NativeMethods.VK_SELECT:
                    key = EasyKey.Select;
                    break;

                case NativeMethods.VK_PRINT:
                    key = EasyKey.Print;
                    break;

                case NativeMethods.VK_EXECUTE:
                    key = EasyKey.Execute;
                    break;

                case NativeMethods.VK_SNAPSHOT:
                    key = EasyKey.Snapshot;
                    break;

                case NativeMethods.VK_INSERT:
                    key = EasyKey.Insert;
                    break;

                case NativeMethods.VK_DELETE:
                    key = EasyKey.Delete;
                    break;

                case NativeMethods.VK_HELP:
                    key = EasyKey.Help;
                    break;

                case NativeMethods.VK_0:
                    key = EasyKey.D0;
                    break;

                case NativeMethods.VK_1:
                    key = EasyKey.D1;
                    break;

                case NativeMethods.VK_2:
                    key = EasyKey.D2;
                    break;

                case NativeMethods.VK_3:
                    key = EasyKey.D3;
                    break;

                case NativeMethods.VK_4:
                    key = EasyKey.D4;
                    break;

                case NativeMethods.VK_5:
                    key = EasyKey.D5;
                    break;

                case NativeMethods.VK_6:
                    key = EasyKey.D6;
                    break;

                case NativeMethods.VK_7:
                    key = EasyKey.D7;
                    break;

                case NativeMethods.VK_8:
                    key = EasyKey.D8;
                    break;

                case NativeMethods.VK_9:
                    key = EasyKey.D9;
                    break;

                case NativeMethods.VK_A:
                    key = EasyKey.A;
                    break;

                case NativeMethods.VK_B:
                    key = EasyKey.B;
                    break;

                case NativeMethods.VK_C:
                    key = EasyKey.C;
                    break;

                case NativeMethods.VK_D:
                    key = EasyKey.D;
                    break;

                case NativeMethods.VK_E:
                    key = EasyKey.E;
                    break;

                case NativeMethods.VK_F:
                    key = EasyKey.F;
                    break;

                case NativeMethods.VK_G:
                    key = EasyKey.G;
                    break;

                case NativeMethods.VK_H:
                    key = EasyKey.H;
                    break;

                case NativeMethods.VK_I:
                    key = EasyKey.I;
                    break;

                case NativeMethods.VK_J:
                    key = EasyKey.J;
                    break;

                case NativeMethods.VK_K:
                    key = EasyKey.K;
                    break;

                case NativeMethods.VK_L:
                    key = EasyKey.L;
                    break;

                case NativeMethods.VK_M:
                    key = EasyKey.M;
                    break;

                case NativeMethods.VK_N:
                    key = EasyKey.N;
                    break;

                case NativeMethods.VK_O:
                    key = EasyKey.O;
                    break;

                case NativeMethods.VK_P:
                    key = EasyKey.P;
                    break;

                case NativeMethods.VK_Q:
                    key = EasyKey.Q;
                    break;

                case NativeMethods.VK_R:
                    key = EasyKey.R;
                    break;

                case NativeMethods.VK_S:
                    key = EasyKey.S;
                    break;

                case NativeMethods.VK_T:
                    key = EasyKey.T;
                    break;

                case NativeMethods.VK_U:
                    key = EasyKey.U;
                    break;

                case NativeMethods.VK_V:
                    key = EasyKey.V;
                    break;

                case NativeMethods.VK_W:
                    key = EasyKey.W;
                    break;

                case NativeMethods.VK_X:
                    key = EasyKey.X;
                    break;

                case NativeMethods.VK_Y:
                    key = EasyKey.Y;
                    break;

                case NativeMethods.VK_Z:
                    key = EasyKey.Z;
                    break;

                case NativeMethods.VK_LWIN:
                    key = EasyKey.LWin;
                    break;

                case NativeMethods.VK_RWIN:
                    key = EasyKey.RWin;
                    break;

                case NativeMethods.VK_APPS:
                    key = EasyKey.Apps;
                    break;

                case NativeMethods.VK_SLEEP:
                    key = EasyKey.Sleep;
                    break;

                case NativeMethods.VK_NUMPAD0:
                    key = EasyKey.NumPad0;
                    break;

                case NativeMethods.VK_NUMPAD1:
                    key = EasyKey.NumPad1;
                    break;

                case NativeMethods.VK_NUMPAD2:
                    key = EasyKey.NumPad2;
                    break;

                case NativeMethods.VK_NUMPAD3:
                    key = EasyKey.NumPad3;
                    break;

                case NativeMethods.VK_NUMPAD4:
                    key = EasyKey.NumPad4;
                    break;

                case NativeMethods.VK_NUMPAD5:
                    key = EasyKey.NumPad5;
                    break;

                case NativeMethods.VK_NUMPAD6:
                    key = EasyKey.NumPad6;
                    break;

                case NativeMethods.VK_NUMPAD7:
                    key = EasyKey.NumPad7;
                    break;

                case NativeMethods.VK_NUMPAD8:
                    key = EasyKey.NumPad8;
                    break;

                case NativeMethods.VK_NUMPAD9:
                    key = EasyKey.NumPad9;
                    break;

                case NativeMethods.VK_MULTIPLY:
                    key = EasyKey.Multiply;
                    break;

                case NativeMethods.VK_ADD:
                    key = EasyKey.Add;
                    break;

                case NativeMethods.VK_SEPARATOR:
                    key = EasyKey.Separator;
                    break;

                case NativeMethods.VK_SUBTRACT:
                    key = EasyKey.Subtract;
                    break;

                case NativeMethods.VK_DECIMAL:
                    key = EasyKey.Decimal;
                    break;

                case NativeMethods.VK_DIVIDE:
                    key = EasyKey.Divide;
                    break;

                case NativeMethods.VK_F1:
                    key = EasyKey.F1;
                    break;

                case NativeMethods.VK_F2:
                    key = EasyKey.F2;
                    break;

                case NativeMethods.VK_F3:
                    key = EasyKey.F3;
                    break;

                case NativeMethods.VK_F4:
                    key = EasyKey.F4;
                    break;

                case NativeMethods.VK_F5:
                    key = EasyKey.F5;
                    break;

                case NativeMethods.VK_F6:
                    key = EasyKey.F6;
                    break;

                case NativeMethods.VK_F7:
                    key = EasyKey.F7;
                    break;

                case NativeMethods.VK_F8:
                    key = EasyKey.F8;
                    break;

                case NativeMethods.VK_F9:
                    key = EasyKey.F9;
                    break;

                case NativeMethods.VK_F10:
                    key = EasyKey.F10;
                    break;

                case NativeMethods.VK_F11:
                    key = EasyKey.F11;
                    break;

                case NativeMethods.VK_F12:
                    key = EasyKey.F12;
                    break;

                case NativeMethods.VK_F13:
                    key = EasyKey.F13;
                    break;

                case NativeMethods.VK_F14:
                    key = EasyKey.F14;
                    break;

                case NativeMethods.VK_F15:
                    key = EasyKey.F15;
                    break;

                case NativeMethods.VK_F16:
                    key = EasyKey.F16;
                    break;

                case NativeMethods.VK_F17:
                    key = EasyKey.F17;
                    break;

                case NativeMethods.VK_F18:
                    key = EasyKey.F18;
                    break;

                case NativeMethods.VK_F19:
                    key = EasyKey.F19;
                    break;

                case NativeMethods.VK_F20:
                    key = EasyKey.F20;
                    break;

                case NativeMethods.VK_F21:
                    key = EasyKey.F21;
                    break;

                case NativeMethods.VK_F22:
                    key = EasyKey.F22;
                    break;

                case NativeMethods.VK_F23:
                    key = EasyKey.F23;
                    break;

                case NativeMethods.VK_F24:
                    key = EasyKey.F24;
                    break;

                case NativeMethods.VK_NUMLOCK:
                    key = EasyKey.NumLock;
                    break;

                case NativeMethods.VK_SCROLL:
                    key = EasyKey.Scroll;
                    break;

                case NativeMethods.VK_SHIFT:
                case NativeMethods.VK_LSHIFT:
                    key = EasyKey.LeftShift;
                    break;

                case NativeMethods.VK_RSHIFT:
                    key = EasyKey.RightShift;
                    break;

                case NativeMethods.VK_CONTROL:
                case NativeMethods.VK_LCONTROL:
                    key = EasyKey.LeftCtrl;
                    break;

                case NativeMethods.VK_RCONTROL:
                    key = EasyKey.RightCtrl;
                    break;

                case NativeMethods.VK_MENU:
                case NativeMethods.VK_LMENU:
                    key = EasyKey.LeftAlt;
                    break;

                case NativeMethods.VK_RMENU:
                    key = EasyKey.RightAlt;
                    break;

                case NativeMethods.VK_BROWSER_BACK:
                    key = EasyKey.BrowserBack;
                    break;

                case NativeMethods.VK_BROWSER_FORWARD:
                    key = EasyKey.BrowserForward;
                    break;

                case NativeMethods.VK_BROWSER_REFRESH:
                    key = EasyKey.BrowserRefresh;
                    break;

                case NativeMethods.VK_BROWSER_STOP:
                    key = EasyKey.BrowserStop;
                    break;

                case NativeMethods.VK_BROWSER_SEARCH:
                    key = EasyKey.BrowserSearch;
                    break;

                case NativeMethods.VK_BROWSER_FAVORITES:
                    key = EasyKey.BrowserFavorites;
                    break;

                case NativeMethods.VK_BROWSER_HOME:
                    key = EasyKey.BrowserHome;
                    break;

                case NativeMethods.VK_VOLUME_MUTE:
                    key = EasyKey.VolumeMute;
                    break;

                case NativeMethods.VK_VOLUME_DOWN:
                    key = EasyKey.VolumeDown;
                    break;

                case NativeMethods.VK_VOLUME_UP:
                    key = EasyKey.VolumeUp;
                    break;

                case NativeMethods.VK_MEDIA_NEXT_TRACK:
                    key = EasyKey.MediaNextTrack;
                    break;

                case NativeMethods.VK_MEDIA_PREV_TRACK:
                    key = EasyKey.MediaPreviousTrack;
                    break;

                case NativeMethods.VK_MEDIA_STOP:
                    key = EasyKey.MediaStop;
                    break;

                case NativeMethods.VK_MEDIA_PLAY_PAUSE:
                    key = EasyKey.MediaPlayPause;
                    break;

                case NativeMethods.VK_LAUNCH_MAIL:
                    key = EasyKey.LaunchMail;
                    break;

                case NativeMethods.VK_LAUNCH_MEDIA_SELECT:
                    key = EasyKey.SelectMedia;
                    break;

                case NativeMethods.VK_LAUNCH_APP1:
                    key = EasyKey.LaunchApplication1;
                    break;

                case NativeMethods.VK_LAUNCH_APP2:
                    key = EasyKey.LaunchApplication2;
                    break;

                case NativeMethods.VK_OEM_1:
                    key = EasyKey.OemSemicolon;
                    break;

                case NativeMethods.VK_OEM_PLUS:
                    key = EasyKey.OemPlus;
                    break;

                case NativeMethods.VK_OEM_COMMA:
                    key = EasyKey.OemComma;
                    break;

                case NativeMethods.VK_OEM_MINUS:
                    key = EasyKey.OemMinus;
                    break;

                case NativeMethods.VK_OEM_PERIOD:
                    key = EasyKey.OemPeriod;
                    break;

                case NativeMethods.VK_OEM_2:
                    key = EasyKey.OemQuestion;
                    break;

                case NativeMethods.VK_OEM_3:
                    key = EasyKey.OemTilde;
                    break;

                case NativeMethods.VK_C1:
                    key = EasyKey.AbntC1;
                    break;

                case NativeMethods.VK_C2:
                    key = EasyKey.AbntC2;
                    break;

                case NativeMethods.VK_OEM_4:
                    key = EasyKey.OemOpenBrackets;
                    break;

                case NativeMethods.VK_OEM_5:
                    key = EasyKey.OemPipe;
                    break;

                case NativeMethods.VK_OEM_6:
                    key = EasyKey.OemCloseBrackets;
                    break;

                case NativeMethods.VK_OEM_7:
                    key = EasyKey.OemQuotes;
                    break;

                case NativeMethods.VK_OEM_8:
                    key = EasyKey.Oem8;
                    break;

                case NativeMethods.VK_OEM_102:
                    key = EasyKey.OemBackslash;
                    break;

                case NativeMethods.VK_PROCESSKEY:
                    key = EasyKey.ImeProcessed;
                    break;

                case NativeMethods.VK_OEM_ATTN: // VK_DBE_ALPHANUMERIC
                    key = EasyKey.OemAttn;          // DbeAlphanumeric
                    break;

                case NativeMethods.VK_OEM_FINISH: // VK_DBE_KATAKANA
                    key = EasyKey.OemFinish;          // DbeKatakana
                    break;

                case NativeMethods.VK_OEM_COPY: // VK_DBE_HIRAGANA
                    key = EasyKey.OemCopy;          // DbeHiragana
                    break;

                case NativeMethods.VK_OEM_AUTO: // VK_DBE_SBCSCHAR
                    key = EasyKey.OemAuto;          // DbeSbcsChar
                    break;

                case NativeMethods.VK_OEM_ENLW: // VK_DBE_DBCSCHAR
                    key = EasyKey.OemEnlw;          // DbeDbcsChar
                    break;

                case NativeMethods.VK_OEM_BACKTAB: // VK_DBE_ROMAN
                    key = EasyKey.OemBackTab;          // DbeRoman
                    break;

                case NativeMethods.VK_ATTN: // VK_DBE_NOROMAN
                    key = EasyKey.Attn;         // DbeNoRoman
                    break;

                case NativeMethods.VK_CRSEL: // VK_DBE_ENTERWORDREGISTERMODE
                    key = EasyKey.CrSel;         // DbeEnterWordRegisterMode
                    break;

                case NativeMethods.VK_EXSEL: // VK_DBE_ENTERIMECONFIGMODE
                    key = EasyKey.ExSel;         // DbeEnterImeConfigMode
                    break;

                case NativeMethods.VK_EREOF: // VK_DBE_FLUSHSTRING
                    key = EasyKey.EraseEof;      // DbeFlushString
                    break;

                case NativeMethods.VK_PLAY: // VK_DBE_CODEINPUT
                    key = EasyKey.Play;         // DbeCodeInput
                    break;

                case NativeMethods.VK_ZOOM: // VK_DBE_NOCODEINPUT
                    key = EasyKey.Zoom;         // DbeNoCodeInput
                    break;

                case NativeMethods.VK_NONAME: // VK_DBE_DETERMINESTRING
                    key = EasyKey.NoName;         // DbeDetermineString
                    break;

                case NativeMethods.VK_PA1: // VK_DBE_ENTERDLGCONVERSIONMODE
                    key = EasyKey.Pa1;         // DbeEnterDlgConversionMode
                    break;

                case NativeMethods.VK_OEM_CLEAR:
                    key = EasyKey.OemClear;
                    break;

                default:
                    key = EasyKey.None;
                    break;
            }

            return key;
        }

        /// <summary>
        ///     Convert our EasyKey enum into a Win32 VirtualKey.
        /// </summary>
        public static int VirtualKeyFromKey(EasyKey key)
        {
            int virtualKey = 0;

            switch (key)
            {
                case EasyKey.Cancel:
                    virtualKey = NativeMethods.VK_CANCEL;
                    break;

                case EasyKey.Back:
                    virtualKey = NativeMethods.VK_BACK;
                    break;

                case EasyKey.Tab:
                    virtualKey = NativeMethods.VK_TAB;
                    break;

                case EasyKey.Clear:
                    virtualKey = NativeMethods.VK_CLEAR;
                    break;

                case EasyKey.Return:
                    virtualKey = NativeMethods.VK_RETURN;
                    break;

                case EasyKey.Pause:
                    virtualKey = NativeMethods.VK_PAUSE;
                    break;

                case EasyKey.Capital:
                    virtualKey = NativeMethods.VK_CAPITAL;
                    break;

                case EasyKey.KanaMode:
                    virtualKey = NativeMethods.VK_KANA;
                    break;

                case EasyKey.JunjaMode:
                    virtualKey = NativeMethods.VK_JUNJA;
                    break;

                case EasyKey.FinalMode:
                    virtualKey = NativeMethods.VK_FINAL;
                    break;

                case EasyKey.KanjiMode:
                    virtualKey = NativeMethods.VK_KANJI;
                    break;

                case EasyKey.Escape:
                    virtualKey = NativeMethods.VK_ESCAPE;
                    break;

                case EasyKey.ImeConvert:
                    virtualKey = NativeMethods.VK_CONVERT;
                    break;

                case EasyKey.ImeNonConvert:
                    virtualKey = NativeMethods.VK_NONCONVERT;
                    break;

                case EasyKey.ImeAccept:
                    virtualKey = NativeMethods.VK_ACCEPT;
                    break;

                case EasyKey.ImeModeChange:
                    virtualKey = NativeMethods.VK_MODECHANGE;
                    break;

                case EasyKey.Space:
                    virtualKey = NativeMethods.VK_SPACE;
                    break;

                case EasyKey.Prior:
                    virtualKey = NativeMethods.VK_PRIOR;
                    break;

                case EasyKey.Next:
                    virtualKey = NativeMethods.VK_NEXT;
                    break;

                case EasyKey.End:
                    virtualKey = NativeMethods.VK_END;
                    break;

                case EasyKey.Home:
                    virtualKey = NativeMethods.VK_HOME;
                    break;

                case EasyKey.Left:
                    virtualKey = NativeMethods.VK_LEFT;
                    break;

                case EasyKey.Up:
                    virtualKey = NativeMethods.VK_UP;
                    break;

                case EasyKey.Right:
                    virtualKey = NativeMethods.VK_RIGHT;
                    break;

                case EasyKey.Down:
                    virtualKey = NativeMethods.VK_DOWN;
                    break;

                case EasyKey.Select:
                    virtualKey = NativeMethods.VK_SELECT;
                    break;

                case EasyKey.Print:
                    virtualKey = NativeMethods.VK_PRINT;
                    break;

                case EasyKey.Execute:
                    virtualKey = NativeMethods.VK_EXECUTE;
                    break;

                case EasyKey.Snapshot:
                    virtualKey = NativeMethods.VK_SNAPSHOT;
                    break;

                case EasyKey.Insert:
                    virtualKey = NativeMethods.VK_INSERT;
                    break;

                case EasyKey.Delete:
                    virtualKey = NativeMethods.VK_DELETE;
                    break;

                case EasyKey.Help:
                    virtualKey = NativeMethods.VK_HELP;
                    break;

                case EasyKey.D0:
                    virtualKey = NativeMethods.VK_0;
                    break;

                case EasyKey.D1:
                    virtualKey = NativeMethods.VK_1;
                    break;

                case EasyKey.D2:
                    virtualKey = NativeMethods.VK_2;
                    break;

                case EasyKey.D3:
                    virtualKey = NativeMethods.VK_3;
                    break;

                case EasyKey.D4:
                    virtualKey = NativeMethods.VK_4;
                    break;

                case EasyKey.D5:
                    virtualKey = NativeMethods.VK_5;
                    break;

                case EasyKey.D6:
                    virtualKey = NativeMethods.VK_6;
                    break;

                case EasyKey.D7:
                    virtualKey = NativeMethods.VK_7;
                    break;

                case EasyKey.D8:
                    virtualKey = NativeMethods.VK_8;
                    break;

                case EasyKey.D9:
                    virtualKey = NativeMethods.VK_9;
                    break;

                case EasyKey.A:
                    virtualKey = NativeMethods.VK_A;
                    break;

                case EasyKey.B:
                    virtualKey = NativeMethods.VK_B;
                    break;

                case EasyKey.C:
                    virtualKey = NativeMethods.VK_C;
                    break;

                case EasyKey.D:
                    virtualKey = NativeMethods.VK_D;
                    break;

                case EasyKey.E:
                    virtualKey = NativeMethods.VK_E;
                    break;

                case EasyKey.F:
                    virtualKey = NativeMethods.VK_F;
                    break;

                case EasyKey.G:
                    virtualKey = NativeMethods.VK_G;
                    break;

                case EasyKey.H:
                    virtualKey = NativeMethods.VK_H;
                    break;

                case EasyKey.I:
                    virtualKey = NativeMethods.VK_I;
                    break;

                case EasyKey.J:
                    virtualKey = NativeMethods.VK_J;
                    break;

                case EasyKey.K:
                    virtualKey = NativeMethods.VK_K;
                    break;

                case EasyKey.L:
                    virtualKey = NativeMethods.VK_L;
                    break;

                case EasyKey.M:
                    virtualKey = NativeMethods.VK_M;
                    break;

                case EasyKey.N:
                    virtualKey = NativeMethods.VK_N;
                    break;

                case EasyKey.O:
                    virtualKey = NativeMethods.VK_O;
                    break;

                case EasyKey.P:
                    virtualKey = NativeMethods.VK_P;
                    break;

                case EasyKey.Q:
                    virtualKey = NativeMethods.VK_Q;
                    break;

                case EasyKey.R:
                    virtualKey = NativeMethods.VK_R;
                    break;

                case EasyKey.S:
                    virtualKey = NativeMethods.VK_S;
                    break;

                case EasyKey.T:
                    virtualKey = NativeMethods.VK_T;
                    break;

                case EasyKey.U:
                    virtualKey = NativeMethods.VK_U;
                    break;

                case EasyKey.V:
                    virtualKey = NativeMethods.VK_V;
                    break;

                case EasyKey.W:
                    virtualKey = NativeMethods.VK_W;
                    break;

                case EasyKey.X:
                    virtualKey = NativeMethods.VK_X;
                    break;

                case EasyKey.Y:
                    virtualKey = NativeMethods.VK_Y;
                    break;

                case EasyKey.Z:
                    virtualKey = NativeMethods.VK_Z;
                    break;

                case EasyKey.LWin:
                    virtualKey = NativeMethods.VK_LWIN;
                    break;

                case EasyKey.RWin:
                    virtualKey = NativeMethods.VK_RWIN;
                    break;

                case EasyKey.Apps:
                    virtualKey = NativeMethods.VK_APPS;
                    break;

                case EasyKey.Sleep:
                    virtualKey = NativeMethods.VK_SLEEP;
                    break;

                case EasyKey.NumPad0:
                    virtualKey = NativeMethods.VK_NUMPAD0;
                    break;

                case EasyKey.NumPad1:
                    virtualKey = NativeMethods.VK_NUMPAD1;
                    break;

                case EasyKey.NumPad2:
                    virtualKey = NativeMethods.VK_NUMPAD2;
                    break;

                case EasyKey.NumPad3:
                    virtualKey = NativeMethods.VK_NUMPAD3;
                    break;

                case EasyKey.NumPad4:
                    virtualKey = NativeMethods.VK_NUMPAD4;
                    break;

                case EasyKey.NumPad5:
                    virtualKey = NativeMethods.VK_NUMPAD5;
                    break;

                case EasyKey.NumPad6:
                    virtualKey = NativeMethods.VK_NUMPAD6;
                    break;

                case EasyKey.NumPad7:
                    virtualKey = NativeMethods.VK_NUMPAD7;
                    break;

                case EasyKey.NumPad8:
                    virtualKey = NativeMethods.VK_NUMPAD8;
                    break;

                case EasyKey.NumPad9:
                    virtualKey = NativeMethods.VK_NUMPAD9;
                    break;

                case EasyKey.Multiply:
                    virtualKey = NativeMethods.VK_MULTIPLY;
                    break;

                case EasyKey.Add:
                    virtualKey = NativeMethods.VK_ADD;
                    break;

                case EasyKey.Separator:
                    virtualKey = NativeMethods.VK_SEPARATOR;
                    break;

                case EasyKey.Subtract:
                    virtualKey = NativeMethods.VK_SUBTRACT;
                    break;

                case EasyKey.Decimal:
                    virtualKey = NativeMethods.VK_DECIMAL;
                    break;

                case EasyKey.Divide:
                    virtualKey = NativeMethods.VK_DIVIDE;
                    break;

                case EasyKey.F1:
                    virtualKey = NativeMethods.VK_F1;
                    break;

                case EasyKey.F2:
                    virtualKey = NativeMethods.VK_F2;
                    break;

                case EasyKey.F3:
                    virtualKey = NativeMethods.VK_F3;
                    break;

                case EasyKey.F4:
                    virtualKey = NativeMethods.VK_F4;
                    break;

                case EasyKey.F5:
                    virtualKey = NativeMethods.VK_F5;
                    break;

                case EasyKey.F6:
                    virtualKey = NativeMethods.VK_F6;
                    break;

                case EasyKey.F7:
                    virtualKey = NativeMethods.VK_F7;
                    break;

                case EasyKey.F8:
                    virtualKey = NativeMethods.VK_F8;
                    break;

                case EasyKey.F9:
                    virtualKey = NativeMethods.VK_F9;
                    break;

                case EasyKey.F10:
                    virtualKey = NativeMethods.VK_F10;
                    break;

                case EasyKey.F11:
                    virtualKey = NativeMethods.VK_F11;
                    break;

                case EasyKey.F12:
                    virtualKey = NativeMethods.VK_F12;
                    break;

                case EasyKey.F13:
                    virtualKey = NativeMethods.VK_F13;
                    break;

                case EasyKey.F14:
                    virtualKey = NativeMethods.VK_F14;
                    break;

                case EasyKey.F15:
                    virtualKey = NativeMethods.VK_F15;
                    break;

                case EasyKey.F16:
                    virtualKey = NativeMethods.VK_F16;
                    break;

                case EasyKey.F17:
                    virtualKey = NativeMethods.VK_F17;
                    break;

                case EasyKey.F18:
                    virtualKey = NativeMethods.VK_F18;
                    break;

                case EasyKey.F19:
                    virtualKey = NativeMethods.VK_F19;
                    break;

                case EasyKey.F20:
                    virtualKey = NativeMethods.VK_F20;
                    break;

                case EasyKey.F21:
                    virtualKey = NativeMethods.VK_F21;
                    break;

                case EasyKey.F22:
                    virtualKey = NativeMethods.VK_F22;
                    break;

                case EasyKey.F23:
                    virtualKey = NativeMethods.VK_F23;
                    break;

                case EasyKey.F24:
                    virtualKey = NativeMethods.VK_F24;
                    break;

                case EasyKey.NumLock:
                    virtualKey = NativeMethods.VK_NUMLOCK;
                    break;

                case EasyKey.Scroll:
                    virtualKey = NativeMethods.VK_SCROLL;
                    break;

                case EasyKey.LeftShift:
                    virtualKey = NativeMethods.VK_LSHIFT;
                    break;

                case EasyKey.RightShift:
                    virtualKey = NativeMethods.VK_RSHIFT;
                    break;

                case EasyKey.LeftCtrl:
                    virtualKey = NativeMethods.VK_LCONTROL;
                    break;

                case EasyKey.RightCtrl:
                    virtualKey = NativeMethods.VK_RCONTROL;
                    break;

                case EasyKey.LeftAlt:
                    virtualKey = NativeMethods.VK_LMENU;
                    break;

                case EasyKey.RightAlt:
                    virtualKey = NativeMethods.VK_RMENU;
                    break;

                case EasyKey.BrowserBack:
                    virtualKey = NativeMethods.VK_BROWSER_BACK;
                    break;

                case EasyKey.BrowserForward:
                    virtualKey = NativeMethods.VK_BROWSER_FORWARD;
                    break;

                case EasyKey.BrowserRefresh:
                    virtualKey = NativeMethods.VK_BROWSER_REFRESH;
                    break;

                case EasyKey.BrowserStop:
                    virtualKey = NativeMethods.VK_BROWSER_STOP;
                    break;

                case EasyKey.BrowserSearch:
                    virtualKey = NativeMethods.VK_BROWSER_SEARCH;
                    break;

                case EasyKey.BrowserFavorites:
                    virtualKey = NativeMethods.VK_BROWSER_FAVORITES;
                    break;

                case EasyKey.BrowserHome:
                    virtualKey = NativeMethods.VK_BROWSER_HOME;
                    break;

                case EasyKey.VolumeMute:
                    virtualKey = NativeMethods.VK_VOLUME_MUTE;
                    break;

                case EasyKey.VolumeDown:
                    virtualKey = NativeMethods.VK_VOLUME_DOWN;
                    break;

                case EasyKey.VolumeUp:
                    virtualKey = NativeMethods.VK_VOLUME_UP;
                    break;

                case EasyKey.MediaNextTrack:
                    virtualKey = NativeMethods.VK_MEDIA_NEXT_TRACK;
                    break;

                case EasyKey.MediaPreviousTrack:
                    virtualKey = NativeMethods.VK_MEDIA_PREV_TRACK;
                    break;

                case EasyKey.MediaStop:
                    virtualKey = NativeMethods.VK_MEDIA_STOP;
                    break;

                case EasyKey.MediaPlayPause:
                    virtualKey = NativeMethods.VK_MEDIA_PLAY_PAUSE;
                    break;

                case EasyKey.LaunchMail:
                    virtualKey = NativeMethods.VK_LAUNCH_MAIL;
                    break;

                case EasyKey.SelectMedia:
                    virtualKey = NativeMethods.VK_LAUNCH_MEDIA_SELECT;
                    break;

                case EasyKey.LaunchApplication1:
                    virtualKey = NativeMethods.VK_LAUNCH_APP1;
                    break;

                case EasyKey.LaunchApplication2:
                    virtualKey = NativeMethods.VK_LAUNCH_APP2;
                    break;

                case EasyKey.OemSemicolon:
                    virtualKey = NativeMethods.VK_OEM_1;
                    break;

                case EasyKey.OemPlus:
                    virtualKey = NativeMethods.VK_OEM_PLUS;
                    break;

                case EasyKey.OemComma:
                    virtualKey = NativeMethods.VK_OEM_COMMA;
                    break;

                case EasyKey.OemMinus:
                    virtualKey = NativeMethods.VK_OEM_MINUS;
                    break;

                case EasyKey.OemPeriod:
                    virtualKey = NativeMethods.VK_OEM_PERIOD;
                    break;

                case EasyKey.OemQuestion:
                    virtualKey = NativeMethods.VK_OEM_2;
                    break;

                case EasyKey.OemTilde:
                    virtualKey = NativeMethods.VK_OEM_3;
                    break;

                case EasyKey.AbntC1:
                    virtualKey = NativeMethods.VK_C1;
                    break;

                case EasyKey.AbntC2:
                    virtualKey = NativeMethods.VK_C2;
                    break;

                case EasyKey.OemOpenBrackets:
                    virtualKey = NativeMethods.VK_OEM_4;
                    break;

                case EasyKey.OemPipe:
                    virtualKey = NativeMethods.VK_OEM_5;
                    break;

                case EasyKey.OemCloseBrackets:
                    virtualKey = NativeMethods.VK_OEM_6;
                    break;

                case EasyKey.OemQuotes:
                    virtualKey = NativeMethods.VK_OEM_7;
                    break;

                case EasyKey.Oem8:
                    virtualKey = NativeMethods.VK_OEM_8;
                    break;

                case EasyKey.OemBackslash:
                    virtualKey = NativeMethods.VK_OEM_102;
                    break;

                case EasyKey.ImeProcessed:
                    virtualKey = NativeMethods.VK_PROCESSKEY;
                    break;

                case EasyKey.OemAttn:                           // DbeAlphanumeric
                    virtualKey = NativeMethods.VK_OEM_ATTN; // VK_DBE_ALPHANUMERIC
                    break;

                case EasyKey.OemFinish:                           // DbeKatakana
                    virtualKey = NativeMethods.VK_OEM_FINISH; // VK_DBE_KATAKANA
                    break;

                case EasyKey.OemCopy:                           // DbeHiragana
                    virtualKey = NativeMethods.VK_OEM_COPY; // VK_DBE_HIRAGANA
                    break;

                case EasyKey.OemAuto:                           // DbeSbcsChar
                    virtualKey = NativeMethods.VK_OEM_AUTO; // VK_DBE_SBCSCHAR
                    break;

                case EasyKey.OemEnlw:                           // DbeDbcsChar
                    virtualKey = NativeMethods.VK_OEM_ENLW; // VK_DBE_DBCSCHAR
                    break;

                case EasyKey.OemBackTab:                           // DbeRoman
                    virtualKey = NativeMethods.VK_OEM_BACKTAB; // VK_DBE_ROMAN
                    break;

                case EasyKey.Attn:                          // DbeNoRoman
                    virtualKey = NativeMethods.VK_ATTN; // VK_DBE_NOROMAN
                    break;

                case EasyKey.CrSel:                          // DbeEnterWordRegisterMode
                    virtualKey = NativeMethods.VK_CRSEL; // VK_DBE_ENTERWORDREGISTERMODE
                    break;

                case EasyKey.ExSel:                          // EnterImeConfigureMode
                    virtualKey = NativeMethods.VK_EXSEL; // VK_DBE_ENTERIMECONFIGMODE
                    break;

                case EasyKey.EraseEof:                       // DbeFlushString
                    virtualKey = NativeMethods.VK_EREOF; // VK_DBE_FLUSHSTRING
                    break;

                case EasyKey.Play:                           // DbeCodeInput
                    virtualKey = NativeMethods.VK_PLAY;  // VK_DBE_CODEINPUT
                    break;

                case EasyKey.Zoom:                           // DbeNoCodeInput
                    virtualKey = NativeMethods.VK_ZOOM;  // VK_DBE_NOCODEINPUT
                    break;

                case EasyKey.NoName:                          // DbeDetermineString
                    virtualKey = NativeMethods.VK_NONAME; // VK_DBE_DETERMINESTRING
                    break;

                case EasyKey.Pa1:                          // DbeEnterDlgConversionMode
                    virtualKey = NativeMethods.VK_PA1; // VK_ENTERDLGCONVERSIONMODE
                    break;

                case EasyKey.OemClear:
                    virtualKey = NativeMethods.VK_OEM_CLEAR;
                    break;

                case EasyKey.DeadCharProcessed:             //This is usused.  It's just here for completeness.
                    virtualKey = 0;                     //There is no Win32 VKey for this.
                    break;

                default:
                    virtualKey = 0;
                    break;
            }

            return virtualKey;
        }
    }
}
