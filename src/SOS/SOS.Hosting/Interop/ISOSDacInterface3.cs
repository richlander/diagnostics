// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SOS.Hosting.Interop
{
    [GeneratedComInterface]
    [Guid("B08C5CDC-FD8A-49C5-AB38-5FEEF35235B4")]
    public unsafe partial interface ISOSDacInterface3
    {
        [PreserveSig] int GetGCInterestingInfoData(ulong heap, DacpGCInterestingInfoData* data);
        [PreserveSig] int GetGCInterestingInfoStaticData(DacpGCInterestingInfoData* data);
        [PreserveSig] int GetGCGlobalMechanisms(nuint* globalMechanisms);
    }

    // Five contiguous size_t arrays in dacprivate.h, in the order below.
    [InlineArray(DacpGCInterestingInfoData.GlobalOffset + DacpGCInterestingInfoData.GlobalCount)]
    public struct DacpGCInterestingInfoData
    {
        public const int PointsOffset = 0;
        public const int CompactOffset = PointsOffset + 9;
        public const int ExpandOffset = CompactOffset + 11;
        public const int OtherOffset = ExpandOffset + 6;
        public const int GlobalOffset = OtherOffset + 2;
        public const int GlobalCount = 6;

        private nuint _element0;
    }
}
