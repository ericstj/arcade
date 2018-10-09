// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Microsoft.DotNet.SignTool
{
    struct SignableExtension
    {
        public string Extension { get; set; }

        public SignableExtension(string extension)
        {
            Extension = extension;
        }
    }

    internal static class SignToolConstants
    {
        public const string IgnoreFileCertificateSentinel = "None";

        /// <summary>
        /// List of known signable extensions. Copied, removing duplicates, from here:
        /// https://microsoft.sharepoint.com/teams/codesigninfo/Wiki/Signable%20Files.aspx
        /// </summary>
        public static SignableExtension[] SignableExtensions = new SignableExtension[]
        {
            new SignableExtension(".exe"),
            new SignableExtension(".dll"),
            new SignableExtension(".rll"),
            new SignableExtension(".olb"),
            new SignableExtension(".ocx"),

            new SignableExtension(".cab"),

            new SignableExtension(".cat"),

            new SignableExtension(".vbs"),
            new SignableExtension(".js"),
            new SignableExtension(".wfs"),

            new SignableExtension(".msi"),
            new SignableExtension(".mui"),
            new SignableExtension(".msp"),
            new SignableExtension(".msu"),
            new SignableExtension(".psf"),
            new SignableExtension(".mpb"),
            new SignableExtension(".mp"),
            new SignableExtension(".msm"),

            new SignableExtension(".doc"),
            new SignableExtension(".xls"),
            new SignableExtension(".ppt"),
            new SignableExtension(".xla"),
            new SignableExtension(".vdx"),
            new SignableExtension(".xsn"),
            new SignableExtension(".mpp"),

            new SignableExtension(".xlam"),
            new SignableExtension(".xlsb"),
            new SignableExtension(".xlsm"),
            new SignableExtension(".xltm"),
            new SignableExtension(".potm"),
            new SignableExtension(".ppsm"),
            new SignableExtension(".pptm"),
            new SignableExtension(".docm"),
            new SignableExtension(".dotm"),

            new SignableExtension(".ttf"),
            new SignableExtension(".otf"),

            new SignableExtension(".ps1"),
            new SignableExtension(".ps1xml"),
            new SignableExtension(".psm1"),
            new SignableExtension(".psd1"),
            new SignableExtension(".psc1"),
            new SignableExtension(".cdxml"),
            new SignableExtension(".wsf"),
            new SignableExtension(".mof"),

            new SignableExtension(".sft"),
            new SignableExtension(".dsft"),

            new SignableExtension(".vsi"),

            new SignableExtension(".xap"),

            new SignableExtension(".efi"),

            new SignableExtension(".vsix"),

            new SignableExtension(".jar"),

            new SignableExtension(".winmd"),

            new SignableExtension(".appx"),
            new SignableExtension(".appxbundle"),

            new SignableExtension(".esd"),

            new SignableExtension(".py"),
            new SignableExtension(".pyd"),
        };
    }
}
