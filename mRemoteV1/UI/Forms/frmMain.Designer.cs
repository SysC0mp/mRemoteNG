using mRemoteNG.UI.Controls;

namespace mRemoteNG.UI.Forms
{
    public partial class FrmMain : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.pnlDock = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.mMenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenView = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenTools = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenToolsSSHTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenToolsUVNCSC = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenToolsExternalApps = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenToolsPortScan = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenToolsSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mMenToolsComponentsCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenInfoHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenInfoSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mMenInfoWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenInfoDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenInfoForum = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenInfoBugReport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mMenToolsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenInfoSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mMenInfoAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblQuickConnect = new System.Windows.Forms.ToolStripLabel();
            this.cmbQuickConnect = new mRemoteNG.UI.Controls.QuickConnectComboBox();
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.tsExternalTools = new System.Windows.Forms.ToolStrip();
            this.cMenExtAppsToolbar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenToolbarShowText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuickConnect = new System.Windows.Forms.ToolStrip();
            this.btnQuickConnect = new mRemoteNG.UI.Controls.ToolStripSplitButton();
            this.mnuQuickConnectProtocol = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnConnections = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuConnections = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmrAutoSave = new System.Windows.Forms.Timer(this.components);
            this.msMain.SuspendLayout();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.cMenExtAppsToolbar.SuspendLayout();
            this.tsQuickConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDock
            // 
            this.pnlDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDock.DockBackColor = System.Drawing.SystemColors.Control;
            this.pnlDock.DockLeftPortion = 230D;
            this.pnlDock.DockRightPortion = 230D;
            this.pnlDock.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingSdi;
            this.pnlDock.Location = new System.Drawing.Point(0, 0);
            this.pnlDock.Name = "pnlDock";
            this.pnlDock.Size = new System.Drawing.Size(966, 449);
            this.pnlDock.TabIndex = 13;
            this.pnlDock.ActiveDocumentChanged += new System.EventHandler(this.pnlDock_ActiveDocumentChanged);
            // 
            // msMain
            // 
            this.msMain.Dock = System.Windows.Forms.DockStyle.None;
            this.msMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMenTools,
            this.mMenInfo});
            this.msMain.Location = new System.Drawing.Point(3, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(269, 24);
            this.msMain.Stretch = false;
            this.msMain.TabIndex = 16;
            this.msMain.Text = "Main Toolbar";
            
            // 
            // mMenTools
            // 
            this.mMenTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.credentialManagerToolStripMenuItem,
            this.mMenToolsSSHTransfer,
            this.mMenToolsUVNCSC,
            this.mMenToolsExternalApps,
            this.mMenToolsPortScan,
            this.mMenToolsSep1,
            this.mMenToolsComponentsCheck,
            this.mMenToolsOptions});
            this.mMenTools.Name = "mMenTools";
            this.mMenTools.Size = new System.Drawing.Size(48, 20);
            this.mMenTools.Text = "&Tools";
            // 
            // credentialManagerToolStripMenuItem
            // 
            this.credentialManagerToolStripMenuItem.Image = global::mRemoteNG.Resources.key;
            this.credentialManagerToolStripMenuItem.Name = "credentialManagerToolStripMenuItem";
            this.credentialManagerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.credentialManagerToolStripMenuItem.Text = "Credential Manager";
            this.credentialManagerToolStripMenuItem.Click += new System.EventHandler(this.credentialManagerToolStripMenuItem_Click);
            // 
            // mMenToolsSSHTransfer
            // 
            this.mMenToolsSSHTransfer.Image = global::mRemoteNG.Resources.SSHTransfer;
            this.mMenToolsSSHTransfer.Name = "mMenToolsSSHTransfer";
            this.mMenToolsSSHTransfer.Size = new System.Drawing.Size(184, 22);
            this.mMenToolsSSHTransfer.Text = "SSH File Transfer";
            this.mMenToolsSSHTransfer.Click += new System.EventHandler(this.mMenToolsSSHTransfer_Click);
            // 
            // mMenToolsUVNCSC
            // 
            this.mMenToolsUVNCSC.Image = global::mRemoteNG.Resources.UVNC_SC;
            this.mMenToolsUVNCSC.Name = "mMenToolsUVNCSC";
            this.mMenToolsUVNCSC.Size = new System.Drawing.Size(184, 22);
            this.mMenToolsUVNCSC.Text = "UltraVNC SingleClick";
            this.mMenToolsUVNCSC.Visible = false;
            this.mMenToolsUVNCSC.Click += new System.EventHandler(this.mMenToolsUVNCSC_Click);
            // 
            // mMenToolsExternalApps
            // 
            this.mMenToolsExternalApps.Image = global::mRemoteNG.Resources.ExtApp;
            this.mMenToolsExternalApps.Name = "mMenToolsExternalApps";
            this.mMenToolsExternalApps.Size = new System.Drawing.Size(184, 22);
            this.mMenToolsExternalApps.Text = "External Applications";
            this.mMenToolsExternalApps.Click += new System.EventHandler(this.mMenToolsExternalApps_Click);
            // 
            // mMenToolsPortScan
            // 
            this.mMenToolsPortScan.Image = global::mRemoteNG.Resources.PortScan;
            this.mMenToolsPortScan.Name = "mMenToolsPortScan";
            this.mMenToolsPortScan.Size = new System.Drawing.Size(184, 22);
            this.mMenToolsPortScan.Text = "Port Scan";
            this.mMenToolsPortScan.Click += new System.EventHandler(this.mMenToolsPortScan_Click);
            // 
            // mMenToolsSep1
            // 
            this.mMenToolsSep1.Name = "mMenToolsSep1";
            this.mMenToolsSep1.Size = new System.Drawing.Size(181, 6);
            // 
            // mMenToolsComponentsCheck
            // 
            this.mMenToolsComponentsCheck.Image = global::mRemoteNG.Resources.cog_error;
            this.mMenToolsComponentsCheck.Name = "mMenToolsComponentsCheck";
            this.mMenToolsComponentsCheck.Size = new System.Drawing.Size(184, 22);
            this.mMenToolsComponentsCheck.Text = "Components Check";
            this.mMenToolsComponentsCheck.Click += new System.EventHandler(this.mMenToolsComponentsCheck_Click);
            // 
            // mMenToolsOptions
            // 
            this.mMenToolsOptions.Image = global::mRemoteNG.Resources.Options;
            this.mMenToolsOptions.Name = "mMenToolsOptions";
            this.mMenToolsOptions.Size = new System.Drawing.Size(184, 22);
            this.mMenToolsOptions.Text = "Options";
            this.mMenToolsOptions.Click += new System.EventHandler(this.mMenToolsOptions_Click);
            // 
            // mMenInfo
            // 
            this.mMenInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMenInfoHelp,
            this.mMenInfoSep1,
            this.mMenInfoWebsite,
            this.mMenInfoDonate,
            this.mMenInfoForum,
            this.mMenInfoBugReport,
            this.ToolStripSeparator2,
            this.mMenToolsUpdate,
            this.mMenInfoSep2,
            this.mMenInfoAbout});
            this.mMenInfo.Name = "mMenInfo";
            this.mMenInfo.Size = new System.Drawing.Size(44, 20);
            this.mMenInfo.Text = "&Help";
            this.mMenInfo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // mMenInfoHelp
            // 
            this.mMenInfoHelp.Image = global::mRemoteNG.Resources.Help;
            this.mMenInfoHelp.Name = "mMenInfoHelp";
            this.mMenInfoHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mMenInfoHelp.Size = new System.Drawing.Size(190, 22);
            this.mMenInfoHelp.Text = "mRemoteNG Help";
            this.mMenInfoHelp.Click += new System.EventHandler(this.mMenInfoHelp_Click);
            // 
            // mMenInfoSep1
            // 
            this.mMenInfoSep1.Name = "mMenInfoSep1";
            this.mMenInfoSep1.Size = new System.Drawing.Size(187, 6);
            // 
            // mMenInfoWebsite
            // 
            this.mMenInfoWebsite.Image = global::mRemoteNG.Resources.Website;
            this.mMenInfoWebsite.Name = "mMenInfoWebsite";
            this.mMenInfoWebsite.Size = new System.Drawing.Size(190, 22);
            this.mMenInfoWebsite.Text = "Website";
            this.mMenInfoWebsite.Click += new System.EventHandler(this.mMenInfoWebsite_Click);
            // 
            // mMenInfoDonate
            // 
            this.mMenInfoDonate.Image = global::mRemoteNG.Resources.Donate;
            this.mMenInfoDonate.Name = "mMenInfoDonate";
            this.mMenInfoDonate.Size = new System.Drawing.Size(190, 22);
            this.mMenInfoDonate.Text = "Donate";
            this.mMenInfoDonate.Click += new System.EventHandler(this.mMenInfoDonate_Click);
            // 
            // mMenInfoForum
            // 
            this.mMenInfoForum.Image = global::mRemoteNG.Resources.user_comment;
            this.mMenInfoForum.Name = "mMenInfoForum";
            this.mMenInfoForum.Size = new System.Drawing.Size(190, 22);
            this.mMenInfoForum.Text = "Support Forum";
            this.mMenInfoForum.Click += new System.EventHandler(this.mMenInfoForum_Click);
            // 
            // mMenInfoBugReport
            // 
            this.mMenInfoBugReport.Image = global::mRemoteNG.Resources.Bug;
            this.mMenInfoBugReport.Name = "mMenInfoBugReport";
            this.mMenInfoBugReport.Size = new System.Drawing.Size(190, 22);
            this.mMenInfoBugReport.Text = "Report a Bug";
            this.mMenInfoBugReport.Click += new System.EventHandler(this.mMenInfoBugReport_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // mMenToolsUpdate
            // 
            this.mMenToolsUpdate.Image = global::mRemoteNG.Resources.Update;
            this.mMenToolsUpdate.Name = "mMenToolsUpdate";
            this.mMenToolsUpdate.Size = new System.Drawing.Size(190, 22);
            this.mMenToolsUpdate.Text = "Check for Updates";
            this.mMenToolsUpdate.Click += new System.EventHandler(this.mMenToolsUpdate_Click);
            // 
            // mMenInfoSep2
            // 
            this.mMenInfoSep2.Name = "mMenInfoSep2";
            this.mMenInfoSep2.Size = new System.Drawing.Size(187, 6);
            // 
            // mMenInfoAbout
            // 
            this.mMenInfoAbout.Image = global::mRemoteNG.Resources.mRemote;
            this.mMenInfoAbout.Name = "mMenInfoAbout";
            this.mMenInfoAbout.Size = new System.Drawing.Size(190, 22);
            this.mMenInfoAbout.Text = "About mRemoteNG";
            this.mMenInfoAbout.Click += new System.EventHandler(this.mMenInfoAbout_Click);
            // 
            // mMenSep3
            // 
            this.mMenSep3.Name = "mMenSep3";
            this.mMenSep3.Size = new System.Drawing.Size(211, 6);
            // 
            // lblQuickConnect
            // 
            this.lblQuickConnect.Name = "lblQuickConnect";
            this.lblQuickConnect.Size = new System.Drawing.Size(55, 22);
            this.lblQuickConnect.Text = "&Connect:";
            this.lblQuickConnect.Click += new System.EventHandler(this.lblQuickConnect_Click);
            // 
            // cmbQuickConnect
            // 
            this.cmbQuickConnect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbQuickConnect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbQuickConnect.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.cmbQuickConnect.Name = "cmbQuickConnect";
            this.cmbQuickConnect.Size = new System.Drawing.Size(200, 25);
            this.cmbQuickConnect.ConnectRequested += new mRemoteNG.UI.Controls.QuickConnectComboBox.ConnectRequestedEventHandler(this.cmbQuickConnect_ConnectRequested);
            this.cmbQuickConnect.ProtocolChanged += new mRemoteNG.UI.Controls.QuickConnectComboBox.ProtocolChangedEventHandler(this.cmbQuickConnect_ProtocolChanged);
            // 
            // tsContainer
            // 
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Controls.Add(this.pnlDock);
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(966, 449);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(966, 523);
            this.tsContainer.TabIndex = 17;
            this.tsContainer.Text = "ToolStripContainer1";
            // 
            // tsContainer.TopToolStripPanel
            // 
            this.tsContainer.TopToolStripPanel.Controls.Add(this.msMain);
            this.tsContainer.TopToolStripPanel.Controls.Add(this.tsQuickConnect);
            this.tsContainer.TopToolStripPanel.Controls.Add(this.tsExternalTools);
            // 
            // tsExternalTools
            // 
            this.tsExternalTools.ContextMenuStrip = this.cMenExtAppsToolbar;
            this.tsExternalTools.Dock = System.Windows.Forms.DockStyle.None;
            this.tsExternalTools.Location = new System.Drawing.Point(39, 49);
            this.tsExternalTools.MaximumSize = new System.Drawing.Size(0, 25);
            this.tsExternalTools.Name = "tsExternalTools";
            this.tsExternalTools.Size = new System.Drawing.Size(111, 25);
            this.tsExternalTools.TabIndex = 17;
            // 
            // cMenExtAppsToolbar
            // 
            this.cMenExtAppsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenToolbarShowText});
            this.cMenExtAppsToolbar.Name = "cMenToolbar";
            this.cMenExtAppsToolbar.Size = new System.Drawing.Size(129, 26);
            // 
            // cMenToolbarShowText
            // 
            this.cMenToolbarShowText.Checked = true;
            this.cMenToolbarShowText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cMenToolbarShowText.Name = "cMenToolbarShowText";
            this.cMenToolbarShowText.Size = new System.Drawing.Size(128, 22);
            this.cMenToolbarShowText.Text = "Show Text";
            this.cMenToolbarShowText.Click += new System.EventHandler(this.cMenToolbarShowText_Click);
            // 
            // tsQuickConnect
            // 
            this.tsQuickConnect.Dock = System.Windows.Forms.DockStyle.None;
            this.tsQuickConnect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblQuickConnect,
            this.cmbQuickConnect,
            this.btnQuickConnect,
            this.btnConnections});
            this.tsQuickConnect.Location = new System.Drawing.Point(3, 24);
            this.tsQuickConnect.MaximumSize = new System.Drawing.Size(0, 25);
            this.tsQuickConnect.Name = "tsQuickConnect";
            this.tsQuickConnect.Size = new System.Drawing.Size(387, 25);
            this.tsQuickConnect.TabIndex = 18;
            // 
            // btnQuickConnect
            // 
            this.btnQuickConnect.DropDown = this.mnuQuickConnectProtocol;
            this.btnQuickConnect.Image = global::mRemoteNG.Resources.Play_Quick;
            this.btnQuickConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuickConnect.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.btnQuickConnect.Name = "btnQuickConnect";
            this.btnQuickConnect.Size = new System.Drawing.Size(84, 22);
            this.btnQuickConnect.Text = "Connect";
            this.btnQuickConnect.ButtonClick += new System.EventHandler(this.btnQuickConnect_ButtonClick);
            this.btnQuickConnect.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnQuickConnect_DropDownItemClicked);
            // 
            // mnuQuickConnectProtocol
            // 
            this.mnuQuickConnectProtocol.Name = "mnuQuickConnectProtocol";
            this.mnuQuickConnectProtocol.OwnerItem = this.btnQuickConnect;
            this.mnuQuickConnectProtocol.ShowCheckMargin = true;
            this.mnuQuickConnectProtocol.ShowImageMargin = false;
            this.mnuQuickConnectProtocol.Size = new System.Drawing.Size(61, 4);
            // 
            // btnConnections
            // 
            this.btnConnections.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnections.DropDown = this.mnuConnections;
            this.btnConnections.Image = global::mRemoteNG.Resources.Root;
            this.btnConnections.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConnections.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnections.Name = "btnConnections";
            this.btnConnections.Size = new System.Drawing.Size(29, 22);
            this.btnConnections.Text = "Connections";
            this.btnConnections.DropDownOpening += new System.EventHandler(this.btnConnections_DropDownOpening);
            // 
            // mnuConnections
            // 
            this.mnuConnections.Name = "mnuConnections";
            this.mnuConnections.OwnerItem = this.btnConnections;
            this.mnuConnections.Size = new System.Drawing.Size(61, 4);
            // 
            // tmrAutoSave
            // 
            this.tmrAutoSave.Interval = 10000;
            this.tmrAutoSave.Tick += new System.EventHandler(this.tmrAutoSave_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 523);
            this.Controls.Add(this.tsContainer);
            this.Icon = global::mRemoteNG.Resources.mRemote_Icon;
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmMain";
            this.Opacity = 0D;
            this.Text = "mRemoteNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResizeBegin += new System.EventHandler(this.frmMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsContainer.ContentPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            this.cMenExtAppsToolbar.ResumeLayout(false);
            this.tsQuickConnect.ResumeLayout(false);
            this.tsQuickConnect.PerformLayout();
            this.ResumeLayout(false);

		}
		internal WeifenLuo.WinFormsUI.Docking.DockPanel pnlDock;
		internal System.Windows.Forms.MenuStrip msMain;
		internal System.Windows.Forms.ToolStripMenuItem mMenFile;
		internal System.Windows.Forms.ToolStripMenuItem mMenView;
		internal System.Windows.Forms.ToolStripMenuItem mMenTools;
		internal System.Windows.Forms.ToolStripLabel lblQuickConnect;
		internal System.Windows.Forms.ToolStripMenuItem mMenInfo;
		internal System.Windows.Forms.ToolStripSeparator mMenToolsSep1;
		internal System.Windows.Forms.ToolStripMenuItem mMenToolsOptions;
		internal System.Windows.Forms.ToolStripMenuItem mMenInfoHelp;
		internal System.Windows.Forms.ToolStripMenuItem mMenInfoWebsite;
		internal System.Windows.Forms.ToolStripSeparator mMenInfoSep1;
		internal System.Windows.Forms.ToolStripMenuItem mMenInfoAbout;
        internal QuickConnectComboBox cmbQuickConnect;
        internal System.Windows.Forms.ToolStripMenuItem mMenToolsSSHTransfer;
		internal System.Windows.Forms.ToolStripContainer tsContainer;
		internal System.Windows.Forms.ToolStripMenuItem mMenToolsExternalApps;
		internal System.Windows.Forms.Timer tmrAutoSave;
		internal System.Windows.Forms.ToolStrip tsExternalTools;
		internal System.Windows.Forms.ContextMenuStrip cMenExtAppsToolbar;
		internal System.Windows.Forms.ToolStripMenuItem cMenToolbarShowText;
		internal System.Windows.Forms.ToolStripMenuItem mMenToolsPortScan;
		internal System.Windows.Forms.ToolStrip tsQuickConnect;
		internal System.Windows.Forms.ToolStripSeparator mMenSep3;
		internal System.Windows.Forms.ToolStripMenuItem mMenInfoDonate;
		internal ToolStripSplitButton btnQuickConnect;
		internal System.Windows.Forms.ToolStripMenuItem mMenToolsUVNCSC;
		internal System.Windows.Forms.ToolStripMenuItem mMenToolsComponentsCheck;
		internal System.Windows.Forms.ToolStripSeparator mMenInfoSep2;
		internal System.Windows.Forms.ToolStripMenuItem mMenInfoBugReport;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.ToolStripMenuItem mMenInfoForum;
		internal System.Windows.Forms.ToolStripMenuItem mMenToolsUpdate;
		internal System.Windows.Forms.ContextMenuStrip mnuQuickConnectProtocol;
		internal System.Windows.Forms.ToolStripDropDownButton btnConnections;
		internal System.Windows.Forms.ContextMenuStrip mnuConnections;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem credentialManagerToolStripMenuItem;
    }
}
