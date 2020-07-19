using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows10TroubleRemover.Enums;

namespace Windows10TroubleRemover
{
    public static class RegistryFactory
    {
        public static RegistryKeyClass Create(string hkeyPath, EActivationParameter enableFunction, string allowText, RegistryValueKind valueKind, ERegistryHkey hkey = ERegistryHkey.LOCALMACHINE)
        {
            return new RegistryKeyClass(hkeyPath, enableFunction, allowText, valueKind, hkey);
        }

        public static RegistryKeyClass CreateStartupCheck(string hkeyPath, string allowText, ERegistryHkey hkey = ERegistryHkey.LOCALMACHINE)
        {
            return new RegistryKeyClass(hkeyPath, allowText, hkey);
        }
    }
}
