// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SOS.Hosting.Interop
{
    // Keep method order and signatures in sync with shared\inc\xclrdata.idl.
    // Interfaces and structs not yet projected here are passed as opaque pointers.
    [GeneratedComInterface]
    [Guid("88e32849-0a0a-4cb0-9022-7cd2e9e139e2")]
    public unsafe partial interface IXCLRDataModule
    {
        [PreserveSig] int StartEnumAssemblies(ulong* handle);
        [PreserveSig] int EnumAssembly(ulong* handle, void** assembly);
        [PreserveSig] int EndEnumAssemblies(ulong handle);

        [PreserveSig] int StartEnumTypeDefinitions(ulong* handle);
        [PreserveSig] int EnumTypeDefinition(ulong* handle, void** typeDefinition);
        [PreserveSig] int EndEnumTypeDefinitions(ulong handle);

        [PreserveSig] int StartEnumTypeInstances(void* appDomain, ulong* handle);
        [PreserveSig] int EnumTypeInstance(ulong* handle, void** typeInstance);
        [PreserveSig] int EndEnumTypeInstances(ulong handle);

        [PreserveSig] int StartEnumTypeDefinitionsByName(char* name, uint flags, ulong* handle);
        [PreserveSig] int EnumTypeDefinitionByName(ulong* handle, void** type);
        [PreserveSig] int EndEnumTypeDefinitionsByName(ulong handle);

        [PreserveSig] int StartEnumTypeInstancesByName(char* name, uint flags, void* appDomain, ulong* handle);
        [PreserveSig] int EnumTypeInstanceByName(ulong* handle, void** type);
        [PreserveSig] int EndEnumTypeInstancesByName(ulong handle);
        [PreserveSig] int GetTypeDefinitionByToken(uint token, void** typeDefinition);

        [PreserveSig] int StartEnumMethodDefinitionsByName(char* name, uint flags, ulong* handle);
        [PreserveSig] int EnumMethodDefinitionByName(ulong* handle, void** method);
        [PreserveSig] int EndEnumMethodDefinitionsByName(ulong handle);

        [PreserveSig] int StartEnumMethodInstancesByName(char* name, uint flags, void* appDomain, ulong* handle);
        [PreserveSig] int EnumMethodInstanceByName(ulong* handle, void** method);
        [PreserveSig] int EndEnumMethodInstancesByName(ulong handle);
        [PreserveSig] int GetMethodDefinitionByToken(uint token, void** methodDefinition);

        [PreserveSig] int StartEnumDataByName(char* name, uint flags, void* appDomain, void* tlsTask, ulong* handle);
        [PreserveSig] int EnumDataByName(ulong* handle, void** value);
        [PreserveSig] int EndEnumDataByName(ulong handle);

        [PreserveSig] int GetName(uint bufferLength, uint* nameLength, char* name);
        [PreserveSig] int GetFileName(uint bufferLength, uint* nameLength, char* name);
        [PreserveSig] int GetFlags(uint* flags);
        [PreserveSig] int IsSameObject(void* module);

        [PreserveSig] int StartEnumExtents(ulong* handle);
        [PreserveSig] int EnumExtent(ulong* handle, void* extent);
        [PreserveSig] int EndEnumExtents(ulong handle);
        [PreserveSig] int Request(uint request, uint inputSize, byte* input, uint outputSize, byte* output);

        [PreserveSig] int StartEnumAppDomains(ulong* handle);
        [PreserveSig] int EnumAppDomain(ulong* handle, void** appDomain);
        [PreserveSig] int EndEnumAppDomains(ulong handle);
        [PreserveSig] int GetVersionId(Guid* version);
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DacpGetModuleData
    {
        public const uint RequestCode = 0xf0000001;

        public int IsDynamic;
        public int IsInMemory;
        public int IsFileLayout;
        public ulong PEAssembly;
        public ulong LoadedPEAddress;
        public ulong LoadedPESize;
        public ulong InMemoryPdbAddress;
        public ulong InMemoryPdbSize;
    }
}
