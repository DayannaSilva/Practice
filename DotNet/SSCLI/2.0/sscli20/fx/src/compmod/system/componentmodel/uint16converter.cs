
//------------------------------------------------------------------------------
// <copyright file="UInt16Converter.cs" company="Microsoft">
//     
//      Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//     
//      The use and distribution terms for this software are contained in the file
//      named license.txt, which can be found in the root of this distribution.
//      By using this software in any fashion, you are agreeing to be bound by the
//      terms of this license.
//     
//      You must not remove this notice, or any other, from this software.
//     
// </copyright>                                                                
//------------------------------------------------------------------------------

/*
 */
namespace System.ComponentModel {
    using Microsoft.Win32;
    using System.Diagnostics;
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Runtime.Remoting;
    using System.Runtime.Serialization.Formatters;
    using System.Security.Permissions;

    /// <devdoc>
    ///    <para>Provides a type converter to convert 16-bit unsigned integer objects to and
    ///       from various other representations.</para>
    /// </devdoc>
    [HostProtection(SharedState = true)]
    public class UInt16Converter : BaseNumberConverter {

        /// <devdoc>
        /// The Type this converter is targeting (e.g. Int16, UInt32, etc.)
        /// </devdoc>
        internal override Type TargetType {
                get {
                    return typeof(UInt16);
                }
        }

        /// <devdoc>
        /// Convert the given value to a string using the given radix
        /// </devdoc>
        internal override object FromString(string value, int radix) {
                return Convert.ToUInt16(value, radix);
        }
        
        /// <devdoc>
        /// Convert the given value to a string using the given formatInfo
        /// </devdoc>
        internal override object FromString(string value, NumberFormatInfo formatInfo) {
                return UInt16.Parse(value, NumberStyles.Integer, formatInfo);
        }
        
        
        /// <devdoc>
        /// Convert the given value to a string using the given CultureInfo
        /// </devdoc>
        internal override object FromString(string value, CultureInfo culture){
                 return UInt16.Parse(value, culture);
        }
        
        /// <devdoc>
        /// Convert the given value from a string using the given formatInfo
        /// </devdoc>
        internal override string ToString(object value, NumberFormatInfo formatInfo) {
                return ((UInt16)value).ToString("G", formatInfo);
        }

    }
}

