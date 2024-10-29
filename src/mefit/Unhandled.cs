﻿// Mac EFI Toolkit
// https://github.com/MuertoGB/MacEfiToolkit

// Unhandled.cs - Unhandled exception debug builder.
// Released under the GNU GLP v3.0

using Mac_EFI_Toolkit.Common;
using Mac_EFI_Toolkit.Firmware.EFI;
using Mac_EFI_Toolkit.Utils;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace Mac_EFI_Toolkit
{
    internal class Unhandled
    {

        #region Functions
        internal static bool GetIsDebugMode()
        {
#if DEBUG
            return true;
#else
            return false;
#endif
        }

        internal static bool IsElevated()
        {
            return new WindowsPrincipal(
                WindowsIdentity.GetCurrent()).IsInRole(
                    WindowsBuiltInRole.Administrator);
        }

        internal static string GetBitnessMode()
        {
            return IntPtr.Size == 8
                ? "x64"
                : "x86";
        }
        #endregion

        internal static string GenerateUnhandledReport(Exception e)
        {
            StringBuilder builder = new StringBuilder();

            string exePath =
                Path.Combine(
                    METPath.WorkingDirectory,
                    METPath.FriendlyName);

            try
            {
                byte[] appBytes =
                    File.ReadAllBytes(
                        exePath);

                builder.AppendLine($"# // Mac EFI Toolkit Debug Log - {DateTime.Now}\r\n");

                builder.AppendLine("<-- Application -->\r\n");
                builder.AppendLine($"Name:     {Application.ProductName}");
                builder.AppendLine($"Version:  {Application.ProductVersion}.{METVersion.Build}");
                builder.AppendLine($"LZMA SDK: {METVersion.SDK}");
                builder.AppendLine($"Channel:  {METVersion.Channel}");
                builder.AppendLine($"Mode:     {GetBitnessMode()}");
                builder.AppendLine($"Debug:    {GetIsDebugMode()}");
                builder.AppendLine($"Elevated: {IsElevated()}");
                builder.AppendLine($"SHA256:   {FileUtils.GetSha256Digest(appBytes)}\r\n");

                builder.AppendLine("<-- Operating System -->\r\n");
                builder.AppendLine($"Name:     {OSUtils.GetName}");
                builder.AppendLine($"Bitness:  {OSUtils.GetBitness()}");
                builder.AppendLine($"Kernel:   {OSUtils.GetKernelVersion.ProductVersion}\r\n");

                builder.AppendLine("<-- Fonts -->\r\n");
                builder.AppendLine($"Segoe UI Reg: {FontResolver.IsFontStyleAvailable("Segoe UI", FontStyle.Regular)}");
                builder.AppendLine($"Segoe UI Bol: {FontResolver.IsFontStyleAvailable("Segoe UI", FontStyle.Bold)}");
                builder.AppendLine($"Segoe UI Sem: {FontResolver.IsFontStyleAvailable("Segoe UI Semibold", FontStyle.Regular)}");
                builder.AppendLine($"Consolas Reg: {FontResolver.IsFontStyleAvailable("Consolas", FontStyle.Bold)}\r\n");

                builder.AppendLine("<-- Exception Data -->\r\n");
                builder.AppendLine(GetExceptionData(e));

                builder.AppendLine("<-- Firmware -->\r\n");
                builder.AppendLine(GetFirmwareData());

                builder.AppendLine("<-- Modules -->\r\n");
                builder.AppendLine(GetProcessModules());
                builder.AppendLine("# // End of file");

                return builder.ToString();
            }
            catch (Exception ex)
            {
                Logger.WriteExceptionToAppLog(ex);
                return null;
            }
        }

        private static string GetExceptionData(Exception e)
        {
            if (e == null)
                return $"Exception data was null.\r\n";

            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"  Message ->\r\n");
            builder.AppendLine($"{e.Message}\r\n");
            builder.AppendLine($"  Exception ->\r\n");
            builder.AppendLine($"{e}");

            return builder.ToString();
        }

        private static string GetFirmwareData()
        {
            if (!EFIROM.FirmwareLoaded)
                return "There is no UEFI/BIOS loaded.\r\n";

            StringBuilder builder = new StringBuilder();

            try
            {
                if (IFD.IsDescriptorMode)
                {
                    builder.AppendLine($"  Descriptor ->\r\n");
                    builder.AppendLine($"Descriptor Mode: {IFD.IsDescriptorMode}\r\n");
                    builder.AppendLine($"PDR Base:  0x{IFD.PDR_REGION_BASE:X}h, PDR Limit: 0x{IFD.PDR_REGION_LIMIT:X}h");
                    builder.AppendLine($"ME Base:   0x{IFD.ME_REGION_BASE:X}h, ME Limit: 0x{IFD.ME_REGION_LIMIT:X}h");
                    builder.AppendLine($"BIOS Base: 0x{IFD.BIOS_REGION_BASE:X}h, BIOS Limit: 0x{IFD.BIOS_REGION_LIMIT:X}h\r\n");
                }

                builder.AppendLine($"  File ->\r\n");
                builder.AppendLine($"File Size: {EFIROM.FileInfoData.Length:X}h\r\n");

                builder.AppendLine($"  Fsys Store  ->\r\n");
                builder.AppendLine($"Fsys Base:    0x{EFIROM.FsysStoreData.FsysBase:X}h");
                builder.AppendLine($"Fsys Size:    {EFIROM.FSYS_RGN_SIZE:X}h");
                builder.AppendLine($"Serial Base:  0x{EFIROM.FsysStoreData.SerialBase:X}h");
                builder.AppendLine($"HWC Base:     0x{EFIROM.FsysStoreData.HWCBase:X}h\r\n");

                builder.AppendLine($"  NVRAM  ->\r\n");
                builder.AppendLine($"NVRAM Region:  Base 0x{EFIROM.NVRAM_BASE:X}h, Size {EFIROM.NVRAM_SIZE:X}h");
                builder.AppendLine($"VSS Primary:   Base 0x{EFIROM.VssStoreData.PrimaryStoreBase:X}h, Size {EFIROM.VssStoreData.PrimaryStoreSize:X}h");
                builder.AppendLine($"VSS Backup:    Base 0x{EFIROM.VssStoreData.BackupStoreBase:X}h, Size {EFIROM.VssStoreData.BackupStoreSize:X}h");
                builder.AppendLine($"SVS Primary:   Base 0x{EFIROM.SvsStoreData.PrimaryStoreBase:X}h, Size {EFIROM.SvsStoreData.PrimaryStoreSize:X}h");
                builder.AppendLine($"SVS Backup:    Base 0x{EFIROM.SvsStoreData.BackupStoreBase:X}h, Size {EFIROM.SvsStoreData.BackupStoreSize:X}h");

                return builder.ToString();
            }
            catch (Exception e)
            {
                Logger.WriteExceptionToAppLog(e);
                return null;
            }
        }

        private static string GetProcessModules()
        {
            int moduleNumber = 0;
            StringBuilder builder = new StringBuilder();

            try
            {
                foreach (ProcessModule module in Process.GetCurrentProcess().Modules)
                {
                    moduleNumber++;

                    builder.AppendLine($"  Module #{moduleNumber} -> '{module.ModuleName}'\r\n");
                    builder.AppendLine($"Path:         {module.FileName}");
                    builder.AppendLine($"Version:      {module.FileVersionInfo.FileVersion}");
                    builder.AppendLine($"Description:  {module.FileVersionInfo.FileDescription}");
                    builder.AppendLine($"Size (Bytes): {module.ModuleMemorySize}");
                    builder.AppendLine($"Base Address: {module.BaseAddress}");
                    builder.AppendLine($"Entry Point:  {module.EntryPointAddress}\r\n");
                }

                return builder.ToString();
            }
            catch (Exception e)
            {
                Logger.WriteExceptionToAppLog(e);
                return null;
            }
        }

    }
}