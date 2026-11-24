// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SOS.Hosting.Interop
{
    [GeneratedComInterface]
    [Guid("96ba1db9-14cd-4492-8065-1caaecf6e5cf")]
    public unsafe partial interface ISOSDacInterface11
    {
        [PreserveSig] int IsTrackedType(ulong address, int* isTrackedType, int* hasTaggedMemory);
        [PreserveSig] int GetTaggedMemory(ulong address, ulong* taggedMemory, nuint* sizeInBytes);
    }
}
