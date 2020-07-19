namespace Windows10TroubleRemover
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.ckbxEnableMmx = new System.Windows.Forms.CheckBox();
            this.ckbxNoAutoUpdate = new System.Windows.Forms.CheckBox();
            this.ckbxAllowTelemetry = new System.Windows.Forms.CheckBox();
            this.ckbxAllowCortana = new System.Windows.Forms.CheckBox();
            this.gbSecurity = new System.Windows.Forms.GroupBox();
            this.ckbxNoLockScreen = new System.Windows.Forms.CheckBox();
            this.ckbxDisableAntiSpyware = new System.Windows.Forms.CheckBox();
            this.gbPerformance = new System.Windows.Forms.GroupBox();
            this.ckbxHiberbootEnabled = new System.Windows.Forms.CheckBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.ckbxDisableSearchBoxSuggestions = new System.Windows.Forms.CheckBox();
            this.btnUninstallOneDrive = new System.Windows.Forms.Button();
            this.ckbxStartupDelayInMSec = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.gbSecurity.SuspendLayout();
            this.gbPerformance.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.gbGeneral, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.gbSecurity, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.gbPerformance, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.gbSettings, 1, 1);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1054, 560);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.ckbxDisableSearchBoxSuggestions);
            this.gbGeneral.Controls.Add(this.ckbxEnableMmx);
            this.gbGeneral.Controls.Add(this.ckbxNoAutoUpdate);
            this.gbGeneral.Controls.Add(this.ckbxAllowTelemetry);
            this.gbGeneral.Controls.Add(this.ckbxAllowCortana);
            this.gbGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gbGeneral.Location = new System.Drawing.Point(3, 3);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(521, 274);
            this.gbGeneral.TabIndex = 0;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            // 
            // ckbxEnableMmx
            // 
            this.ckbxEnableMmx.AutoSize = true;
            this.ckbxEnableMmx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ckbxEnableMmx.Location = new System.Drawing.Point(18, 98);
            this.ckbxEnableMmx.Name = "ckbxEnableMmx";
            this.ckbxEnableMmx.Size = new System.Drawing.Size(174, 24);
            this.ckbxEnableMmx.TabIndex = 3;
            this.ckbxEnableMmx.Text = "YourPhone Enabled";
            this.ckbxEnableMmx.UseVisualStyleBackColor = true;
            this.ckbxEnableMmx.CheckedChanged += new System.EventHandler(this.ckbxEnableMmx_CheckedChanged);
            // 
            // ckbxNoAutoUpdate
            // 
            this.ckbxNoAutoUpdate.AutoSize = true;
            this.ckbxNoAutoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ckbxNoAutoUpdate.Location = new System.Drawing.Point(18, 128);
            this.ckbxNoAutoUpdate.Name = "ckbxNoAutoUpdate";
            this.ckbxNoAutoUpdate.Size = new System.Drawing.Size(256, 24);
            this.ckbxNoAutoUpdate.TabIndex = 2;
            this.ckbxNoAutoUpdate.Text = "Windows Autoupdate Disabled";
            this.ckbxNoAutoUpdate.UseVisualStyleBackColor = true;
            this.ckbxNoAutoUpdate.CheckedChanged += new System.EventHandler(this.ckbxAUOptions_CheckedChanged);
            // 
            // ckbxAllowTelemetry
            // 
            this.ckbxAllowTelemetry.AutoSize = true;
            this.ckbxAllowTelemetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ckbxAllowTelemetry.Location = new System.Drawing.Point(18, 68);
            this.ckbxAllowTelemetry.Name = "ckbxAllowTelemetry";
            this.ckbxAllowTelemetry.Size = new System.Drawing.Size(203, 24);
            this.ckbxAllowTelemetry.TabIndex = 1;
            this.ckbxAllowTelemetry.Text = "DataCollection Enabled";
            this.ckbxAllowTelemetry.UseVisualStyleBackColor = true;
            this.ckbxAllowTelemetry.CheckedChanged += new System.EventHandler(this.ckbxDataCollectionEnabled_CheckedChanged);
            // 
            // ckbxAllowCortana
            // 
            this.ckbxAllowCortana.AutoSize = true;
            this.ckbxAllowCortana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ckbxAllowCortana.Location = new System.Drawing.Point(18, 38);
            this.ckbxAllowCortana.Name = "ckbxAllowCortana";
            this.ckbxAllowCortana.Size = new System.Drawing.Size(152, 24);
            this.ckbxAllowCortana.TabIndex = 0;
            this.ckbxAllowCortana.Text = "Cortana Enabled";
            this.ckbxAllowCortana.UseVisualStyleBackColor = true;
            this.ckbxAllowCortana.CheckedChanged += new System.EventHandler(this.ckbxDisableCortana_CheckedChanged);
            // 
            // gbSecurity
            // 
            this.gbSecurity.Controls.Add(this.ckbxNoLockScreen);
            this.gbSecurity.Controls.Add(this.ckbxDisableAntiSpyware);
            this.gbSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gbSecurity.Location = new System.Drawing.Point(530, 3);
            this.gbSecurity.Name = "gbSecurity";
            this.gbSecurity.Size = new System.Drawing.Size(521, 274);
            this.gbSecurity.TabIndex = 1;
            this.gbSecurity.TabStop = false;
            this.gbSecurity.Text = "Security";
            // 
            // ckbxNoLockScreen
            // 
            this.ckbxNoLockScreen.AutoSize = true;
            this.ckbxNoLockScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ckbxNoLockScreen.Location = new System.Drawing.Point(15, 68);
            this.ckbxNoLockScreen.Name = "ckbxNoLockScreen";
            this.ckbxNoLockScreen.Size = new System.Drawing.Size(333, 24);
            this.ckbxNoLockScreen.TabIndex = 4;
            this.ckbxNoLockScreen.Text = "Windows Login Screen Disabled (no pin)";
            this.ckbxNoLockScreen.UseVisualStyleBackColor = true;
            this.ckbxNoLockScreen.CheckedChanged += new System.EventHandler(this.ckbxPersonalization_CheckedChanged);
            // 
            // ckbxDisableAntiSpyware
            // 
            this.ckbxDisableAntiSpyware.AutoSize = true;
            this.ckbxDisableAntiSpyware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ckbxDisableAntiSpyware.Location = new System.Drawing.Point(15, 38);
            this.ckbxDisableAntiSpyware.Name = "ckbxDisableAntiSpyware";
            this.ckbxDisableAntiSpyware.Size = new System.Drawing.Size(235, 24);
            this.ckbxDisableAntiSpyware.TabIndex = 3;
            this.ckbxDisableAntiSpyware.Text = "Windows Defender Enabled";
            this.ckbxDisableAntiSpyware.UseVisualStyleBackColor = true;
            this.ckbxDisableAntiSpyware.CheckedChanged += new System.EventHandler(this.ckbxDisableAntiSpyware_CheckedChanged);
            // 
            // gbPerformance
            // 
            this.gbPerformance.Controls.Add(this.ckbxStartupDelayInMSec);
            this.gbPerformance.Controls.Add(this.ckbxHiberbootEnabled);
            this.gbPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gbPerformance.Location = new System.Drawing.Point(3, 283);
            this.gbPerformance.Name = "gbPerformance";
            this.gbPerformance.Size = new System.Drawing.Size(521, 274);
            this.gbPerformance.TabIndex = 2;
            this.gbPerformance.TabStop = false;
            this.gbPerformance.Text = "Performance";
            // 
            // ckbxHiberbootEnabled
            // 
            this.ckbxHiberbootEnabled.AutoSize = true;
            this.ckbxHiberbootEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ckbxHiberbootEnabled.Location = new System.Drawing.Point(18, 38);
            this.ckbxHiberbootEnabled.Name = "ckbxHiberbootEnabled";
            this.ckbxHiberbootEnabled.Size = new System.Drawing.Size(185, 24);
            this.ckbxHiberbootEnabled.TabIndex = 2;
            this.ckbxHiberbootEnabled.Text = "Fast Startup Enabled";
            this.ckbxHiberbootEnabled.UseVisualStyleBackColor = true;
            this.ckbxHiberbootEnabled.CheckedChanged += new System.EventHandler(this.ckbxFastBootEnabled_CheckedChanged);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.btnUninstallOneDrive);
            this.gbSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gbSettings.Location = new System.Drawing.Point(530, 283);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(521, 274);
            this.gbSettings.TabIndex = 3;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnApplySettings);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 571);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1054, 77);
            this.panelControls.TabIndex = 1;
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplySettings.Location = new System.Drawing.Point(929, 24);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(101, 35);
            this.btnApplySettings.TabIndex = 0;
            this.btnApplySettings.Text = "Apply Changes";
            this.btnApplySettings.UseVisualStyleBackColor = true;
            this.btnApplySettings.Click += new System.EventHandler(this.btnApplySettings_Click);
            // 
            // ckbxDisableSearchBoxSuggestions
            // 
            this.ckbxDisableSearchBoxSuggestions.AutoSize = true;
            this.ckbxDisableSearchBoxSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ckbxDisableSearchBoxSuggestions.Location = new System.Drawing.Point(18, 158);
            this.ckbxDisableSearchBoxSuggestions.Name = "ckbxDisableSearchBoxSuggestions";
            this.ckbxDisableSearchBoxSuggestions.Size = new System.Drawing.Size(191, 24);
            this.ckbxDisableSearchBoxSuggestions.TabIndex = 4;
            this.ckbxDisableSearchBoxSuggestions.Text = "Bing Search Disabled";
            this.ckbxDisableSearchBoxSuggestions.UseVisualStyleBackColor = true;
            this.ckbxDisableSearchBoxSuggestions.CheckedChanged += new System.EventHandler(this.ckbxDisableSearchBoxSuggestions_CheckedChanged);
            // 
            // btnUninstallOneDrive
            // 
            this.btnUninstallOneDrive.Location = new System.Drawing.Point(15, 38);
            this.btnUninstallOneDrive.Name = "btnUninstallOneDrive";
            this.btnUninstallOneDrive.Size = new System.Drawing.Size(160, 30);
            this.btnUninstallOneDrive.TabIndex = 0;
            this.btnUninstallOneDrive.Text = "Uninstall OneDrive";
            this.btnUninstallOneDrive.UseVisualStyleBackColor = true;
            this.btnUninstallOneDrive.Click += new System.EventHandler(this.btnUninstallOneDrive_Click);
            // 
            // ckbxStartupDelayInMSec
            // 
            this.ckbxStartupDelayInMSec.AutoSize = true;
            this.ckbxStartupDelayInMSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ckbxStartupDelayInMSec.Location = new System.Drawing.Point(18, 68);
            this.ckbxStartupDelayInMSec.Name = "ckbxStartupDelayInMSec";
            this.ckbxStartupDelayInMSec.Size = new System.Drawing.Size(195, 24);
            this.ckbxStartupDelayInMSec.TabIndex = 3;
            this.ckbxStartupDelayInMSec.Text = "Startup Delay Enabled";
            this.ckbxStartupDelayInMSec.UseVisualStyleBackColor = true;
            this.ckbxStartupDelayInMSec.CheckedChanged += new System.EventHandler(this.ckbxStartupDelayInMSec_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1054, 648);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MaximumSize = new System.Drawing.Size(1070, 687);
            this.MinimumSize = new System.Drawing.Size(486, 363);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eXPresso\'s Windows Trouble Remover";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.gbSecurity.ResumeLayout(false);
            this.gbSecurity.PerformLayout();
            this.gbPerformance.ResumeLayout(false);
            this.gbPerformance.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.GroupBox gbSecurity;
        private System.Windows.Forms.GroupBox gbPerformance;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.CheckBox ckbxAllowCortana;
        private System.Windows.Forms.Button btnApplySettings;
        private System.Windows.Forms.CheckBox ckbxAllowTelemetry;
        private System.Windows.Forms.CheckBox ckbxHiberbootEnabled;
        private System.Windows.Forms.CheckBox ckbxNoAutoUpdate;
        private System.Windows.Forms.CheckBox ckbxDisableAntiSpyware;
        private System.Windows.Forms.CheckBox ckbxEnableMmx;
        private System.Windows.Forms.CheckBox ckbxNoLockScreen;
        private System.Windows.Forms.CheckBox ckbxDisableSearchBoxSuggestions;
        private System.Windows.Forms.Button btnUninstallOneDrive;
        private System.Windows.Forms.CheckBox ckbxStartupDelayInMSec;
    }
}

