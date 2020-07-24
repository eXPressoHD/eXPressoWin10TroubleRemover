using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows10TroubleRemover.Enums;

namespace Windows10TroubleRemover
{
    public class RegistryKeyClass
    {
        #region Fields and Properties
        private Microsoft.Win32.RegistryKey _registryKey;

        public Microsoft.Win32.RegistryKey RegistryKey
        {
            get { return _registryKey; }
            set { _registryKey = value; }
        }

        public bool RegisterKeyAvailable => (this._registryKey == null) ? false : true;

        public bool KeyOff { get; private set; }

        #endregion

        #region Constructors
        public RegistryKeyClass(string registryPath, EActivationParameter enableFunction, string allowText, RegistryValueKind valueKind, ERegistryHkey hkey)
        {
            SetHKeyFormat(registryPath, hkey);

            if (!RegisterKeyAvailable)
            {
                CreateMissingSubKey(registryPath, hkey);
            }

            if (RegisterKeyAvailable)
            {
                object registryKeyValue = this.RegistryKey.GetValue(allowText);

                if ((int?)registryKeyValue == null)
                {
                    this.SetRKValue(allowText, enableFunction, valueKind);
                }
                else
                {
                    switch (enableFunction)
                    {
                        case EActivationParameter.Off:
                            this.SetRKValue(allowText, (int)EActivationParameter.Off);
                            break;

                        case EActivationParameter.On:
                            this.SetRKValue(allowText, (int)EActivationParameter.On);
                            break;

                        case EActivationParameter.AdditionalSetting1:
                            this.SetRKValue(allowText, (int)EActivationParameter.AdditionalSetting1);
                            break;

                        case EActivationParameter.AdditionalSetting2:
                            this.SetRKValue(allowText, (int)EActivationParameter.AdditionalSetting2);
                            break;
                    }
                }
            }
        }

        public RegistryKeyClass(string registryPath, string allowText, ERegistryHkey hkey)
        {
            //Let user decide if the new created setting should be activated or not
            string configDefaultState = ConfigurationManager.AppSettings["DEFAULTCREATIONSTATE"].ToString();
            int state = configDefaultState == "1" ? 1 : 0;
            bool skipEnabled = false;

            bool functionThrough = false;

            while (!functionThrough)
            {
                try
                {
                    SetHKeyFormat(registryPath, hkey);

                    object registryKeyValue = _registryKey.GetValue(allowText);

                    if ((int?)registryKeyValue == 0)
                    {
                        KeyOff = true;
                    }
                    else if ((int?)registryKeyValue == 1)
                    {
                        KeyOff = false;
                    }

                    functionThrough = true;
                }
                catch (NullReferenceException ex)
                {
                    CreateMissingItems(registryPath, allowText, state, hkey, ref skipEnabled, ref functionThrough);
                }
            }
        }

        #endregion

        #region Private Methods
        private void CreateMissingItems(string registryPath, string allowText, int state, ERegistryHkey hkey, ref bool skipEnabled, ref bool functionThrough)
        {
            if (skipEnabled)
            {
                if (_registryKey != null)
                {
                    //RK ONLY missing
                    this.SetRKValue(Path.Combine(registryPath, allowText), state, RegistryValueKind.DWord);
                }
                else
                {
                    //Complete path missing, so RK too
                    CreateMissingSubKey(registryPath, hkey);
                    this.SetRKValue(allowText, state, RegistryValueKind.DWord);
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Registry-Path miss some directories and settings, would you like to create them and retry?", "Create missing directories?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    skipEnabled = true;

                    if (_registryKey != null)
                    {
                        //RK ONLY missing
                        this.SetRKValue(Path.Combine(registryPath, allowText), state, RegistryValueKind.DWord);
                    }
                    else
                    {
                        //Complete path missing, so RK too
                        CreateMissingSubKey(registryPath, hkey);
                        this.SetRKValue(allowText, state, RegistryValueKind.DWord);
                    }
                }
                else
                {
                    functionThrough = true;
                }
            }
        }

        private bool SetRKValue(string name, object value, RegistryValueKind kind = RegistryValueKind.DWord)
        {
            try
            {
                this._registryKey.SetValue(name, value, kind);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        private bool CreateSubKey(string subKey)
        {
            try
            {
                this._registryKey.CreateSubKey(subKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Loops through each part of the path to decide which is the last existing path, and add the missing paths/subkeys
        /// </summary>
        /// <param name="shouldSubkey">Last ShouldKey which SHOULD exists, and lets the loop keep looping until this key is created</param>
        /// <param name="hkey">HKey type option</param>
        /// <returns>Returns Tuple with the lastValidPath and a List of all missing subkeys</returns>
        private (string, List<string>) GetLastAvailableSubkeyPath(string shouldSubkey, ERegistryHkey hkey)
        {
            List<String> missingSubKeys = new List<string>();

            string[] splittedPath = shouldSubkey.Split('\\');
            string concatinatedPath = string.Empty;
            int tries = splittedPath.Length - 1;
            string lastValidPath = String.Empty;

            for (int h = 0; h < splittedPath.Length; h++)
            {
                concatinatedPath += $"{splittedPath[h]}\\";

                SetHKeyFormat(concatinatedPath, hkey);

                if (!RegisterKeyAvailable)
                {
                    missingSubKeys.Add(splittedPath[tries]);
                    tries--;
                }
                else
                {
                    lastValidPath = concatinatedPath;
                }
            }

            SetHKeyFormat(lastValidPath, hkey);

            return (lastValidPath, missingSubKeys);
        }


        /// <summary>
        /// Decides how to Initialize the new registryKey with the given RegistryKeyoption like CurrentUser, LocalMachine..
        /// </summary>
        /// <param name="registryPath">Current registrypath which should be used</param>
        /// <param name="hkey">Enum of RegistryKeyOption like LocalMachine, CurrentUser etc.</param>
        private void SetHKeyFormat(string registryPath, ERegistryHkey hkey)
        {
            switch (hkey)
            {
                case ERegistryHkey.LOCALMACHINE:
                    _registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(registryPath, RegistryKeyPermissionCheck.ReadWriteSubTree);
                    break;

                case ERegistryHkey.CURRENTUSER:
                    _registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(registryPath, RegistryKeyPermissionCheck.ReadWriteSubTree);
                    break;
            }
        }


        /// <summary>
        /// Loops through each missing subkey which is given from the tuple and creates each one and tests if the created path is then available
        /// </summary>
        /// <param name="registryPath">Registrypath which doesnt work at all which should work at the end of this method</param>
        /// <param name="hkey">Hkey option</param>
        private void CreateMissingSubKey(string registryPath, ERegistryHkey hkey)
        {
            var result = this.GetLastAvailableSubkeyPath(registryPath, hkey);

            string validPath = result.Item1;

            result.Item2.Reverse();

            foreach (string missingSubkey in result.Item2)
            {
                this.CreateSubKey(missingSubkey);
                validPath += $"{missingSubkey}";
                _registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(validPath, RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
        }

        #endregion
    }
}
