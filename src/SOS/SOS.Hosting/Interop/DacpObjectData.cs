// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace SOS.Hosting.Interop
{
    public enum DacObjectType
    {
        String,
        Free,
        Object,
        Array,
        Other,
    }

    // Keep these layouts in sync with shared\inc\dacprivate.h.
    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct DacpObjectData
    {
        [FieldOffset(0x00)] public ulong MethodTable;
        [FieldOffset(0x08)] public DacObjectType ObjectType;
        [FieldOffset(0x10)] public ulong Size;
        [FieldOffset(0x18)] public ulong ElementTypeHandle;
        [FieldOffset(0x20)] public uint ElementType;
        [FieldOffset(0x24)] public uint Rank;
        [FieldOffset(0x28)] public ulong NumComponents;
        [FieldOffset(0x30)] public ulong ComponentSize;
        [FieldOffset(0x38)] public ulong ArrayDataPtr;
        [FieldOffset(0x40)] public ulong ArrayBoundsPtr;
        [FieldOffset(0x48)] public ulong ArrayLowerBoundsPtr;
        [FieldOffset(0x50)] public ulong RCW;
        [FieldOffset(0x58)] public ulong CCW;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x48)]
    public struct DacpMethodTableData
    {
        [FieldOffset(0x00)] public int IsFree;
        [FieldOffset(0x08)] public ulong Module;
        [FieldOffset(0x10)] public ulong CanonicalMethodTable;
        [FieldOffset(0x18)] public ulong ParentMethodTable;
        [FieldOffset(0x20)] public ushort NumInterfaces;
        [FieldOffset(0x22)] public ushort NumMethods;
        [FieldOffset(0x24)] public ushort NumVtableSlots;
        [FieldOffset(0x26)] public ushort NumVirtuals;
        [FieldOffset(0x28)] public uint BaseSize;
        [FieldOffset(0x2c)] public uint ComponentSize;
        [FieldOffset(0x30)] public uint Token;
        [FieldOffset(0x34)] public uint Attributes;
        [FieldOffset(0x38)] public int IsShared;
        [FieldOffset(0x3c)] public int IsDynamic;
        [FieldOffset(0x40)] public int ContainsPointers;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct DacpMethodTableFieldData
    {
        [FieldOffset(0x00)] public ushort NumInstanceFields;
        [FieldOffset(0x02)] public ushort NumStaticFields;
        [FieldOffset(0x04)] public ushort NumThreadStaticFields;
        [FieldOffset(0x08)] public ulong FirstField;
        [FieldOffset(0x10)] public ushort ContextStaticOffset;
        [FieldOffset(0x12)] public ushort ContextStaticsSize;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct DacpFieldDescData
    {
        [FieldOffset(0x00)] public uint Type;
        [FieldOffset(0x04)] public uint SignatureType;
        [FieldOffset(0x08)] public ulong MethodTableOfType;
        [FieldOffset(0x10)] public ulong ModuleOfType;
        [FieldOffset(0x18)] public uint TokenOfType;
        [FieldOffset(0x1c)] public uint FieldToken;
        [FieldOffset(0x20)] public ulong EnclosingMethodTable;
        [FieldOffset(0x28)] public uint Offset;
        [FieldOffset(0x2c)] public int IsThreadLocal;
        [FieldOffset(0x30)] public int IsContextLocal;
        [FieldOffset(0x34)] public int IsStatic;
        [FieldOffset(0x38)] public ulong NextField;
    }
}
