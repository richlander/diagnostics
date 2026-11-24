// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SOS.Hosting.Interop
{
    // Keep method order and signatures in sync with shared\inc\sospriv.idl.
    // Data structs not yet projected in this assembly are passed as opaque pointers.
    [GeneratedComInterface]
    [Guid("436f00f2-b42a-4b9f-870c-e73db66ae930")]
    public unsafe partial interface ISOSDacInterface
    {
        // Thread store
        [PreserveSig] int GetThreadStoreData(DacpThreadStoreData* data);

        // App domains
        [PreserveSig] int GetAppDomainStoreData(DacpAppDomainStoreData* data);
        [PreserveSig] int GetAppDomainList(uint count, ulong* values, uint* needed);
        [PreserveSig] int GetAppDomainData(ulong address, DacpAppDomainData* data);
        [PreserveSig] int GetAppDomainName(ulong address, uint count, char* name, uint* needed);
        [PreserveSig] int GetDomainFromContext(ulong context, ulong* domain);

        // Assemblies
        [PreserveSig] int GetAssemblyList(ulong appDomain, int count, ulong* values, int* needed);
        [PreserveSig] int GetAssemblyData(ulong baseDomain, ulong assembly, DacpAssemblyData* data);
        [PreserveSig] int GetAssemblyName(ulong assembly, uint count, char* name, uint* needed);

        // Modules
        [PreserveSig] int GetModule(ulong address, out IXCLRDataModule module);
        [PreserveSig] int GetModuleData(ulong module, DacpModuleData* data);
        [PreserveSig] int TraverseModuleMap(ModuleMapType mapType, ulong module, delegate* unmanaged[Cdecl]<uint, ulong, void*, void> callback, void* token);
        [PreserveSig] int GetAssemblyModuleList(ulong assembly, uint count, ulong* modules, uint* needed);
        [PreserveSig] int GetILForModule(ulong module, uint rva, ulong* il);

        // Threads
        [PreserveSig] int GetThreadData(ulong thread, DacpThreadData* data);
        [PreserveSig] int GetThreadFromThinlockID(uint thinLockId, ulong* thread);
        [PreserveSig] int GetStackLimits(ulong thread, ulong* lower, ulong* upper, ulong* framePointer);

        // Method descriptors
        [PreserveSig] int GetMethodDescData(ulong methodDesc, ulong ip, void* data, uint count, void* revertedVersions, uint* needed);
        [PreserveSig] int GetMethodDescPtrFromIP(ulong ip, ulong* methodDesc);
        [PreserveSig] int GetMethodDescName(ulong methodDesc, uint count, char* name, uint* needed);
        [PreserveSig] int GetMethodDescPtrFromFrame(ulong frame, ulong* methodDesc);
        [PreserveSig] int GetMethodDescFromToken(ulong module, uint token, ulong* methodDesc);
        [PreserveSig] int GetMethodDescTransparencyData(ulong methodDesc, void* data);

        // JIT data
        [PreserveSig] int GetCodeHeaderData(ulong ip, void* data);
        [PreserveSig] int GetJitManagerList(uint count, void* managers, uint* needed);
        [PreserveSig] int GetJitHelperFunctionName(ulong ip, uint count, byte* name, uint* needed);
        [PreserveSig] int GetJumpThunkTarget(void* context, ulong* targetIp, ulong* targetMethodDesc);

        // Thread pool
        [PreserveSig] int GetThreadpoolData(void* data);
        [PreserveSig] int GetWorkRequestData(ulong address, void* data);
        [PreserveSig] int GetHillClimbingLogEntry(ulong address, void* data);

        // Objects
        [PreserveSig] int GetObjectData(ulong address, DacpObjectData* data);
        [PreserveSig] int GetObjectStringData(ulong address, uint count, char* value, uint* needed);
        [PreserveSig] int GetObjectClassName(ulong address, uint count, char* name, uint* needed);

        // Method tables
        [PreserveSig] int GetMethodTableName(ulong methodTable, uint count, char* name, uint* needed);
        [PreserveSig] int GetMethodTableData(ulong methodTable, DacpMethodTableData* data);
        [PreserveSig] int GetMethodTableSlot(ulong methodTable, uint slot, ulong* value);
        [PreserveSig] int GetMethodTableFieldData(ulong methodTable, DacpMethodTableFieldData* data);
        [PreserveSig] int GetMethodTableTransparencyData(ulong methodTable, void* data);
        [PreserveSig] int GetMethodTableForEEClass(ulong eeClass, ulong* methodTable);
        [PreserveSig] int GetFieldDescData(ulong fieldDesc, DacpFieldDescData* data);
        [PreserveSig] int GetFrameName(ulong frameVtable, uint count, char* name, uint* needed);

        // PE files
        [PreserveSig] int GetPEFileBase(ulong address, ulong* imageBase);
        [PreserveSig] int GetPEFileName(ulong address, uint count, char* name, uint* needed);

        // GC
        [PreserveSig] int GetGCHeapData(DacpGcHeapData* data);
        [PreserveSig] int GetGCHeapList(uint count, ulong* heaps, uint* needed);
        [PreserveSig] int GetGCHeapDetails(ulong heap, void* details);
        [PreserveSig] int GetGCHeapStaticData(void* data);
        [PreserveSig] int GetHeapSegmentData(ulong segment, void* data);
        [PreserveSig] int GetOOMData(ulong address, void* data);
        [PreserveSig] int GetOOMStaticData(void* data);
        [PreserveSig] int GetHeapAnalyzeData(ulong address, void* data);
        [PreserveSig] int GetHeapAnalyzeStaticData(void* data);

        // Domain-local and thread-local storage
        [PreserveSig] int GetDomainLocalModuleData(ulong address, DacpDomainLocalModuleData* data);
        [PreserveSig] int GetDomainLocalModuleDataFromAppDomain(ulong appDomain, int moduleId, DacpDomainLocalModuleData* data);
        [PreserveSig] int GetDomainLocalModuleDataFromModule(ulong module, DacpDomainLocalModuleData* data);
        [PreserveSig] int GetThreadLocalModuleData(ulong thread, uint index, DacpThreadLocalModuleData* data);

        // Sync blocks
        [PreserveSig] int GetSyncBlockData(uint number, DacpSyncBlockData* data);
        [PreserveSig] int GetSyncBlockCleanupData(ulong address, void* data);

        // Handles
        [PreserveSig] int GetHandleEnum(nint* handleEnum);
        [PreserveSig] int GetHandleEnumForTypes(uint* types, uint count, nint* handleEnum);
        [PreserveSig] int GetHandleEnumForGC(uint generation, nint* handleEnum);

        // Exception handling
        [PreserveSig] int TraverseEHInfo(ulong ip, delegate* unmanaged[Cdecl]<uint, uint, void*, void*, int> callback, void* token);
        [PreserveSig] int GetNestedExceptionData(ulong exception, ulong* exceptionObject, ulong* nextNestedException);
        [PreserveSig] int GetStressLogAddress(ulong* stressLog);

        // Heaps
        [PreserveSig] int TraverseLoaderHeap(ulong loaderHeap, delegate* unmanaged[Cdecl]<ulong, nuint, int, void> callback);
        [PreserveSig] int GetCodeHeapList(ulong jitManager, uint count, void* codeHeaps, uint* needed);
        [PreserveSig] int TraverseVirtCallStubHeap(ulong appDomain, int heapType, delegate* unmanaged[Cdecl]<ulong, nuint, int, void> callback);

        [PreserveSig] int GetUsefulGlobals(DacpUsefulGlobalsData* data);
        [PreserveSig] int GetClrWatsonBuckets(ulong thread, void* genericModeBlock);
        [PreserveSig] int GetTLSIndex(uint* index);
        [PreserveSig] int GetDacModuleHandle(nint* moduleHandle);

        // COM
        [PreserveSig] int GetRCWData(ulong address, void* data);
        [PreserveSig] int GetRCWInterfaces(ulong rcw, uint count, void* interfaces, uint* needed);
        [PreserveSig] int GetCCWData(ulong address, void* data);
        [PreserveSig] int GetCCWInterfaces(ulong ccw, uint count, void* interfaces, uint* needed);
        [PreserveSig] int TraverseRCWCleanupList(ulong cleanupList, delegate* unmanaged[Cdecl]<ulong, ulong, ulong, int, void*, int> callback, void* token);

        // GC references and allocation data
        [PreserveSig] int GetStackReferences(uint osThreadId, nint* stackRefEnum);
        [PreserveSig] int GetRegisterName(int register, uint count, char* buffer, uint* needed);
        [PreserveSig] int GetThreadAllocData(ulong thread, void* data);
        [PreserveSig] int GetHeapAllocData(uint count, void* data, uint* needed);

        // Binding display
        [PreserveSig] int GetFailedAssemblyList(ulong appDomain, int count, ulong* values, uint* needed);
        [PreserveSig] int GetPrivateBinPaths(ulong appDomain, int count, char* paths, uint* needed);
        [PreserveSig] int GetAssemblyLocation(ulong assembly, int count, char* location, uint* needed);
        [PreserveSig] int GetAppDomainConfigFile(ulong appDomain, int count, char* configFile, uint* needed);
        [PreserveSig] int GetApplicationBase(ulong appDomain, int count, char* appBase, uint* needed);
        [PreserveSig] int GetFailedAssemblyData(ulong assembly, uint* context, int* result);
        [PreserveSig] int GetFailedAssemblyLocation(ulong assembly, uint count, char* location, uint* needed);
        [PreserveSig] int GetFailedAssemblyDisplayName(ulong assembly, uint count, char* name, uint* needed);
    }

    // Keep layouts in sync with shared\inc\dacprivate.h. CLRDATA_ADDRESS is always 64 bits.
    [StructLayout(LayoutKind.Sequential, Pack = 8, Size = 0x18)]
    public struct DacpAppDomainStoreData
    {
        public ulong SharedDomain;
        public ulong SystemDomain;
        public int DomainCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8, Size = 0x48)]
    public struct DacpAppDomainData
    {
        public ulong AppDomainPtr;
        public ulong AppSecDesc;
        public ulong LowFrequencyHeap;
        public ulong HighFrequencyHeap;
        public ulong StubHeap;
        public ulong DomainLocalBlock;
        public ulong DomainLocalModules;
        public uint Id;
        public int AssemblyCount;
        public int FailedAssemblyCount;
        public AppDomainStage Stage;
    }

    public enum AppDomainStage
    {
        Creating,
        ReadyForManagedCode,
        Active,
        Open,
        UnloadRequested,
        Exiting,
        Exited,
        Finalizing,
        Finalized,
        HandleTableNoAccess,
        Cleared,
        Collected,
        Closed
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DacpGcHeapData
    {
        public int ServerMode;
        public int GcStructuresValid;
        public uint HeapCount;
        public uint MaxGeneration;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DacpAssemblyData
    {
        public ulong AssemblyPtr;
        public ulong ClassLoader;
        public ulong ParentDomain;
        public ulong BaseDomainPtr;
        public ulong AssemblySecDesc;
        public int IsDynamic;
        public uint ModuleCount;
        public uint LoadContext;
        public int IsDomainNeutral;
        public uint LocationFlags;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DacpModuleData
    {
        // Desktop CLR and CoreCLR use different bits.
        public const uint EditAndContinueFlags = 0x208;

        public ulong Address;
        public ulong PEAssembly;
        public ulong ILBase;
        public ulong MetadataStart;
        public ulong MetadataSize;
        public ulong Assembly;
        public int IsReflection;
        public int IsPEFile;
        public ulong BaseClassIndex;
        public ulong ModuleId;
        public uint TransientFlags;
        public ulong TypeDefToMethodTableMap;
        public ulong TypeRefToMethodTableMap;
        public ulong MethodDefToDescMap;
        public ulong FieldDefToDescMap;
        public ulong MemberRefToDescMap;
        public ulong FileReferencesMap;
        public ulong ManifestModuleReferencesMap;
        public ulong LoaderAllocator;
        public ulong ThunkHeap;
        public ulong ModuleIndex;
    }

    public enum ModuleMapType
    {
        TypeDefToMethodTable,
        TypeRefToMethodTable,
    }
}
