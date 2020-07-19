using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows10TroubleRemover.Enums;

namespace Windows10TroubleRemover
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            CheckEnabledOption(); //Check all registry values, and if a Path or Subkey is missing create them (if user agree)
        }


        /// <summary>
        /// Cycle through each pair in dictionary which define all settings, if subkey or regpath is missing ask to create them
        /// Also decide if a registry option is enabled or not, and adjusts the visible controls
        /// </summary>
        private void CheckEnabledOption()
        {
            foreach (KeyValuePair<string, string> vp in Tools.CONFIGSETTINGS)
            {
                RegistryKeyClass rk = null;

                if (vp.Key == Tools.NOSTARTUPDELAY || vp.Key == Tools.NOBINGSEARCH) //These both are actually CURRENTUSER settings
                {
                    rk = RegistryFactory.CreateStartupCheck(vp.Value, vp.Key, ERegistryHkey.CURRENTUSER);
                }
                else
                {
                    rk = RegistryFactory.CreateStartupCheck(vp.Value, vp.Key);
                }

                string controlName = vp.Key;
                CheckBox actualCtrl = (CheckBox)FindCheckBoxWithGivenName(controlName);

                if (actualCtrl != null)
                {
                    actualCtrl.Checked = (rk.KeyOff == true) ? false : true;
                }
                else
                {
                    MessageBox.Show($"Control for {vp.Key} not found!");
                }
            }
        }


        /// <summary>
        /// Applying all changes and asking for a direct restart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("To apply the settings a reboot is required. Do you want to restart your computer now?", "Restart now?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Process.Start("shutdown", "/r /t 0");
            }
        }

        #region Events

        private void ckbxDisableCortana_CheckedChanged(object sender, EventArgs e)
        {
            RegistryFactory.Create(Tools.CORTANA_HKEY, BoolToEnum(ckbxAllowCortana.Checked), Tools.ALLOWCORTANA, Microsoft.Win32.RegistryValueKind.DWord);
        }

        private void ckbxDataCollectionEnabled_CheckedChanged(object sender, EventArgs e)
        {
            RegistryFactory.Create(Tools.DATACOLLECTION_HKEY, BoolToEnum(ckbxAllowTelemetry.Checked), Tools.ALLOWTELEMETRY, Microsoft.Win32.RegistryValueKind.DWord);
        }

        private void ckbxFastBootEnabled_CheckedChanged(object sender, EventArgs e)
        {
            RegistryFactory.Create(Tools.FASTBOOT_HKEY, BoolToEnum(ckbxHiberbootEnabled.Checked), Tools.ALLOWFASTBOOT, Microsoft.Win32.RegistryValueKind.DWord);
        }

        private void ckbxAUOptions_CheckedChanged(object sender, EventArgs e)
        {
            RegistryFactory.Create(Tools.AUTOUPDATE_HKEY, BoolToEnum(ckbxNoAutoUpdate.Checked), Tools.ALLOWAUTOUPDATE, Microsoft.Win32.RegistryValueKind.DWord);
        }

        private void ckbxDisableAntiSpyware_CheckedChanged(object sender, EventArgs e)
        {
            RegistryFactory.Create(Tools.DEFENDER_HKEY, BoolToEnum(ckbxDisableAntiSpyware.Checked), Tools.DISABLEANTISPY, Microsoft.Win32.RegistryValueKind.DWord);
        }

        private void ckbxEnableMmx_CheckedChanged(object sender, EventArgs e)
        {
            RegistryFactory.Create(Tools.WINDOWS_DEF_REG_HKEY, BoolToEnum(ckbxEnableMmx.Checked), Tools.DISABLEYOURPHONE, Microsoft.Win32.RegistryValueKind.DWord);
        }

        private void ckbxPersonalization_CheckedChanged(object sender, EventArgs e)
        {
            RegistryFactory.Create(Tools.NOLOCKSCREEN_HK, BoolToEnum(ckbxNoLockScreen.Checked), Tools.NOLOCKSCREEN, Microsoft.Win32.RegistryValueKind.DWord);
        }

        private void ckbxDisableSearchBoxSuggestions_CheckedChanged(object sender, EventArgs e)
        {
            RegistryFactory.Create(Tools.WINDOWS_DEF_EXP_HKEY, BoolToEnum(ckbxDisableSearchBoxSuggestions.Checked), Tools.NOBINGSEARCH, Microsoft.Win32.RegistryValueKind.DWord);
        }

        private void ckbxStartupDelayInMSec_CheckedChanged(object sender, EventArgs e)
        {
            RegistryFactory.Create(Tools.NOSTARTUPDELAY_HK, BoolToEnum(ckbxStartupDelayInMSec.Checked), Tools.NOSTARTUPDELAY, Microsoft.Win32.RegistryValueKind.DWord, ERegistryHkey.CURRENTUSER);
        }

        private void btnUninstallOneDrive_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to uninstall OneDrive from this Computer?", "Uninstall OneDrive?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Process.Start("taskkill /f /im OneDrive.exe");
                }
                catch (System.ComponentModel.Win32Exception ex)
                {
                    //Nothing to show, if OneDrive is NOT running, this exception would be thrown
                }

                try
                {
                    Process.Start(@"%SystemRoot%\SysWOW64\OneDriveSetup.exe /uninstall");
                }
                catch (System.ComponentModel.Win32Exception ex)
                {
                    MessageBox.Show("OneDrive could not be uninstallled, is it already uninstalled?");
                }
            }
        }

        #endregion

        /// <summary>
        /// Simple method to get all child control items on the form
        /// </summary>
        /// <param name="control"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        /// <summary>
        /// Get Checkbox with the parsed name
        /// </summary>
        /// <param name="name">Name of Checkbox control</param>
        /// <returns>Checkbox control, else null</returns>
        private Control FindCheckBoxWithGivenName(string name)
        {
            var ckbx = GetAll(this, typeof(CheckBox));
            foreach (Control c in ckbx)
                if (c.Name.Contains(name))
                    return c;

            return null;
        }

        private EActivationParameter BoolToEnum(bool b)
        {
            if (b) { return EActivationParameter.On; }
            else { return EActivationParameter.Off; }
        }
    }
}
