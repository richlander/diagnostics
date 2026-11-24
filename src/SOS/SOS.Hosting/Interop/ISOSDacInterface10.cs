// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SOS.Hosting.Interop
{
    [GeneratedComInterface]
    [Guid("90b8fcc3-7251-4b0a-ae3d-5c13a67ec9aa")]
    public unsafe partial interface ISOSDacInterface10
    {
        [PreserveSig] int GetObjectComWrappersData(ulong address, ulong* rcw, uint count, ulong* ccws, uint* needed);
        [PreserveSig] int IsComWrappersCCW(ulong ccw, int* isComWrappersCCW);
        [PreserveSig] int GetComWrappersCCWData(ulong ccw, ulong* managedObject, int* refCount);
        [PreserveSig] int IsComWrappersRCW(ulong rcw, int* isComWrappersRCW);
        [PreserveSig] int GetComWrappersRCWData(ulong rcw, ulong* identity);
    }
}
