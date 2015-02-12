using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    // Useful in number of places that return an empty byte array to avoid unnecessary memory allocation.
    internal static class EmptyArray<T>
    {
        public static readonly T[] Value = new T[0];
    }

    internal class _Array
    {
        // https://github.com/dotnet/coreclr/blob/cbf46fb0b6a0b209ed1caf4a680910b383e68cba/src/mscorlib/src/System/Array.cs#L610-L616
        internal const int MaxArrayLength = 0X7FEFFFFF;
        internal const int MaxByteArrayLength = 0x7FFFFFC7;
    }
}
