using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Easy.WinAPI.Input
{
    /// <summary>
    ///     The ModifierKeys enumeration describes a set of common keys
    ///     used to modify other input operations.
    /// </summary>
    [TypeConverter(typeof(EasyModifierKeysConverter))]
    [Flags]
    public enum EasyModifierKeys
    {
        /// <summary>
        ///    No modifiers are pressed.
        /// </summary>
        None = 0,

        /// <summary>
        ///    An alt key.
        /// </summary>
        Alt = 1,

        /// <summary>
        ///    A control key.
        /// </summary>
        Control = 2,

        /// <summary>
        ///    A shift key.
        /// </summary>
        Shift = 4,

        /// <summary>
        ///    A windows key.
        /// </summary>
        Windows = 8
    }
}
