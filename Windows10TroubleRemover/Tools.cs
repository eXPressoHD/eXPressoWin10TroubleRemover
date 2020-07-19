using Microsoft.Win32;
using System.Collections.Generic;
using System.Configuration;

namespace Windows10TroubleRemover
{
    public static class Tools
    {
        //Defaultkeys
        public const int ALLOWDWORD = 1;
        public const int FORBIDDWORD = 0;

        public const string REG_ROOT_PATH = @"Computer";

        public static Dictionary<string, string> CONFIGSETTINGS = new Dictionary<string, string>()
        {
            {ALLOWCORTANA, CORTANA_HKEY },
            {ALLOWTELEMETRY, DATACOLLECTION_HKEY },
            {ALLOWFASTBOOT, FASTBOOT_HKEY },
            {ALLOWAUTOUPDATE, FASTBOOT_HKEY },
            {DISABLEANTISPY, DEFENDER_HKEY },
            {DISABLEYOURPHONE, WINDOWS_DEF_REG_HKEY },
            {NOLOCKSCREEN, NOLOCKSCREEN_HK },
            {NOBINGSEARCH, WINDOWS_DEF_EXP_HKEY },
            {NOSTARTUPDELAY, NOSTARTUPDELAY_HK }
        };

        #region regKeys

        //Default paths
        public const string WINDOWS_DEF_REG_HKEY = @"SOFTWARE\Policies\Microsoft\Windows";
        public const string WINDOWS_DEF_EXP_HKEY = @"SOFTWARE\Policies\Microsoft\Windows\Explorer";

        //Cortana related keys
        public const string ALLOWCORTANA = "AllowCortana";
        public const string CORTANA_HKEY = @"SOFTWARE\Policies\Microsoft\Windows\Windows Search";


        //DataCollection related keys 
        public const string ALLOWTELEMETRY = "AllowTelemetry";
        public const string DATACOLLECTION_HKEY = @"SOFTWARE\Policies\Microsoft\Windows\DataCollection";

        //Fastboot related
        public const string ALLOWFASTBOOT = "HiberbootEnabled"; //DWORD
        public const string FASTBOOT_HKEY = @"SOFTWARE\Policies\Microsoft\Windows\System";

        //AutoUpdates related
        public const string ALLOWAUTOUPDATE = "NoAutoUpdate";
        public const string AUTOUPDATE_HKEY = @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU";

        //Windows defender
        public const string DISABLEANTISPY = "DisableAntiSpyware";
        public const string DEFENDER_HKEY = @"SOFTWARE\Policies\Microsoft\Windows Defender";

        //Your Phone
        public const string DISABLEYOURPHONE = "EnableMmx";

        //No Lock Screen
        public const string NOLOCKSCREEN = "NoLockScreen";
        public const string NOLOCKSCREEN_HK = @"SOFTWARE\Policies\Microsoft\Windows\Personalization";

        //NoBingSearch
        public const string NOBINGSEARCH = "DisableSearchBoxSuggestions";

        //NoStartupDelay
        public const string NOSTARTUPDELAY_HK = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Serialize";
        public const string NOSTARTUPDELAY = "StartupDelayInMSec";


        #endregion
    }
}
