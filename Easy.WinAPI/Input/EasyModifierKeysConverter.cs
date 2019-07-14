using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Easy.WinAPI.Input
{
    class EasyModifierKeysConverter : TypeConverter
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
            // We can only handle string.
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
            if (destinationType == typeof(string))
            {
                // When invoked by the serialization engine we can convert to string only for known type
                if (context != null && context.Instance != null &&
                    context.Instance is EasyModifierKeys)
                {
                    return (IsDefinedModifierKeys((EasyModifierKeys)context.Instance));
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
                string modifiersToken = ((string)source).Trim();
                EasyModifierKeys modifiers = GetModifierKeys(modifiersToken, CultureInfo.InvariantCulture);
                return modifiers;
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

            if (destinationType == typeof(string))
            {
                EasyModifierKeys modifiers = (EasyModifierKeys)value;

                if (!IsDefinedModifierKeys(modifiers))
                    throw new InvalidEnumArgumentException("value", (int)modifiers, typeof(EasyModifierKeys));
                else
                {
                    string strModifiers = "";

                    if ((modifiers & EasyModifierKeys.Control) == EasyModifierKeys.Control)
                    {
                        strModifiers += MatchModifiers(EasyModifierKeys.Control);
                    }

                    if ((modifiers & EasyModifierKeys.Alt) == EasyModifierKeys.Alt)
                    {
                        if (strModifiers.Length > 0)
                            strModifiers += Modifier_Delimiter;

                        strModifiers += MatchModifiers(EasyModifierKeys.Alt);
                    }

                    if ((modifiers & EasyModifierKeys.Windows) == EasyModifierKeys.Windows)
                    {
                        if (strModifiers.Length > 0)
                            strModifiers += Modifier_Delimiter;

                        strModifiers += MatchModifiers(EasyModifierKeys.Windows); ;
                    }

                    if ((modifiers & EasyModifierKeys.Shift) == EasyModifierKeys.Shift)
                    {
                        if (strModifiers.Length > 0)
                            strModifiers += Modifier_Delimiter;

                        strModifiers += MatchModifiers(EasyModifierKeys.Shift); ;
                    }

                    return strModifiers;
                }
            }
            throw GetConvertToException(value, destinationType);
        }

        private EasyModifierKeys GetModifierKeys(string modifiersToken, CultureInfo culture)
        {
            EasyModifierKeys modifiers = EasyModifierKeys.None;
            if (modifiersToken.Length != 0)
            {
                int offset = 0;
                do
                {
                    offset = modifiersToken.IndexOf(Modifier_Delimiter);
                    string token = (offset < 0) ? modifiersToken : modifiersToken.Substring(0, offset);
                    token = token.Trim();
                    token = token.ToUpper(culture);

                    if (token == String.Empty)
                        break;

                    switch (token)
                    {
                        case "CONTROL":
                        case "CTRL":
                            modifiers |= EasyModifierKeys.Control;
                            break;

                        case "SHIFT":
                            modifiers |= EasyModifierKeys.Shift;
                            break;

                        case "ALT":
                            modifiers |= EasyModifierKeys.Alt;
                            break;

                        case "WINDOWS":
                        case "WIN":
                            modifiers |= EasyModifierKeys.Windows;
                            break;

                        default:
                            throw new NotSupportedException($"Unsupported {token} Modifier");
                    }

                    modifiersToken = modifiersToken.Substring(offset + 1);
                } while (offset != -1);
            }
            return modifiers;
        }

        /// <summary>
        ///     Check for Valid enum, as any int can be casted to the enum.
        /// </summary>
        public static bool IsDefinedModifierKeys(EasyModifierKeys modifierKeys)
        {
            return (modifierKeys == EasyModifierKeys.None || (((int)modifierKeys & ~((int)ModifierKeysFlag)) == 0));
        }

        private const char Modifier_Delimiter = '+';

        private static EasyModifierKeys ModifierKeysFlag = EasyModifierKeys.Windows | EasyModifierKeys.Shift |
                                                         EasyModifierKeys.Alt | EasyModifierKeys.Control;

        internal static string MatchModifiers(EasyModifierKeys modifierKeys)
        {
            string modifiers = String.Empty;
            switch (modifierKeys)
            {
                case EasyModifierKeys.Control: modifiers = "Ctrl"; break;
                case EasyModifierKeys.Shift: modifiers = "Shift"; break;
                case EasyModifierKeys.Alt: modifiers = "Alt"; break;
                case EasyModifierKeys.Windows: modifiers = "Windows"; break;
            }
            return modifiers;
        }
    }
}
