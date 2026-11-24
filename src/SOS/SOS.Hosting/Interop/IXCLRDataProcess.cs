// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SOS.Hosting.Interop
{
    // Flush is the first method after IUnknown in shared\inc\xclrdata.idl.
    [GeneratedComInterface]
    [Guid("5c552ab6-fc09-4cb3-8e36-22fa03c798b7")]
    internal partial interface IXCLRDataProcess
    {
        [PreserveSig] int Flush();
    }
}
