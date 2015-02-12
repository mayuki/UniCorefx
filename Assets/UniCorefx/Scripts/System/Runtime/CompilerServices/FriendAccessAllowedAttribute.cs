using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    ///     If AllInternalsVisible is not true for a friend assembly, the FriendAccessAllowed attribute
    ///     indicates which internals are shared with that friend assembly.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class |
                    AttributeTargets.Constructor |
                    AttributeTargets.Enum |
                    AttributeTargets.Event |
                    AttributeTargets.Field |
                    AttributeTargets.Interface |
                    AttributeTargets.Method |
                    AttributeTargets.Property |
                    AttributeTargets.Struct,
        AllowMultiple = false,
        Inherited = false)]
    [FriendAccessAllowed]
    internal sealed class FriendAccessAllowedAttribute : Attribute
    {
    }
}
