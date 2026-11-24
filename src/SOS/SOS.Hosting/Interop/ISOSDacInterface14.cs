// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SOS.Hosting.Interop
{
    [GeneratedComInterface]
    [Guid("9aa22aca-6dc6-4a0c-b4e0-70d2416b9837")]
    public unsafe partial interface ISOSDacInterface14
    {
        [PreserveSig] int GetStaticBaseAddress(ulong methodTable, ulong* nonGcStatics, ulong* gcStatics);
        [PreserveSig] int GetThreadStaticBaseAddress(ulong methodTable, ulong thread, ulong* nonGcStatics, ulong* gcStatics);
        [PreserveSig] int GetMethodTableInitializationFlags(ulong methodTable, int* flags);
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct DacpDomainLocalModuleData
    {
        [FieldOffset(0x10)] public ulong ClassData;
        [FieldOffset(0x20)] public ulong GcStaticDataStart;
        [FieldOffset(0x28)] public ulong NonGcStaticDataStart;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct DacpThreadLocalModuleData
    {
        [FieldOffset(0x10)] public ulong ClassData;
        [FieldOffset(0x20)] public ulong GcStaticDataStart;
        [FieldOffset(0x28)] public ulong NonGcStaticDataStart;
    }
}
