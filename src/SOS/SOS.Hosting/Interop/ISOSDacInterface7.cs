// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SOS.Hosting.Interop
{
    [GeneratedComInterface]
    [Guid("c1020dde-fe98-4536-a53b-f35a74c327eb")]
    public unsafe partial interface ISOSDacInterface7
    {
        [PreserveSig] int GetPendingReJITID(ulong methodDesc, int* rejitId);
        [PreserveSig] int GetReJITInformation(ulong methodDesc, int rejitId, void* data);
        [PreserveSig] int GetProfilerModifiedILInformation(ulong methodDesc, DacpProfilerILData* data);
        [PreserveSig] int GetMethodsWithProfilerModifiedIL(ulong module, ulong* methodDescs, int count, int* needed);
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DacpProfilerILData
    {
        public enum ModificationType
        {
            Unmodified,
            ILModified,
            ReJITModified,
        }

        public ModificationType Type;
        public ulong IL;
        public uint ReJITId;
    }
}
