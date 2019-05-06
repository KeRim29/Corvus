﻿using System.Windows.Forms;

namespace Corvus
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.gBoxUsernamePasswordLogin = new System.Windows.Forms.GroupBox();
            this.chkBoxSaveUsernamePassword = new System.Windows.Forms.CheckBox();
            this.lblPortal = new System.Windows.Forms.Label();
            this.comboBoxLoginPortal = new System.Windows.Forms.ComboBox();
            this.rbUsernamePasswordLogin = new System.Windows.Forms.RadioButton();
            this.chkBoxReconnect = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gBoxSessionIDLogin = new System.Windows.Forms.GroupBox();
            this.rbSessionIdLogin = new System.Windows.Forms.RadioButton();
            this.txtSessionId = new System.Windows.Forms.TextBox();
            this.lblSessionId = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.tabPageGalaxyGates = new System.Windows.Forms.TabPage();
            this.rbBuildGamma = new System.Windows.Forms.RadioButton();
            this.rbBuildBeta = new System.Windows.Forms.RadioButton();
            this.nudMinimumUridium = new System.Windows.Forms.NumericUpDown();
            this.lblMinimumUridium = new System.Windows.Forms.Label();
            this.chkBoxPlaceGate = new System.Windows.Forms.CheckBox();
            this.chkBoxSpinGate = new System.Windows.Forms.CheckBox();
            this.lblReceivedParts = new System.Windows.Forms.Label();
            this.nudGateDelay = new System.Windows.Forms.NumericUpDown();
            this.lblGateDelay = new System.Windows.Forms.Label();
            this.lblSpinCost = new System.Windows.Forms.Label();
            this.lblReceivedNanoHull = new System.Windows.Forms.Label();
            this.lblReceivedXenomit = new System.Windows.Forms.Label();
            this.lblReceivedRepairCredits = new System.Windows.Forms.Label();
            this.lblReceivedLogDisks = new System.Windows.Forms.Label();
            this.lblReceivedACM = new System.Windows.Forms.Label();
            this.lblReceivedPLT2021 = new System.Windows.Forms.Label();
            this.lblReceivedSAB = new System.Windows.Forms.Label();
            this.lblReceivedX4 = new System.Windows.Forms.Label();
            this.lblReceivedX3 = new System.Windows.Forms.Label();
            this.lblReceivedX2 = new System.Windows.Forms.Label();
            this.lblTotalSpins = new System.Windows.Forms.Label();
            this.lblExtraEnergy = new System.Windows.Forms.Label();
            this.lblUridium = new System.Windows.Forms.Label();
            this.dgvGates = new System.Windows.Forms.DataGridView();
            this.clmnGateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGateParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGateReady = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnGateOnMap = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmdResetGateStats = new System.Windows.Forms.Button();
            this.rbBuildKuiper = new System.Windows.Forms.RadioButton();
            this.rbBuildHades = new System.Windows.Forms.RadioButton();
            this.rbBuildKappa = new System.Windows.Forms.RadioButton();
            this.rbBuildLambda = new System.Windows.Forms.RadioButton();
            this.rbBuildZeta = new System.Windows.Forms.RadioButton();
            this.rbBuildEpsilon = new System.Windows.Forms.RadioButton();
            this.rbBuildDelta = new System.Windows.Forms.RadioButton();
            this.rbBuildAlpha = new System.Windows.Forms.RadioButton();
            this.tabPageTechFactory = new System.Windows.Forms.TabPage();
            this.chkBoxBuildTechs = new System.Windows.Forms.CheckBox();
            this.dgvTechFactory = new System.Windows.Forms.DataGridView();
            this.clmnTechName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTechAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTechBuilding = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnTechTimeLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTechBuild = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPageSkylab = new System.Windows.Forms.TabPage();
            this.chkBoxUpgradeSkylab = new System.Windows.Forms.CheckBox();
            this.dgvSkylab = new System.Windows.Forms.DataGridView();
            this.clmnModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnModuleLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnModuleUpgrading = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnModuleTimeLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnModuleUpgrade = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdOpenBackPage = new System.Windows.Forms.Button();
            this.lblLastStatus = new System.Windows.Forms.Label();
            this.cmdSaveSettings = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.gBoxUsernamePasswordLogin.SuspendLayout();
            this.gBoxSessionIDLogin.SuspendLayout();
            this.tabPageGalaxyGates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumUridium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGateDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGates)).BeginInit();
            this.tabPageTechFactory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechFactory)).BeginInit();
            this.tabPageSkylab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkylab)).BeginInit();
            this.tabPageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPageLogin);
            this.tcMain.Controls.Add(this.tabPageGalaxyGates);
            this.tcMain.Controls.Add(this.tabPageTechFactory);
            this.tcMain.Controls.Add(this.tabPageSkylab);
            this.tcMain.Controls.Add(this.tabPageLog);
            this.tcMain.Location = new System.Drawing.Point(17, 48);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1033, 450);
            this.tcMain.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.cmdLogin);
            this.tabPageLogin.Controls.Add(this.gBoxUsernamePasswordLogin);
            this.tabPageLogin.Controls.Add(this.gBoxSessionIDLogin);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Size = new System.Drawing.Size(1025, 421);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(24, 304);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(440, 28);
            this.cmdLogin.TabIndex = 7;
            this.cmdLogin.Text = "&Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // gBoxUsernamePasswordLogin
            // 
            this.gBoxUsernamePasswordLogin.Controls.Add(this.chkBoxSaveUsernamePassword);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.lblPortal);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.comboBoxLoginPortal);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.rbUsernamePasswordLogin);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.chkBoxReconnect);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.txtPassword);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.lblPassword);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.txtUsername);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.lblUsername);
            this.gBoxUsernamePasswordLogin.Location = new System.Drawing.Point(24, 26);
            this.gBoxUsernamePasswordLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxUsernamePasswordLogin.Name = "gBoxUsernamePasswordLogin";
            this.gBoxUsernamePasswordLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxUsernamePasswordLogin.Size = new System.Drawing.Size(440, 161);
            this.gBoxUsernamePasswordLogin.TabIndex = 0;
            this.gBoxUsernamePasswordLogin.TabStop = false;
            this.gBoxUsernamePasswordLogin.Text = "                                                      ";
            // 
            // chkBoxSaveUsernamePassword
            // 
            this.chkBoxSaveUsernamePassword.AutoSize = true;
            this.chkBoxSaveUsernamePassword.Checked = true;
            this.chkBoxSaveUsernamePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxSaveUsernamePassword.Location = new System.Drawing.Point(257, 124);
            this.chkBoxSaveUsernamePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxSaveUsernamePassword.Name = "chkBoxSaveUsernamePassword";
            this.chkBoxSaveUsernamePassword.Size = new System.Drawing.Size(94, 21);
            this.chkBoxSaveUsernamePassword.TabIndex = 11;
            this.chkBoxSaveUsernamePassword.Text = "&Save data";
            this.chkBoxSaveUsernamePassword.UseVisualStyleBackColor = true;
            // 
            // lblPortal
            // 
            this.lblPortal.AutoSize = true;
            this.lblPortal.Location = new System.Drawing.Point(8, 95);
            this.lblPortal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortal.Name = "lblPortal";
            this.lblPortal.Size = new System.Drawing.Size(49, 17);
            this.lblPortal.TabIndex = 10;
            this.lblPortal.Text = "&Portal:";
            // 
            // comboBoxLoginPortal
            // 
            this.comboBoxLoginPortal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoginPortal.FormattingEnabled = true;
            this.comboBoxLoginPortal.Items.AddRange(new object[] {
            "https://darkorbit.com/",
            "https://www.dark-orbit.it/",
            "https://lp.darkorbit.com/"});
            this.comboBoxLoginPortal.Location = new System.Drawing.Point(93, 91);
            this.comboBoxLoginPortal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLoginPortal.Name = "comboBoxLoginPortal";
            this.comboBoxLoginPortal.Size = new System.Drawing.Size(337, 24);
            this.comboBoxLoginPortal.TabIndex = 9;
            // 
            // rbUsernamePasswordLogin
            // 
            this.rbUsernamePasswordLogin.AutoSize = true;
            this.rbUsernamePasswordLogin.Location = new System.Drawing.Point(20, 0);
            this.rbUsernamePasswordLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbUsernamePasswordLogin.Name = "rbUsernamePasswordLogin";
            this.rbUsernamePasswordLogin.Size = new System.Drawing.Size(198, 21);
            this.rbUsernamePasswordLogin.TabIndex = 8;
            this.rbUsernamePasswordLogin.Text = "&Username/Password Login";
            this.rbUsernamePasswordLogin.UseVisualStyleBackColor = true;
            this.rbUsernamePasswordLogin.CheckedChanged += new System.EventHandler(this.rbUsernamePasswordLogin_CheckedChanged);
            // 
            // chkBoxReconnect
            // 
            this.chkBoxReconnect.AutoSize = true;
            this.chkBoxReconnect.Checked = true;
            this.chkBoxReconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxReconnect.Location = new System.Drawing.Point(93, 124);
            this.chkBoxReconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxReconnect.Name = "chkBoxReconnect";
            this.chkBoxReconnect.Size = new System.Drawing.Size(146, 21);
            this.chkBoxReconnect.TabIndex = 5;
            this.chkBoxReconnect.Text = "&Reconnect on kick";
            this.chkBoxReconnect.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 59);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(337, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 63);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "&Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(93, 27);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(337, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 31);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "&Username:";
            // 
            // gBoxSessionIDLogin
            // 
            this.gBoxSessionIDLogin.Controls.Add(this.rbSessionIdLogin);
            this.gBoxSessionIDLogin.Controls.Add(this.txtSessionId);
            this.gBoxSessionIDLogin.Controls.Add(this.lblSessionId);
            this.gBoxSessionIDLogin.Controls.Add(this.txtServer);
            this.gBoxSessionIDLogin.Controls.Add(this.lblServer);
            this.gBoxSessionIDLogin.Location = new System.Drawing.Point(24, 194);
            this.gBoxSessionIDLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxSessionIDLogin.Name = "gBoxSessionIDLogin";
            this.gBoxSessionIDLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxSessionIDLogin.Size = new System.Drawing.Size(440, 102);
            this.gBoxSessionIDLogin.TabIndex = 6;
            this.gBoxSessionIDLogin.TabStop = false;
            this.gBoxSessionIDLogin.Text = "                                    ";
            // 
            // rbSessionIdLogin
            // 
            this.rbSessionIdLogin.AutoSize = true;
            this.rbSessionIdLogin.Checked = true;
            this.rbSessionIdLogin.Location = new System.Drawing.Point(20, 0);
            this.rbSessionIdLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSessionIdLogin.Name = "rbSessionIdLogin";
            this.rbSessionIdLogin.Size = new System.Drawing.Size(129, 21);
            this.rbSessionIdLogin.TabIndex = 9;
            this.rbSessionIdLogin.TabStop = true;
            this.rbSessionIdLogin.Text = "&SessionId Login";
            this.rbSessionIdLogin.UseVisualStyleBackColor = true;
            this.rbSessionIdLogin.CheckedChanged += new System.EventHandler(this.rbSessionIdLogin_CheckedChanged);
            // 
            // txtSessionId
            // 
            this.txtSessionId.Location = new System.Drawing.Point(93, 60);
            this.txtSessionId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSessionId.Name = "txtSessionId";
            this.txtSessionId.Size = new System.Drawing.Size(337, 22);
            this.txtSessionId.TabIndex = 3;
            // 
            // lblSessionId
            // 
            this.lblSessionId.AutoSize = true;
            this.lblSessionId.Location = new System.Drawing.Point(8, 64);
            this.lblSessionId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSessionId.Name = "lblSessionId";
            this.lblSessionId.Size = new System.Drawing.Size(73, 17);
            this.lblSessionId.TabIndex = 2;
            this.lblSessionId.Text = "&SessionId:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(93, 28);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(337, 22);
            this.txtServer.TabIndex = 1;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(8, 32);
            this.lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(54, 17);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "&Server:";
            // 
            // tabPageGalaxyGates
            // 
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildGamma);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildBeta);
            this.tabPageGalaxyGates.Controls.Add(this.nudMinimumUridium);
            this.tabPageGalaxyGates.Controls.Add(this.lblMinimumUridium);
            this.tabPageGalaxyGates.Controls.Add(this.chkBoxPlaceGate);
            this.tabPageGalaxyGates.Controls.Add(this.chkBoxSpinGate);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedParts);
            this.tabPageGalaxyGates.Controls.Add(this.nudGateDelay);
            this.tabPageGalaxyGates.Controls.Add(this.lblGateDelay);
            this.tabPageGalaxyGates.Controls.Add(this.lblSpinCost);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedNanoHull);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedXenomit);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedRepairCredits);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedLogDisks);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedACM);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedPLT2021);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedSAB);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedX4);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedX3);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedX2);
            this.tabPageGalaxyGates.Controls.Add(this.lblTotalSpins);
            this.tabPageGalaxyGates.Controls.Add(this.lblExtraEnergy);
            this.tabPageGalaxyGates.Controls.Add(this.lblUridium);
            this.tabPageGalaxyGates.Controls.Add(this.dgvGates);
            this.tabPageGalaxyGates.Controls.Add(this.cmdResetGateStats);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildKuiper);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildHades);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildKappa);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildLambda);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildZeta);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildEpsilon);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildDelta);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildAlpha);
            this.tabPageGalaxyGates.Location = new System.Drawing.Point(4, 25);
            this.tabPageGalaxyGates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageGalaxyGates.Name = "tabPageGalaxyGates";
            this.tabPageGalaxyGates.Size = new System.Drawing.Size(1025, 421);
            this.tabPageGalaxyGates.TabIndex = 1;
            this.tabPageGalaxyGates.Text = "Galaxy Gates";
            this.tabPageGalaxyGates.UseVisualStyleBackColor = true;
            // 
            // rbBuildGamma
            // 
            this.rbBuildGamma.AutoSize = true;
            this.rbBuildGamma.Location = new System.Drawing.Point(27, 183);
            this.rbBuildGamma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBuildGamma.Name = "rbBuildGamma";
            this.rbBuildGamma.Size = new System.Drawing.Size(78, 21);
            this.rbBuildGamma.TabIndex = 33;
            this.rbBuildGamma.Text = "&Gamma";
            this.rbBuildGamma.UseVisualStyleBackColor = true;
            // 
            // rbBuildBeta
            // 
            this.rbBuildBeta.AutoSize = true;
            this.rbBuildBeta.Location = new System.Drawing.Point(27, 155);
            this.rbBuildBeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBuildBeta.Name = "rbBuildBeta";
            this.rbBuildBeta.Size = new System.Drawing.Size(58, 21);
            this.rbBuildBeta.TabIndex = 32;
            this.rbBuildBeta.Text = "&Beta";
            this.rbBuildBeta.UseVisualStyleBackColor = true;
            // 
            // nudMinimumUridium
            // 
            this.nudMinimumUridium.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinimumUridium.Location = new System.Drawing.Point(108, 95);
            this.nudMinimumUridium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudMinimumUridium.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMinimumUridium.Name = "nudMinimumUridium";
            this.nudMinimumUridium.Size = new System.Drawing.Size(79, 22);
            this.nudMinimumUridium.TabIndex = 31;
            this.nudMinimumUridium.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblMinimumUridium
            // 
            this.lblMinimumUridium.AutoSize = true;
            this.lblMinimumUridium.Location = new System.Drawing.Point(23, 97);
            this.lblMinimumUridium.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimumUridium.Name = "lblMinimumUridium";
            this.lblMinimumUridium.Size = new System.Drawing.Size(84, 17);
            this.lblMinimumUridium.TabIndex = 30;
            this.lblMinimumUridium.Text = "&Min uridium:";
            // 
            // chkBoxPlaceGate
            // 
            this.chkBoxPlaceGate.AutoSize = true;
            this.chkBoxPlaceGate.Location = new System.Drawing.Point(27, 73);
            this.chkBoxPlaceGate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxPlaceGate.Name = "chkBoxPlaceGate";
            this.chkBoxPlaceGate.Size = new System.Drawing.Size(148, 21);
            this.chkBoxPlaceGate.TabIndex = 29;
            this.chkBoxPlaceGate.Text = "&Place gate on map";
            this.chkBoxPlaceGate.UseVisualStyleBackColor = true;
            // 
            // chkBoxSpinGate
            // 
            this.chkBoxSpinGate.AutoSize = true;
            this.chkBoxSpinGate.Location = new System.Drawing.Point(27, 12);
            this.chkBoxSpinGate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxSpinGate.Name = "chkBoxSpinGate";
            this.chkBoxSpinGate.Size = new System.Drawing.Size(90, 21);
            this.chkBoxSpinGate.TabIndex = 28;
            this.chkBoxSpinGate.Text = "&Spin gate";
            this.chkBoxSpinGate.UseVisualStyleBackColor = true;
            // 
            // lblReceivedParts
            // 
            this.lblReceivedParts.AutoSize = true;
            this.lblReceivedParts.Location = new System.Drawing.Point(853, 214);
            this.lblReceivedParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedParts.Name = "lblReceivedParts";
            this.lblReceivedParts.Size = new System.Drawing.Size(45, 17);
            this.lblReceivedParts.TabIndex = 27;
            this.lblReceivedParts.Text = "&Parts:";
            // 
            // nudGateDelay
            // 
            this.nudGateDelay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudGateDelay.Location = new System.Drawing.Point(27, 41);
            this.nudGateDelay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudGateDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudGateDelay.Name = "nudGateDelay";
            this.nudGateDelay.Size = new System.Drawing.Size(79, 22);
            this.nudGateDelay.TabIndex = 26;
            this.nudGateDelay.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lblGateDelay
            // 
            this.lblGateDelay.AutoSize = true;
            this.lblGateDelay.Location = new System.Drawing.Point(113, 43);
            this.lblGateDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGateDelay.Name = "lblGateDelay";
            this.lblGateDelay.Size = new System.Drawing.Size(76, 17);
            this.lblGateDelay.TabIndex = 25;
            this.lblGateDelay.Text = "&Delay (ms)";
            // 
            // lblSpinCost
            // 
            this.lblSpinCost.AutoSize = true;
            this.lblSpinCost.Location = new System.Drawing.Point(853, 97);
            this.lblSpinCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpinCost.Name = "lblSpinCost";
            this.lblSpinCost.Size = new System.Drawing.Size(70, 17);
            this.lblSpinCost.TabIndex = 24;
            this.lblSpinCost.Text = "&Spin cost:";
            // 
            // lblReceivedNanoHull
            // 
            this.lblReceivedNanoHull.AutoSize = true;
            this.lblReceivedNanoHull.Location = new System.Drawing.Point(853, 299);
            this.lblReceivedNanoHull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedNanoHull.Name = "lblReceivedNanoHull";
            this.lblReceivedNanoHull.Size = new System.Drawing.Size(72, 17);
            this.lblReceivedNanoHull.TabIndex = 23;
            this.lblReceivedNanoHull.Text = "&Nano hull:";
            // 
            // lblReceivedXenomit
            // 
            this.lblReceivedXenomit.AutoSize = true;
            this.lblReceivedXenomit.Location = new System.Drawing.Point(853, 271);
            this.lblReceivedXenomit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedXenomit.Name = "lblReceivedXenomit";
            this.lblReceivedXenomit.Size = new System.Drawing.Size(63, 17);
            this.lblReceivedXenomit.TabIndex = 22;
            this.lblReceivedXenomit.Text = "&Xenomit:";
            // 
            // lblReceivedRepairCredits
            // 
            this.lblReceivedRepairCredits.AutoSize = true;
            this.lblReceivedRepairCredits.Location = new System.Drawing.Point(853, 242);
            this.lblReceivedRepairCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedRepairCredits.Name = "lblReceivedRepairCredits";
            this.lblReceivedRepairCredits.Size = new System.Drawing.Size(100, 17);
            this.lblReceivedRepairCredits.TabIndex = 21;
            this.lblReceivedRepairCredits.Text = "&Repair credits:";
            // 
            // lblReceivedLogDisks
            // 
            this.lblReceivedLogDisks.AutoSize = true;
            this.lblReceivedLogDisks.Location = new System.Drawing.Point(853, 186);
            this.lblReceivedLogDisks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedLogDisks.Name = "lblReceivedLogDisks";
            this.lblReceivedLogDisks.Size = new System.Drawing.Size(72, 17);
            this.lblReceivedLogDisks.TabIndex = 20;
            this.lblReceivedLogDisks.Text = "&Log disks:";
            // 
            // lblReceivedACM
            // 
            this.lblReceivedACM.AutoSize = true;
            this.lblReceivedACM.Location = new System.Drawing.Point(679, 327);
            this.lblReceivedACM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedACM.Name = "lblReceivedACM";
            this.lblReceivedACM.Size = new System.Drawing.Size(41, 17);
            this.lblReceivedACM.TabIndex = 19;
            this.lblReceivedACM.Text = "&ACM:";
            // 
            // lblReceivedPLT2021
            // 
            this.lblReceivedPLT2021.AutoSize = true;
            this.lblReceivedPLT2021.Location = new System.Drawing.Point(679, 299);
            this.lblReceivedPLT2021.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedPLT2021.Name = "lblReceivedPLT2021";
            this.lblReceivedPLT2021.Size = new System.Drawing.Size(75, 17);
            this.lblReceivedPLT2021.TabIndex = 18;
            this.lblReceivedPLT2021.Text = "&PLT-2021:";
            // 
            // lblReceivedSAB
            // 
            this.lblReceivedSAB.AutoSize = true;
            this.lblReceivedSAB.Location = new System.Drawing.Point(679, 271);
            this.lblReceivedSAB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedSAB.Name = "lblReceivedSAB";
            this.lblReceivedSAB.Size = new System.Drawing.Size(39, 17);
            this.lblReceivedSAB.TabIndex = 17;
            this.lblReceivedSAB.Text = "&SAB:";
            // 
            // lblReceivedX4
            // 
            this.lblReceivedX4.AutoSize = true;
            this.lblReceivedX4.Location = new System.Drawing.Point(679, 242);
            this.lblReceivedX4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedX4.Name = "lblReceivedX4";
            this.lblReceivedX4.Size = new System.Drawing.Size(29, 17);
            this.lblReceivedX4.TabIndex = 16;
            this.lblReceivedX4.Text = "&X4:";
            // 
            // lblReceivedX3
            // 
            this.lblReceivedX3.AutoSize = true;
            this.lblReceivedX3.Location = new System.Drawing.Point(679, 214);
            this.lblReceivedX3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedX3.Name = "lblReceivedX3";
            this.lblReceivedX3.Size = new System.Drawing.Size(29, 17);
            this.lblReceivedX3.TabIndex = 15;
            this.lblReceivedX3.Text = "&X3:";
            // 
            // lblReceivedX2
            // 
            this.lblReceivedX2.AutoSize = true;
            this.lblReceivedX2.Location = new System.Drawing.Point(679, 186);
            this.lblReceivedX2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedX2.Name = "lblReceivedX2";
            this.lblReceivedX2.Size = new System.Drawing.Size(29, 17);
            this.lblReceivedX2.TabIndex = 14;
            this.lblReceivedX2.Text = "&X2:";
            // 
            // lblTotalSpins
            // 
            this.lblTotalSpins.AutoSize = true;
            this.lblTotalSpins.Location = new System.Drawing.Point(679, 158);
            this.lblTotalSpins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSpins.Name = "lblTotalSpins";
            this.lblTotalSpins.Size = new System.Drawing.Size(81, 17);
            this.lblTotalSpins.TabIndex = 13;
            this.lblTotalSpins.Text = "&Total spins:";
            // 
            // lblExtraEnergy
            // 
            this.lblExtraEnergy.AutoSize = true;
            this.lblExtraEnergy.Location = new System.Drawing.Point(679, 129);
            this.lblExtraEnergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtraEnergy.Name = "lblExtraEnergy";
            this.lblExtraEnergy.Size = new System.Drawing.Size(93, 17);
            this.lblExtraEnergy.TabIndex = 12;
            this.lblExtraEnergy.Text = "&Extra Energy:";
            // 
            // lblUridium
            // 
            this.lblUridium.AutoSize = true;
            this.lblUridium.Location = new System.Drawing.Point(679, 97);
            this.lblUridium.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUridium.Name = "lblUridium";
            this.lblUridium.Size = new System.Drawing.Size(60, 17);
            this.lblUridium.TabIndex = 11;
            this.lblUridium.Text = "&Uridium:";
            // 
            // dgvGates
            // 
            this.dgvGates.AllowUserToAddRows = false;
            this.dgvGates.AllowUserToDeleteRows = false;
            this.dgvGates.AllowUserToResizeColumns = false;
            this.dgvGates.AllowUserToResizeRows = false;
            this.dgvGates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGates.CausesValidation = false;
            this.dgvGates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnGateName,
            this.clmnGateParts,
            this.clmnGateReady,
            this.clmnGateOnMap});
            this.dgvGates.Location = new System.Drawing.Point(195, 12);
            this.dgvGates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGates.Name = "dgvGates";
            this.dgvGates.RowHeadersVisible = false;
            this.dgvGates.ShowCellErrors = false;
            this.dgvGates.ShowCellToolTips = false;
            this.dgvGates.ShowEditingIcon = false;
            this.dgvGates.ShowRowErrors = false;
            this.dgvGates.Size = new System.Drawing.Size(464, 346);
            this.dgvGates.TabIndex = 10;
            this.dgvGates.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // clmnGateName
            // 
            this.clmnGateName.HeaderText = "Name";
            this.clmnGateName.Name = "clmnGateName";
            this.clmnGateName.ReadOnly = true;
            this.clmnGateName.Width = 110;
            // 
            // clmnGateParts
            // 
            this.clmnGateParts.HeaderText = "Parts";
            this.clmnGateParts.Name = "clmnGateParts";
            this.clmnGateParts.ReadOnly = true;
            this.clmnGateParts.Width = 70;
            // 
            // clmnGateReady
            // 
            this.clmnGateReady.HeaderText = "Ready";
            this.clmnGateReady.Name = "clmnGateReady";
            this.clmnGateReady.ReadOnly = true;
            this.clmnGateReady.Width = 70;
            // 
            // clmnGateOnMap
            // 
            this.clmnGateOnMap.HeaderText = "On Map";
            this.clmnGateOnMap.Name = "clmnGateOnMap";
            this.clmnGateOnMap.ReadOnly = true;
            this.clmnGateOnMap.Width = 70;
            // 
            // cmdResetGateStats
            // 
            this.cmdResetGateStats.Location = new System.Drawing.Point(683, 354);
            this.cmdResetGateStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdResetGateStats.Name = "cmdResetGateStats";
            this.cmdResetGateStats.Size = new System.Drawing.Size(317, 28);
            this.cmdResetGateStats.TabIndex = 9;
            this.cmdResetGateStats.Text = "&Reset stats";
            this.cmdResetGateStats.UseVisualStyleBackColor = true;
            this.cmdResetGateStats.Click += new System.EventHandler(this.cmdResetGateStats_Click);
            // 
            // rbBuildKuiper
            // 
            this.rbBuildKuiper.AutoSize = true;
            this.rbBuildKuiper.Location = new System.Drawing.Point(27, 382);
            this.rbBuildKuiper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBuildKuiper.Name = "rbBuildKuiper";
            this.rbBuildKuiper.Size = new System.Drawing.Size(70, 21);
            this.rbBuildKuiper.TabIndex = 8;
            this.rbBuildKuiper.Text = "&Kuiper";
            this.rbBuildKuiper.UseVisualStyleBackColor = true;
            // 
            // rbBuildHades
            // 
            this.rbBuildHades.AutoSize = true;
            this.rbBuildHades.Location = new System.Drawing.Point(27, 353);
            this.rbBuildHades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBuildHades.Name = "rbBuildHades";
            this.rbBuildHades.Size = new System.Drawing.Size(70, 21);
            this.rbBuildHades.TabIndex = 7;
            this.rbBuildHades.Text = "&Hades";
            this.rbBuildHades.UseVisualStyleBackColor = true;
            // 
            // rbBuildKappa
            // 
            this.rbBuildKappa.AutoSize = true;
            this.rbBuildKappa.Location = new System.Drawing.Point(27, 297);
            this.rbBuildKappa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBuildKappa.Name = "rbBuildKappa";
            this.rbBuildKappa.Size = new System.Drawing.Size(70, 21);
            this.rbBuildKappa.TabIndex = 6;
            this.rbBuildKappa.Text = "&Kappa";
            this.rbBuildKappa.UseVisualStyleBackColor = true;
            // 
            // rbBuildLambda
            // 
            this.rbBuildLambda.AutoSize = true;
            this.rbBuildLambda.Location = new System.Drawing.Point(27, 325);
            this.rbBuildLambda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBuildLambda.Name = "rbBuildLambda";
            this.rbBuildLambda.Size = new System.Drawing.Size(80, 21);
            this.rbBuildLambda.TabIndex = 5;
            this.rbBuildLambda.Text = "&Lambda";
            this.rbBuildLambda.UseVisualStyleBackColor = true;
            // 
            // rbBuildZeta
            // 
            this.rbBuildZeta.AutoSize = true;
            this.rbBuildZeta.Location = new System.Drawing.Point(27, 268);
            this.rbBuildZeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBuildZeta.Name = "rbBuildZeta";
            this.rbBuildZeta.Size = new System.Drawing.Size(58, 21);
            this.rbBuildZeta.TabIndex = 4;
            this.rbBuildZeta.Text = "&Zeta";
            this.rbBuildZeta.UseVisualStyleBackColor = true;
            // 
            // rbBuildEpsilon
            // 
            this.rbBuildEpsilon.AutoSize = true;
            this.rbBuildEpsilon.Location = new System.Drawing.Point(27, 240);
            this.rbBuildEpsilon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBuildEpsilon.Name = "rbBuildEpsilon";
            this.rbBuildEpsilon.Size = new System.Drawing.Size(75, 21);
            this.rbBuildEpsilon.TabIndex = 3;
            this.rbBuildEpsilon.Text = "&Epsilon";
            this.rbBuildEpsilon.UseVisualStyleBackColor = true;
            // 
            // rbBuildDelta
            // 
            this.rbBuildDelta.AutoSize = true;
            this.rbBuildDelta.Location = new System.Drawing.Point(27, 212);
            this.rbBuildDelta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBuildDelta.Name = "rbBuildDelta";
            this.rbBuildDelta.Size = new System.Drawing.Size(62, 21);
            this.rbBuildDelta.TabIndex = 2;
            this.rbBuildDelta.Text = "&Delta";
            this.rbBuildDelta.UseVisualStyleBackColor = true;
            // 
            // rbBuildAlpha
            // 
            this.rbBuildAlpha.AutoSize = true;
            this.rbBuildAlpha.Checked = true;
            this.rbBuildAlpha.Location = new System.Drawing.Point(27, 127);
            this.rbBuildAlpha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBuildAlpha.Name = "rbBuildAlpha";
            this.rbBuildAlpha.Size = new System.Drawing.Size(65, 21);
            this.rbBuildAlpha.TabIndex = 0;
            this.rbBuildAlpha.TabStop = true;
            this.rbBuildAlpha.Text = "&Alpha";
            this.rbBuildAlpha.UseVisualStyleBackColor = true;
            // 
            // tabPageTechFactory
            // 
            this.tabPageTechFactory.Controls.Add(this.chkBoxBuildTechs);
            this.tabPageTechFactory.Controls.Add(this.dgvTechFactory);
            this.tabPageTechFactory.Location = new System.Drawing.Point(4, 25);
            this.tabPageTechFactory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageTechFactory.Name = "tabPageTechFactory";
            this.tabPageTechFactory.Size = new System.Drawing.Size(1025, 421);
            this.tabPageTechFactory.TabIndex = 2;
            this.tabPageTechFactory.Text = "Tech Factory";
            this.tabPageTechFactory.UseVisualStyleBackColor = true;
            // 
            // chkBoxBuildTechs
            // 
            this.chkBoxBuildTechs.AutoSize = true;
            this.chkBoxBuildTechs.Location = new System.Drawing.Point(27, 12);
            this.chkBoxBuildTechs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxBuildTechs.Name = "chkBoxBuildTechs";
            this.chkBoxBuildTechs.Size = new System.Drawing.Size(99, 21);
            this.chkBoxBuildTechs.TabIndex = 2;
            this.chkBoxBuildTechs.Text = "&Build techs";
            this.chkBoxBuildTechs.UseVisualStyleBackColor = true;
            // 
            // dgvTechFactory
            // 
            this.dgvTechFactory.AllowUserToAddRows = false;
            this.dgvTechFactory.AllowUserToDeleteRows = false;
            this.dgvTechFactory.AllowUserToResizeColumns = false;
            this.dgvTechFactory.AllowUserToResizeRows = false;
            this.dgvTechFactory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTechFactory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechFactory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTechName,
            this.clmnTechAmount,
            this.clmnTechBuilding,
            this.clmnTechTimeLeft,
            this.clmnTechBuild});
            this.dgvTechFactory.Location = new System.Drawing.Point(27, 41);
            this.dgvTechFactory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTechFactory.Name = "dgvTechFactory";
            this.dgvTechFactory.RowHeadersVisible = false;
            this.dgvTechFactory.ShowCellErrors = false;
            this.dgvTechFactory.ShowCellToolTips = false;
            this.dgvTechFactory.ShowEditingIcon = false;
            this.dgvTechFactory.ShowRowErrors = false;
            this.dgvTechFactory.Size = new System.Drawing.Size(636, 342);
            this.dgvTechFactory.TabIndex = 1;
            this.dgvTechFactory.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_CurrentCellDirtyStateChanged);
            this.dgvTechFactory.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // clmnTechName
            // 
            this.clmnTechName.HeaderText = "Tech";
            this.clmnTechName.Name = "clmnTechName";
            this.clmnTechName.ReadOnly = true;
            this.clmnTechName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnTechName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnTechName.Width = 120;
            // 
            // clmnTechAmount
            // 
            this.clmnTechAmount.HeaderText = "Amount";
            this.clmnTechAmount.Name = "clmnTechAmount";
            this.clmnTechAmount.ReadOnly = true;
            this.clmnTechAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnTechAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnTechAmount.Width = 70;
            // 
            // clmnTechBuilding
            // 
            this.clmnTechBuilding.HeaderText = "Building";
            this.clmnTechBuilding.Name = "clmnTechBuilding";
            this.clmnTechBuilding.ReadOnly = true;
            this.clmnTechBuilding.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnTechBuilding.Width = 80;
            // 
            // clmnTechTimeLeft
            // 
            this.clmnTechTimeLeft.HeaderText = "Time Left";
            this.clmnTechTimeLeft.Name = "clmnTechTimeLeft";
            this.clmnTechTimeLeft.ReadOnly = true;
            this.clmnTechTimeLeft.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnTechTimeLeft.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmnTechBuild
            // 
            this.clmnTechBuild.HeaderText = "Build";
            this.clmnTechBuild.Name = "clmnTechBuild";
            this.clmnTechBuild.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnTechBuild.Width = 70;
            // 
            // tabPageSkylab
            // 
            this.tabPageSkylab.Controls.Add(this.chkBoxUpgradeSkylab);
            this.tabPageSkylab.Controls.Add(this.dgvSkylab);
            this.tabPageSkylab.Location = new System.Drawing.Point(4, 25);
            this.tabPageSkylab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSkylab.Name = "tabPageSkylab";
            this.tabPageSkylab.Size = new System.Drawing.Size(1025, 421);
            this.tabPageSkylab.TabIndex = 3;
            this.tabPageSkylab.Text = "Skylab";
            this.tabPageSkylab.UseVisualStyleBackColor = true;
            // 
            // chkBoxUpgradeSkylab
            // 
            this.chkBoxUpgradeSkylab.AutoSize = true;
            this.chkBoxUpgradeSkylab.Location = new System.Drawing.Point(27, 12);
            this.chkBoxUpgradeSkylab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxUpgradeSkylab.Name = "chkBoxUpgradeSkylab";
            this.chkBoxUpgradeSkylab.Size = new System.Drawing.Size(129, 21);
            this.chkBoxUpgradeSkylab.TabIndex = 3;
            this.chkBoxUpgradeSkylab.Text = "&Upgrade skylab";
            this.chkBoxUpgradeSkylab.UseVisualStyleBackColor = true;
            // 
            // dgvSkylab
            // 
            this.dgvSkylab.AllowUserToAddRows = false;
            this.dgvSkylab.AllowUserToDeleteRows = false;
            this.dgvSkylab.AllowUserToResizeColumns = false;
            this.dgvSkylab.AllowUserToResizeRows = false;
            this.dgvSkylab.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSkylab.CausesValidation = false;
            this.dgvSkylab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkylab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnModuleName,
            this.clmnModuleLevel,
            this.clmnModuleUpgrading,
            this.clmnModuleTimeLeft,
            this.clmnModuleUpgrade});
            this.dgvSkylab.Location = new System.Drawing.Point(27, 41);
            this.dgvSkylab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSkylab.Name = "dgvSkylab";
            this.dgvSkylab.RowHeadersVisible = false;
            this.dgvSkylab.ShowCellErrors = false;
            this.dgvSkylab.ShowCellToolTips = false;
            this.dgvSkylab.ShowEditingIcon = false;
            this.dgvSkylab.ShowRowErrors = false;
            this.dgvSkylab.Size = new System.Drawing.Size(757, 342);
            this.dgvSkylab.TabIndex = 0;
            this.dgvSkylab.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // clmnModuleName
            // 
            this.clmnModuleName.HeaderText = "Module";
            this.clmnModuleName.Name = "clmnModuleName";
            this.clmnModuleName.ReadOnly = true;
            this.clmnModuleName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnModuleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnModuleName.Width = 200;
            // 
            // clmnModuleLevel
            // 
            this.clmnModuleLevel.HeaderText = "Level";
            this.clmnModuleLevel.Name = "clmnModuleLevel";
            this.clmnModuleLevel.ReadOnly = true;
            this.clmnModuleLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnModuleLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnModuleLevel.Width = 70;
            // 
            // clmnModuleUpgrading
            // 
            this.clmnModuleUpgrading.HeaderText = "Upgrading";
            this.clmnModuleUpgrading.Name = "clmnModuleUpgrading";
            this.clmnModuleUpgrading.ReadOnly = true;
            this.clmnModuleUpgrading.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnModuleUpgrading.Width = 80;
            // 
            // clmnModuleTimeLeft
            // 
            this.clmnModuleTimeLeft.HeaderText = "Time Left";
            this.clmnModuleTimeLeft.Name = "clmnModuleTimeLeft";
            this.clmnModuleTimeLeft.ReadOnly = true;
            this.clmnModuleTimeLeft.Width = 120;
            // 
            // clmnModuleUpgrade
            // 
            this.clmnModuleUpgrade.HeaderText = "Upgrade";
            this.clmnModuleUpgrade.Name = "clmnModuleUpgrade";
            this.clmnModuleUpgrade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnModuleUpgrade.Width = 70;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.rtbLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageLog.Size = new System.Drawing.Size(1025, 421);
            this.tabPageLog.TabIndex = 5;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(27, 12);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(756, 370);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(557, 15);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(100, 28);
            this.cmdStart.TabIndex = 1;
            this.cmdStart.Text = "&Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(665, 15);
            this.cmdStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(100, 28);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "&Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdOpenBackPage
            // 
            this.cmdOpenBackPage.Location = new System.Drawing.Point(773, 15);
            this.cmdOpenBackPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdOpenBackPage.Name = "cmdOpenBackPage";
            this.cmdOpenBackPage.Size = new System.Drawing.Size(129, 28);
            this.cmdOpenBackPage.TabIndex = 3;
            this.cmdOpenBackPage.Text = "&Open backpage";
            this.cmdOpenBackPage.UseVisualStyleBackColor = true;
            this.cmdOpenBackPage.Click += new System.EventHandler(this.cmdOpenBackPage_Click);
            // 
            // lblLastStatus
            // 
            this.lblLastStatus.AutoSize = true;
            this.lblLastStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastStatus.Location = new System.Drawing.Point(19, 18);
            this.lblLastStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastStatus.Name = "lblLastStatus";
            this.lblLastStatus.Size = new System.Drawing.Size(88, 18);
            this.lblLastStatus.TabIndex = 4;
            this.lblLastStatus.Text = "&Last status: ";
            // 
            // cmdSaveSettings
            // 
            this.cmdSaveSettings.Location = new System.Drawing.Point(911, 15);
            this.cmdSaveSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSaveSettings.Name = "cmdSaveSettings";
            this.cmdSaveSettings.Size = new System.Drawing.Size(135, 28);
            this.cmdSaveSettings.TabIndex = 5;
            this.cmdSaveSettings.Text = "&Save settings";
            this.cmdSaveSettings.UseVisualStyleBackColor = true;
            this.cmdSaveSettings.Click += new System.EventHandler(this.cmdSaveSettings_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 513);
            this.Controls.Add(this.cmdSaveSettings);
            this.Controls.Add(this.lblLastStatus);
            this.Controls.Add(this.cmdOpenBackPage);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.tcMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corvus - DarkOrbit Auto-Tool ";
            this.tcMain.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.gBoxUsernamePasswordLogin.ResumeLayout(false);
            this.gBoxUsernamePasswordLogin.PerformLayout();
            this.gBoxSessionIDLogin.ResumeLayout(false);
            this.gBoxSessionIDLogin.PerformLayout();
            this.tabPageGalaxyGates.ResumeLayout(false);
            this.tabPageGalaxyGates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumUridium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGateDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGates)).EndInit();
            this.tabPageTechFactory.ResumeLayout(false);
            this.tabPageTechFactory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechFactory)).EndInit();
            this.tabPageSkylab.ResumeLayout(false);
            this.tabPageSkylab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkylab)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.GroupBox gBoxUsernamePasswordLogin;
        private System.Windows.Forms.GroupBox gBoxSessionIDLogin;
        private System.Windows.Forms.TextBox txtSessionId;
        private System.Windows.Forms.Label lblSessionId;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.CheckBox chkBoxReconnect;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.RadioButton rbUsernamePasswordLogin;
        private System.Windows.Forms.RadioButton rbSessionIdLogin;
        private System.Windows.Forms.TabPage tabPageGalaxyGates;
        private System.Windows.Forms.TabPage tabPageTechFactory;
        private System.Windows.Forms.TabPage tabPageSkylab;
        private System.Windows.Forms.Label lblPortal;
        private System.Windows.Forms.ComboBox comboBoxLoginPortal;
        private System.Windows.Forms.DataGridView dgvSkylab;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.DataGridView dgvTechFactory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnModuleLevel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnModuleUpgrading;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnModuleTimeLeft;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnModuleUpgrade;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdOpenBackPage;
        private System.Windows.Forms.RadioButton rbBuildAlpha;
        private System.Windows.Forms.RadioButton rbBuildKuiper;
        private System.Windows.Forms.RadioButton rbBuildHades;
        private System.Windows.Forms.RadioButton rbBuildKappa;
        private System.Windows.Forms.RadioButton rbBuildLambda;
        private System.Windows.Forms.RadioButton rbBuildZeta;
        private System.Windows.Forms.RadioButton rbBuildEpsilon;
        private System.Windows.Forms.RadioButton rbBuildDelta;
        private System.Windows.Forms.Button cmdResetGateStats;
        private System.Windows.Forms.DataGridView dgvGates;
        private System.Windows.Forms.Label lblExtraEnergy;
        private System.Windows.Forms.Label lblUridium;
        private System.Windows.Forms.Label lblReceivedLogDisks;
        private System.Windows.Forms.Label lblReceivedACM;
        private System.Windows.Forms.Label lblReceivedPLT2021;
        private System.Windows.Forms.Label lblReceivedSAB;
        private System.Windows.Forms.Label lblReceivedX4;
        private System.Windows.Forms.Label lblReceivedX3;
        private System.Windows.Forms.Label lblReceivedX2;
        private System.Windows.Forms.Label lblTotalSpins;
        private System.Windows.Forms.Label lblSpinCost;
        private System.Windows.Forms.Label lblReceivedNanoHull;
        private System.Windows.Forms.Label lblReceivedXenomit;
        private System.Windows.Forms.Label lblReceivedRepairCredits;
        private System.Windows.Forms.NumericUpDown nudGateDelay;
        private System.Windows.Forms.Label lblGateDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnGateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnGateParts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnGateReady;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnGateOnMap;
        private System.Windows.Forms.Label lblReceivedParts;
        private System.Windows.Forms.CheckBox chkBoxSpinGate;
        private System.Windows.Forms.CheckBox chkBoxPlaceGate;
        private System.Windows.Forms.NumericUpDown nudMinimumUridium;
        private System.Windows.Forms.Label lblMinimumUridium;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTechName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTechAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnTechBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTechTimeLeft;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnTechBuild;
        private System.Windows.Forms.CheckBox chkBoxBuildTechs;
        private System.Windows.Forms.CheckBox chkBoxUpgradeSkylab;
        private System.Windows.Forms.RichTextBox rtbLog;
        private CheckBox chkBoxSaveUsernamePassword;
        private Label lblLastStatus;
        private Button cmdSaveSettings;
        private RadioButton rbBuildGamma;
        private RadioButton rbBuildBeta;
    }
}

