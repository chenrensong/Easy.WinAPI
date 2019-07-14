using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Easy.WinAPI.Input
{
    public class EasyKeyConverter : TypeConverter
    {
        /// <summary>
        /// CanConvertFrom()
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        /// <ExternalAPI/> 
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// TypeConverter method override. 
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <param name="destinationType">Type to convert to</param>
        /// <returns>true if conversion is possible</returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            // We can convert to a string.
            // We can convert to an InstanceDescriptor or to a string.
            if (destinationType == typeof(string))
            {
                // When invoked by the serialization engine we can convert to string only for known type
                if (context != null && context.Instance != null)
                {
                    EasyKey key = (EasyKey)context.Instance;
                    return ((int)key >= (int)EasyKey.None && (int)key <= (int)EasyKey.DeadCharProcessed);
                }
            }
            return false;
        }

        /// <summary>
        /// ConvertFrom()
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        /// <ExternalAPI/> 
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source)
        {
            if (source is string)
            {
                string fullName = ((string)source).Trim();
                object key = GetKey(fullName, CultureInfo.InvariantCulture);
                if (key != null)
                {
                    return ((EasyKey)key);
                }
                else
                {
                    throw new NotSupportedException($"Unsupported {fullName} Key");
                }
            }
            throw GetConvertFromException(source);
        }

        /// <summary>
        /// ConvertTo()
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        /// <ExternalAPI/> 
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == null)
                throw new ArgumentNullException("destinationType");

            if (destinationType == typeof(string) && value != null)
            {
                EasyKey key = (EasyKey)value;
                if (key == EasyKey.None)
                {
                    return String.Empty;
                }

                if (key >= EasyKey.D0 && key <= EasyKey.D9)
                {
                    return Char.ToString((char)(int)(key - EasyKey.D0 + '0'));
                }

                if (key >= EasyKey.A && key <= EasyKey.Z)
                {
                    return Char.ToString((char)(int)(key - EasyKey.A + 'A'));
                }

                String strKey = MatchKey(key, culture);
                if (strKey != null && (strKey.Length != 0 || strKey == String.Empty))
                {
                    return strKey;
                }
            }
            throw GetConvertToException(value, destinationType);
        }

        private object GetKey(string keyToken, CultureInfo culture)
        {
            if (keyToken == String.Empty)
            {
                return EasyKey.None;
            }
            else
            {
                keyToken = keyToken.ToUpper(culture);
                if (keyToken.Length == 1 && Char.IsLetterOrDigit(keyToken[0]))
                {
                    if (Char.IsDigit(keyToken[0]) && (keyToken[0] >= '0' && keyToken[0] <= '9'))
                    {
                        return ((int)(EasyKey)(EasyKey.D0 + keyToken[0] - '0'));
                    }
                    else if (Char.IsLetter(keyToken[0]) && (keyToken[0] >= 'A' && keyToken[0] <= 'Z'))
                    {
                        return ((int)(EasyKey)(EasyKey.A + keyToken[0] - 'A'));
                    }
                    else
                    {
                        throw new ArgumentException($"Cannot Convert String {keyToken} To Type");
                    }
                }
                else
                {
                    EasyKey keyFound = (EasyKey)(-1);
                    switch (keyToken)
                    {
                        case "ENTER": keyFound = EasyKey.Return; break;
                        case "ESC": keyFound = EasyKey.Escape; break;
                        case "PGUP": keyFound = EasyKey.PageUp; break;
                        case "PGDN": keyFound = EasyKey.PageDown; break;
                        case "PRTSC": keyFound = EasyKey.PrintScreen; break;
                        case "INS": keyFound = EasyKey.Insert; break;
                        case "DEL": keyFound = EasyKey.Delete; break;
                        case "WINDOWS": keyFound = EasyKey.LWin; break;
                        case "WIN": keyFound = EasyKey.LWin; break;
                        case "LEFTWINDOWS": keyFound = EasyKey.LWin; break;
                        case "RIGHTWINDOWS": keyFound = EasyKey.RWin; break;
                        case "APPS": keyFound = EasyKey.Apps; break;
                        case "APPLICATION": keyFound = EasyKey.Apps; break;
                        case "BREAK": keyFound = EasyKey.Cancel; break;
                        case "BACKSPACE": keyFound = EasyKey.Back; break;
                        case "BKSP": keyFound = EasyKey.Back; break;
                        case "BS": keyFound = EasyKey.Back; break;
                        case "SHIFT": keyFound = EasyKey.LeftShift; break;
                        case "LEFTSHIFT": keyFound = EasyKey.LeftShift; break;
                        case "RIGHTSHIFT": keyFound = EasyKey.RightShift; break;
                        case "CONTROL": keyFound = EasyKey.LeftCtrl; break;
                        case "CTRL": keyFound = EasyKey.LeftCtrl; break;
                        case "LEFTCTRL": keyFound = EasyKey.LeftCtrl; break;
                        case "RIGHTCTRL": keyFound = EasyKey.RightCtrl; break;
                        case "ALT": keyFound = EasyKey.LeftAlt; break;
                        case "LEFTALT": keyFound = EasyKey.LeftAlt; break;
                        case "RIGHTALT": keyFound = EasyKey.RightAlt; break;
                        case "SEMICOLON": keyFound = EasyKey.OemSemicolon; break;
                        case "PLUS": keyFound = EasyKey.OemPlus; break;
                        case "COMMA": keyFound = EasyKey.OemComma; break;
                        case "MINUS": keyFound = EasyKey.OemMinus; break;
                        case "PERIOD": keyFound = EasyKey.OemPeriod; break;
                        case "QUESTION": keyFound = EasyKey.OemQuestion; break;
                        case "TILDE": keyFound = EasyKey.OemTilde; break;
                        case "OPENBRACKETS": keyFound = EasyKey.OemOpenBrackets; break;
                        case "PIPE": keyFound = EasyKey.OemPipe; break;
                        case "CLOSEBRACKETS": keyFound = EasyKey.OemCloseBrackets; break;
                        case "QUOTES": keyFound = EasyKey.OemQuotes; break;
                        case "BACKSLASH": keyFound = EasyKey.OemBackslash; break;
                        case "FINISH": keyFound = EasyKey.OemFinish; break;
                        case "ATTN": keyFound = EasyKey.Attn; break;
                        case "CRSEL": keyFound = EasyKey.CrSel; break;
                        case "EXSEL": keyFound = EasyKey.ExSel; break;
                        case "ERASEEOF": keyFound = EasyKey.EraseEof; break;
                        case "PLAY": keyFound = EasyKey.Play; break;
                        case "ZOOM": keyFound = EasyKey.Zoom; break;
                        case "PA1": keyFound = EasyKey.Pa1; break;
                        default: keyFound = (EasyKey)Enum.Parse(typeof(EasyKey), keyToken, true); break;
                    }

                    if ((int)keyFound != -1)
                    {
                        return keyFound;
                    }
                    return null;
                }
            }
        }

        private static string MatchKey(EasyKey key, CultureInfo culture)
        {
            if (key == EasyKey.None)
                return String.Empty;
            else
            {
                switch (key)
                {
                    case EasyKey.Back: return "Backspace";
                    case EasyKey.LineFeed: return "Clear";
                    case EasyKey.Escape: return "Esc";
                }
            }
            if ((int)key >= (int)EasyKey.None && (int)key <= (int)EasyKey.DeadCharProcessed)
                return key.ToString();
            else
                return null;
        }
    }
}
