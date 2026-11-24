// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace SOS.Hosting.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 8, Size = 0x48)]
    public struct DacpSyncBlockData
    {
        public ulong Object;
        public int IsFree;
        public ulong SyncBlockPointer;
        public uint ComFlags;
        public uint MonitorHeld;
        public uint Recursion;
        public ulong HoldingThread;
        public uint AdditionalThreadCount;
        public ulong AppDomain;
        public uint SyncBlockCount;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x68)]
    public struct DacpThreadData
    {
        [FieldOffset(4)]
        public uint OsThreadId;

        [FieldOffset(0x28)]
        public ulong Domain;

        [FieldOffset(0x60)]
        public ulong NextThread;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct DacpThreadStoreData
    {
        [FieldOffset(0x18)]
        public ulong FirstThread;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct DacpUsefulGlobalsData
    {
        [FieldOffset(0)]
        public ulong ArrayMethodTable;

        [FieldOffset(0x20)]
        public ulong FreeMethodTable;
    }
}
