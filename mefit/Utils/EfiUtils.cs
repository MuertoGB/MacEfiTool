﻿// Mac EFI Toolkit
// https://github.com/MuertoGB/MacEfiToolkit

// EfiUtils.cs
// Released under the GNU GLP v3.0

using Mac_EFI_Toolkit.Common;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Mac_EFI_Toolkit.Utils
{
    class EFIUtils
    {

        /// <summary>
        /// Retrieves the configuration model string for a given HWC identifier. 
        /// Prioritizes retrieving data from the embedded XML db. 
        /// Falls back to retrieving data from the Apple server if not found in the XML resource.
        /// </summary>
        /// <param name="hwcString">The HWC identifier to retrieve a model string for.</param>
        /// <returns>The model string.</returns>
        internal static async Task<string> GetDeviceConfigCodeAsync(string hwcString)
        {
            try
            {
                // Attempt to load the data from the embedded XML db
                byte[] xmlData = Encoding.UTF8.GetBytes(Properties.Resources.modeldb);
                using (MemoryStream stream = new MemoryStream(xmlData))
                {
                    XDocument xmlDoc = XDocument.Load(stream);
                    string name = xmlDoc.Descendants("section")
                        .FirstOrDefault(e => e.Element("cfgCode")?.Value == hwcString)
                        ?.Element("model")?.Value;

                    if (!string.IsNullOrEmpty(name))
                    {
                        return name;
                    }
                }

                // Retrieve data from the Apple server
                string url = $"http://support-sp.apple.com/sp/product?cc={hwcString}";
                if (!NetUtils.GetIsWebsiteAvailable(url))
                {
                    return null;
                }

                string xml = await new WebClient().DownloadStringTaskAsync(url);
                XDocument doc = XDocument.Parse(xml);
                string data = doc.XPathSelectElement("/root/configCode")?.Value;

                if (data != null)
                {
                    Logger.WriteToLogFile($"'{hwcString}' not present in local db > Server returned: '{data}'", LogType.Database);
                }

                return data ?? null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Checks if a given input string contains only valid characters for a serial number.
        /// </summary>
        /// <param name="charString">The serial number string to check.</param>
        /// <returns>True if the input string contains only valid characters, otherwise false.</returns>
        internal static bool GetIsValidSerialChars(string charString)
        {
            return Regex.IsMatch(charString, "^[0-9A-Z]+$");
        }

        /// <summary>
        /// Calculates an Fsys region CRC32 checksum.
        /// </summary>
        /// /// <param name="fsysStore">The Fsys region to calcuate the CRC32 for.</param>
        /// <returns>The calculated Fsys CRC32 uint</returns>
        internal static uint GetUintFsysCrc32(byte[] fsysStore)
        {
            if (fsysStore.Length < FWBase.FSYS_RGN_SIZE)
                throw new ArgumentException(nameof(fsysStore), "Given bytes are too small.");

            if (fsysStore.Length > FWBase.FSYS_RGN_SIZE)
                throw new ArgumentException(nameof(fsysStore), "Given bytes are too large.");

            // Data we calculate is: Sig base + 0x800h - crc len of 0x4h = 7FCh
            byte[] bytesTempFsys = new byte[FWBase.FSYS_CRC_POS];

            if (fsysStore != null)
            {
                Array.Copy(fsysStore, 0, bytesTempFsys, 0, bytesTempFsys.Length);
                return FileUtils.GetCrc32Digest(bytesTempFsys);
            }

            return 0xFFFFFFFF;
        }

    }
}