namespace Car_Server
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.onlineUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSCBOnlineUsers = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driveModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.openControlInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.pathControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertUnitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showFuzzySetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.showVariablesCurvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knowledgeBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.inferenceTracerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuralNetworkEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessingUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goLiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.dBManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSStatusMSG = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerConsole = new System.Windows.Forms.Timer(this.components);
            this.TimerStatusBar = new System.Windows.Forms.Timer(this.components);
            this.MSMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSMain
            // 
            this.MSMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MSMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsToolStripMenuItem,
            this.controlInterfaceToolStripMenuItem,
            this.expertUnitToolStripMenuItem,
            this.expertUnitToolStripMenuItem1,
            this.neuralNetworkEditorToolStripMenuItem,
            this.imageProcessingUnitToolStripMenuItem,
            this.dBManagementToolStripMenuItem,
            this.webControlToolStripMenuItem,
            this.interfaceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MSMain.Size = new System.Drawing.Size(1008, 25);
            this.MSMain.TabIndex = 1;
            this.MSMain.Text = "menuStrip1";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.toolStripMenuItem7,
            this.onlineUsersToolStripMenuItem,
            this.toolStripMenuItem8,
            this.exitToolStripMenuItem});
            this.accountsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(151, 6);
            // 
            // onlineUsersToolStripMenuItem
            // 
            this.onlineUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSCBOnlineUsers});
            this.onlineUsersToolStripMenuItem.Name = "onlineUsersToolStripMenuItem";
            this.onlineUsersToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.onlineUsersToolStripMenuItem.Text = "Online Users";
            // 
            // TSCBOnlineUsers
            // 
            this.TSCBOnlineUsers.Name = "TSCBOnlineUsers";
            this.TSCBOnlineUsers.Size = new System.Drawing.Size(121, 23);
            this.TSCBOnlineUsers.Sorted = true;
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // controlInterfaceToolStripMenuItem
            // 
            this.controlInterfaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveModeToolStripMenuItem,
            this.toolStripMenuItem5,
            this.openControlInterfaceToolStripMenuItem,
            this.carStatusToolStripMenuItem,
            this.toolStripMenuItem10,
            this.pathControllerToolStripMenuItem});
            this.controlInterfaceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.controlInterfaceToolStripMenuItem.Name = "controlInterfaceToolStripMenuItem";
            this.controlInterfaceToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
            this.controlInterfaceToolStripMenuItem.Text = "Control Interface";
            // 
            // driveModeToolStripMenuItem
            // 
            this.driveModeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.driveModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoDriveToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.driveModeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.driveModeToolStripMenuItem.Name = "driveModeToolStripMenuItem";
            this.driveModeToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.driveModeToolStripMenuItem.Text = "Drive Mode";
            // 
            // autoDriveToolStripMenuItem
            // 
            this.autoDriveToolStripMenuItem.Name = "autoDriveToolStripMenuItem";
            this.autoDriveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.autoDriveToolStripMenuItem.Text = "Auto";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(214, 6);
            // 
            // openControlInterfaceToolStripMenuItem
            // 
            this.openControlInterfaceToolStripMenuItem.Name = "openControlInterfaceToolStripMenuItem";
            this.openControlInterfaceToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.openControlInterfaceToolStripMenuItem.Text = "Open Control Interface";
            this.openControlInterfaceToolStripMenuItem.Click += new System.EventHandler(this.openControlInterfaceToolStripMenuItem_Click);
            // 
            // carStatusToolStripMenuItem
            // 
            this.carStatusToolStripMenuItem.Name = "carStatusToolStripMenuItem";
            this.carStatusToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.carStatusToolStripMenuItem.Text = "Car Status";
            this.carStatusToolStripMenuItem.Click += new System.EventHandler(this.carStatusToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(214, 6);
            // 
            // pathControllerToolStripMenuItem
            // 
            this.pathControllerToolStripMenuItem.Name = "pathControllerToolStripMenuItem";
            this.pathControllerToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.pathControllerToolStripMenuItem.Text = "Path Controller";
            this.pathControllerToolStripMenuItem.Click += new System.EventHandler(this.pathControllerToolStripMenuItem_Click);
            // 
            // expertUnitToolStripMenuItem
            // 
            this.expertUnitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openChannelToolStripMenuItem,
            this.closeChannelToolStripMenuItem,
            this.toolStripMenuItem3,
            this.statusToolStripMenuItem});
            this.expertUnitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.expertUnitToolStripMenuItem.Name = "expertUnitToolStripMenuItem";
            this.expertUnitToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.expertUnitToolStripMenuItem.Text = "Transport Unit";
            // 
            // openChannelToolStripMenuItem
            // 
            this.openChannelToolStripMenuItem.Name = "openChannelToolStripMenuItem";
            this.openChannelToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openChannelToolStripMenuItem.Text = "Open Channel";
            this.openChannelToolStripMenuItem.Click += new System.EventHandler(this.openChannelToolStripMenuItem_Click);
            // 
            // closeChannelToolStripMenuItem
            // 
            this.closeChannelToolStripMenuItem.Name = "closeChannelToolStripMenuItem";
            this.closeChannelToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeChannelToolStripMenuItem.Text = "Close Channel";
            this.closeChannelToolStripMenuItem.Click += new System.EventHandler(this.closeChannelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(160, 6);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // expertUnitToolStripMenuItem1
            // 
            this.expertUnitToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showFuzzySetToolStripMenuItem,
            this.knowledgeBaseToolStripMenuItem,
            this.toolStripMenuItem4,
            this.inferenceTracerToolStripMenuItem,
            this.consoleToolStripMenuItem});
            this.expertUnitToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.expertUnitToolStripMenuItem1.Name = "expertUnitToolStripMenuItem1";
            this.expertUnitToolStripMenuItem1.Size = new System.Drawing.Size(89, 21);
            this.expertUnitToolStripMenuItem1.Text = "Expert Unit";
            // 
            // showFuzzySetToolStripMenuItem
            // 
            this.showFuzzySetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.toolStripMenuItem6,
            this.showVariablesCurvesToolStripMenuItem});
            this.showFuzzySetToolStripMenuItem.Name = "showFuzzySetToolStripMenuItem";
            this.showFuzzySetToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.showFuzzySetToolStripMenuItem.Text = "Fuzzy Set";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(231, 6);
            // 
            // showVariablesCurvesToolStripMenuItem
            // 
            this.showVariablesCurvesToolStripMenuItem.Name = "showVariablesCurvesToolStripMenuItem";
            this.showVariablesCurvesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.showVariablesCurvesToolStripMenuItem.Text = "Show Variables Visualizer";
            this.showVariablesCurvesToolStripMenuItem.Click += new System.EventHandler(this.showVariablesCurvesToolStripMenuItem_Click);
            // 
            // knowledgeBaseToolStripMenuItem
            // 
            this.knowledgeBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRuleToolStripMenuItem,
            this.deleteRuleToolStripMenuItem,
            this.modifyRuleToolStripMenuItem});
            this.knowledgeBaseToolStripMenuItem.Name = "knowledgeBaseToolStripMenuItem";
            this.knowledgeBaseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.knowledgeBaseToolStripMenuItem.Text = "Knowledge Base";
            // 
            // addRuleToolStripMenuItem
            // 
            this.addRuleToolStripMenuItem.Name = "addRuleToolStripMenuItem";
            this.addRuleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addRuleToolStripMenuItem.Text = "Add Rule";
            // 
            // deleteRuleToolStripMenuItem
            // 
            this.deleteRuleToolStripMenuItem.Name = "deleteRuleToolStripMenuItem";
            this.deleteRuleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.deleteRuleToolStripMenuItem.Text = "Delete Rule";
            // 
            // modifyRuleToolStripMenuItem
            // 
            this.modifyRuleToolStripMenuItem.Name = "modifyRuleToolStripMenuItem";
            this.modifyRuleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.modifyRuleToolStripMenuItem.Text = "Modify Rule";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 6);
            // 
            // inferenceTracerToolStripMenuItem
            // 
            this.inferenceTracerToolStripMenuItem.Name = "inferenceTracerToolStripMenuItem";
            this.inferenceTracerToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.inferenceTracerToolStripMenuItem.Text = "Inference Tracer";
            this.inferenceTracerToolStripMenuItem.Click += new System.EventHandler(this.inferenceTracerToolStripMenuItem_Click);
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.consoleToolStripMenuItem.Text = "Console Interface";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // neuralNetworkEditorToolStripMenuItem
            // 
            this.neuralNetworkEditorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.neuralNetworkEditorToolStripMenuItem.Name = "neuralNetworkEditorToolStripMenuItem";
            this.neuralNetworkEditorToolStripMenuItem.Size = new System.Drawing.Size(158, 21);
            this.neuralNetworkEditorToolStripMenuItem.Text = "Neural Network Editor";
            this.neuralNetworkEditorToolStripMenuItem.Click += new System.EventHandler(this.neuralNetworkEditorToolStripMenuItem_Click);
            // 
            // imageProcessingUnitToolStripMenuItem
            // 
            this.imageProcessingUnitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goLiveToolStripMenuItem,
            this.toolStripMenuItem9});
            this.imageProcessingUnitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.imageProcessingUnitToolStripMenuItem.Name = "imageProcessingUnitToolStripMenuItem";
            this.imageProcessingUnitToolStripMenuItem.Size = new System.Drawing.Size(158, 21);
            this.imageProcessingUnitToolStripMenuItem.Text = "Image Processing Unit";
            this.imageProcessingUnitToolStripMenuItem.Click += new System.EventHandler(this.imageProcessingUnitToolStripMenuItem_Click);
            // 
            // goLiveToolStripMenuItem
            // 
            this.goLiveToolStripMenuItem.Name = "goLiveToolStripMenuItem";
            this.goLiveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.goLiveToolStripMenuItem.Text = "Go Live";
            this.goLiveToolStripMenuItem.Click += new System.EventHandler(this.goLiveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(170, 6);
            // 
            // dBManagementToolStripMenuItem
            // 
            this.dBManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBControlToolStripMenuItem,
            this.dBSettingsToolStripMenuItem});
            this.dBManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dBManagementToolStripMenuItem.Name = "dBManagementToolStripMenuItem";
            this.dBManagementToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.dBManagementToolStripMenuItem.Text = "DB Manager";
            this.dBManagementToolStripMenuItem.Click += new System.EventHandler(this.dBManagementToolStripMenuItem_Click);
            // 
            // dBControlToolStripMenuItem
            // 
            this.dBControlToolStripMenuItem.Name = "dBControlToolStripMenuItem";
            this.dBControlToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dBControlToolStripMenuItem.Text = "DB Control";
            this.dBControlToolStripMenuItem.Click += new System.EventHandler(this.dBControlToolStripMenuItem_Click);
            // 
            // dBSettingsToolStripMenuItem
            // 
            this.dBSettingsToolStripMenuItem.Name = "dBSettingsToolStripMenuItem";
            this.dBSettingsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dBSettingsToolStripMenuItem.Text = "DB Settings";
            // 
            // webControlToolStripMenuItem
            // 
            this.webControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateToolStripMenuItem});
            this.webControlToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.webControlToolStripMenuItem.Name = "webControlToolStripMenuItem";
            this.webControlToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.webControlToolStripMenuItem.Text = "Web Control";
            // 
            // activateToolStripMenuItem
            // 
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            this.activateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.activateToolStripMenuItem.Text = "Activate";
            // 
            // interfaceToolStripMenuItem
            // 
            this.interfaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventLogToolStripMenuItem,
            this.editAccountsToolStripMenuItem});
            this.interfaceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.interfaceToolStripMenuItem.Name = "interfaceToolStripMenuItem";
            this.interfaceToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.interfaceToolStripMenuItem.Text = "Options";
            // 
            // eventLogToolStripMenuItem
            // 
            this.eventLogToolStripMenuItem.Name = "eventLogToolStripMenuItem";
            this.eventLogToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eventLogToolStripMenuItem.Text = "Event Log";
            this.eventLogToolStripMenuItem.Click += new System.EventHandler(this.eventLogToolStripMenuItem_Click);
            // 
            // editAccountsToolStripMenuItem
            // 
            this.editAccountsToolStripMenuItem.Name = "editAccountsToolStripMenuItem";
            this.editAccountsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editAccountsToolStripMenuItem.Text = "Edit Accounts";
            this.editAccountsToolStripMenuItem.Click += new System.EventHandler(this.editAccountsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.contentsToolStripMenuItem.Text = "Contents";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSStatusMSG});
            this.statusStrip1.Location = new System.Drawing.Point(0, 710);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSStatusMSG
            // 
            this.TSStatusMSG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSStatusMSG.Name = "TSStatusMSG";
            this.TSStatusMSG.Size = new System.Drawing.Size(114, 17);
            this.TSStatusMSG.Text = "Initilizing System ...";
            // 
            // TimerConsole
            // 
            this.TimerConsole.Interval = 1;
            this.TimerConsole.Tick += new System.EventHandler(this.TimerConsole_Tick);
            // 
            // TimerStatusBar
            // 
            this.TimerStatusBar.Interval = 2000;
            this.TimerStatusBar.Tick += new System.EventHandler(this.TimerStatusBar_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 732);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MSMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MSMain;
            this.MaximumSize = new System.Drawing.Size(1120, 768);
            this.MinimumSize = new System.Drawing.Size(1022, 766);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Server";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem expertUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertUnitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem interfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageProcessingUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driveModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showFuzzySetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem carStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knowledgeBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem inferenceTracerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem showVariablesCurvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripComboBox TSCBOnlineUsers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSStatusMSG;
        private System.Windows.Forms.ToolStripMenuItem openControlInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goLiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventLogToolStripMenuItem;
        private System.Windows.Forms.Timer TimerConsole;
        private System.Windows.Forms.ToolStripMenuItem dBControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountsToolStripMenuItem;
        private System.Windows.Forms.Timer TimerStatusBar;
        private System.Windows.Forms.ToolStripMenuItem neuralNetworkEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem pathControllerToolStripMenuItem;
    }
}

