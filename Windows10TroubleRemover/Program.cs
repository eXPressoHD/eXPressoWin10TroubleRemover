using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10TroubleRemover
{
    static class Program
    {
        public static bool IsAdministrator =>
        new WindowsPrincipal(WindowsIdentity.GetCurrent())
       .IsInRole(WindowsBuiltInRole.Administrator);

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (IsAdministrator)
            {
                Mutex m = new Mutex(true, "Win10TroubleRemover", out bool createdNew); // nicht threadsave, aber für diese anwendung ausreichend

                if (!createdNew)
                {
                    MessageBox.Show("Anwendung läuft bereits!");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
            else
            {
                MessageBox.Show("Application can only be started by a User with administration rights!");
            }
        }
    }
}
