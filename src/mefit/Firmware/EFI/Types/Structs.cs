﻿// Mac EFI Toolkit
// https://github.com/MuertoGB/MacEfiToolkit

// Structs.cs
// Released under the GNU GLP v3.0

using System.Runtime.InteropServices;

namespace Mac_EFI_Toolkit.Firmware.EFI
{
    internal struct EFILock
    {
        internal EfiLockType LockType { get; set; }
        internal int LockCrcBase { get; set; }
    }

    internal struct PdrSection
    {
        internal int BoardIdBase { get; set; }
        internal string BoardId { get; set; }
    }

    internal struct AppleRomInformationSection
    {
        internal bool SectionExists { get; set; }
        internal byte[] SectionBytes { get; set; }
        internal int SectionBase { get; set; }
        internal string BiosId { get; set; }
        internal string Model { get; set; }
        internal string EfiVersion { get; set; }
        internal string BuiltBy { get; set; }
        internal string DateStamp { get; set; }
        internal string Revision { get; set; }
        internal string RomVersion { get; set; }
        internal string BuildcaveId { get; set; }
        internal string BuildType { get; set; }
        internal string Compiler { get; set; }
    }

    internal struct EfiBiosIdSection
    {
        internal string ModelPart { get; set; }
        internal string zzPart { get; set; }
        internal string MajorPart { get; set; }
        internal string MinorPart { get; set; }
        internal string DatePart { get; set; }
    }

    internal struct NvramStore
    {
        internal NvramStoreType StoreType { get; set; }
        internal int PrimaryStoreBase { get; set; }
        internal int PrimaryStoreSize { get; set; }
        internal byte[] PrimaryStoreBytes { get; set; }
        internal bool IsPrimaryStoreEmpty { get; set; }
        internal int BackupStoreBase { get; set; }
        internal int BackupStoreSize { get; set; }
        internal byte[] BackupStoreBytes { get; set; }
        internal bool IsBackupStoreEmpty { get; set; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct NvramStoreHeader
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        internal char[] Signature;
        internal ushort SizeOfData;
    }

    internal struct FsysStore
    {
        internal byte[] FsysBytes { get; set; }
        internal int FsysBase { get; set; }
        internal string Serial { get; set; }
        internal int SerialBase { get; set; }
        internal string HWC { get; set; }
        internal int HWCBase { get; set; }
        internal string SON { get; set; }
        internal string CrcString { get; set; }
        internal string CrcCalcString { get; set; }
        internal uint CRC32CalcInt { get; set; }
    }
}