using System;

namespace OurChat {
    partial class OCForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCForm));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripLeftPanel = new System.Windows.Forms.ToolStrip();
            this.cmdPortrait = new System.Windows.Forms.ToolStripButton();
            this.cmdChatUI = new System.Windows.Forms.ToolStripButton();
            this.cmdSettings = new System.Windows.Forms.ToolStripButton();
            this.cmdContacts = new System.Windows.Forms.ToolStripButton();
            this.cmdNull = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelChatArea = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerChat = new System.Windows.Forms.SplitContainer();
            this.tableLayoutInputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cmdSend = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanelSysmenu = new System.Windows.Forms.FlowLayoutPanel();
            this.sysCmdClose = new System.Windows.Forms.Button();
            this.sysCmdMaximize = new System.Windows.Forms.Button();
            this.sysCmdMinimize = new System.Windows.Forms.Button();
            this.sysCmdPin = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanelConversation = new System.Windows.Forms.TableLayoutPanel();
            this.lvConversations = new System.Windows.Forms.ListView();
            this.imgContainer16x16 = new System.Windows.Forms.ImageList(this.components);
            this.imgContainer32x32 = new System.Windows.Forms.ImageList(this.components);
            this.imgContainer64x64 = new System.Windows.Forms.ImageList(this.components);
            this.imgContainer48x48 = new System.Windows.Forms.ImageList(this.components);
            this.rtxInput = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.toolStripLeftPanel.SuspendLayout();
            this.tableLayoutPanelChatArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChat)).BeginInit();
            this.splitContainerChat.Panel2.SuspendLayout();
            this.splitContainerChat.SuspendLayout();
            this.tableLayoutInputPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelSysmenu.SuspendLayout();
            this.tableLayoutPanelConversation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.toolStripLeftPanel, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelChatArea, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelConversation, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(734, 657);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // toolStripLeftPanel
            // 
            this.toolStripLeftPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStripLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripLeftPanel.GripMargin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.toolStripLeftPanel.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripLeftPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdPortrait,
            this.cmdChatUI,
            this.cmdSettings,
            this.cmdContacts,
            this.cmdNull});
            this.toolStripLeftPanel.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.toolStripLeftPanel.Name = "toolStripLeftPanel";
            this.toolStripLeftPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.toolStripLeftPanel.Size = new System.Drawing.Size(75, 657);
            this.toolStripLeftPanel.TabIndex = 0;
            this.toolStripLeftPanel.Text = "toolStrip1";
            // 
            // cmdPortrait
            // 
            this.cmdPortrait.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPortrait.Image = ((System.Drawing.Image)(resources.GetObject("cmdPortrait.Image")));
            this.cmdPortrait.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPortrait.Margin = new System.Windows.Forms.Padding(0, 1, 0, 20);
            this.cmdPortrait.Name = "cmdPortrait";
            this.cmdPortrait.Size = new System.Drawing.Size(74, 52);
            this.cmdPortrait.Text = "toolStripButton1";
            this.cmdPortrait.ToolTipText = "你自己";
            // 
            // cmdChatUI
            // 
            this.cmdChatUI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdChatUI.Image = ((System.Drawing.Image)(resources.GetObject("cmdChatUI.Image")));
            this.cmdChatUI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdChatUI.Margin = new System.Windows.Forms.Padding(0, 1, 0, 20);
            this.cmdChatUI.Name = "cmdChatUI";
            this.cmdChatUI.Size = new System.Drawing.Size(74, 52);
            this.cmdChatUI.Text = "当前会话";
            // 
            // cmdSettings
            // 
            this.cmdSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSettings.Image = ((System.Drawing.Image)(resources.GetObject("cmdSettings.Image")));
            this.cmdSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(74, 52);
            this.cmdSettings.Text = "设置";
            // 
            // cmdContacts
            // 
            this.cmdContacts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdContacts.Image = ((System.Drawing.Image)(resources.GetObject("cmdContacts.Image")));
            this.cmdContacts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdContacts.Margin = new System.Windows.Forms.Padding(0, 1, 0, 20);
            this.cmdContacts.Name = "cmdContacts";
            this.cmdContacts.Size = new System.Drawing.Size(74, 52);
            this.cmdContacts.Text = "熟知的联系人";
            // 
            // cmdNull
            // 
            this.cmdNull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdNull.Image = ((System.Drawing.Image)(resources.GetObject("cmdNull.Image")));
            this.cmdNull.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNull.Name = "cmdNull";
            this.cmdNull.Size = new System.Drawing.Size(74, 52);
            this.cmdNull.Text = "占位";
            this.cmdNull.Visible = false;
            // 
            // tableLayoutPanelChatArea
            // 
            this.tableLayoutPanelChatArea.ColumnCount = 1;
            this.tableLayoutPanelChatArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChatArea.Controls.Add(this.splitContainerChat, 0, 2);
            this.tableLayoutPanelChatArea.Controls.Add(this.flowLayoutPanelSysmenu, 0, 0);
            this.tableLayoutPanelChatArea.Controls.Add(this.lblInfo, 0, 1);
            this.tableLayoutPanelChatArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChatArea.Location = new System.Drawing.Point(377, 4);
            this.tableLayoutPanelChatArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelChatArea.Name = "tableLayoutPanelChatArea";
            this.tableLayoutPanelChatArea.RowCount = 3;
            this.tableLayoutPanelChatArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanelChatArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelChatArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChatArea.Size = new System.Drawing.Size(354, 649);
            this.tableLayoutPanelChatArea.TabIndex = 2;
            // 
            // splitContainerChat
            // 
            this.splitContainerChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerChat.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerChat.Location = new System.Drawing.Point(3, 61);
            this.splitContainerChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerChat.Name = "splitContainerChat";
            this.splitContainerChat.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerChat.Panel1
            // 
            this.splitContainerChat.Panel1.BackColor = System.Drawing.Color.White;
            // 
            // splitContainerChat.Panel2
            // 
            this.splitContainerChat.Panel2.Controls.Add(this.tableLayoutInputPanel);
            this.splitContainerChat.Panel2MinSize = 128;
            this.splitContainerChat.Size = new System.Drawing.Size(348, 584);
            this.splitContainerChat.SplitterDistance = 455;
            this.splitContainerChat.SplitterWidth = 1;
            this.splitContainerChat.TabIndex = 0;
            // 
            // tableLayoutInputPanel
            // 
            this.tableLayoutInputPanel.ColumnCount = 1;
            this.tableLayoutInputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutInputPanel.Controls.Add(this.cmdSend, 0, 2);
            this.tableLayoutInputPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutInputPanel.Controls.Add(this.rtxInput, 0, 1);
            this.tableLayoutInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutInputPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutInputPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutInputPanel.Name = "tableLayoutInputPanel";
            this.tableLayoutInputPanel.RowCount = 3;
            this.tableLayoutInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutInputPanel.Size = new System.Drawing.Size(346, 126);
            this.tableLayoutInputPanel.TabIndex = 0;
            // 
            // cmdSend
            // 
            this.cmdSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.cmdSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSend.Location = new System.Drawing.Point(274, 98);
            this.cmdSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(69, 24);
            this.cmdSend.TabIndex = 0;
            this.cmdSend.Text = "发送(&S)";
            this.cmdSend.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(346, 32);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = ":)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "F";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelSysmenu
            // 
            this.flowLayoutPanelSysmenu.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelSysmenu.Controls.Add(this.sysCmdClose);
            this.flowLayoutPanelSysmenu.Controls.Add(this.sysCmdMaximize);
            this.flowLayoutPanelSysmenu.Controls.Add(this.sysCmdMinimize);
            this.flowLayoutPanelSysmenu.Controls.Add(this.sysCmdPin);
            this.flowLayoutPanelSysmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSysmenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelSysmenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSysmenu.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelSysmenu.Name = "flowLayoutPanelSysmenu";
            this.flowLayoutPanelSysmenu.Size = new System.Drawing.Size(354, 23);
            this.flowLayoutPanelSysmenu.TabIndex = 1;
            // 
            // sysCmdClose
            // 
            this.sysCmdClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sysCmdClose.FlatAppearance.BorderSize = 0;
            this.sysCmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sysCmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sysCmdClose.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysCmdClose.Location = new System.Drawing.Point(335, 0);
            this.sysCmdClose.Margin = new System.Windows.Forms.Padding(0);
            this.sysCmdClose.Name = "sysCmdClose";
            this.sysCmdClose.Size = new System.Drawing.Size(19, 23);
            this.sysCmdClose.TabIndex = 0;
            this.sysCmdClose.Text = "X";
            this.sysCmdClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sysCmdClose.UseVisualStyleBackColor = true;
            // 
            // sysCmdMaximize
            // 
            this.sysCmdMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sysCmdMaximize.FlatAppearance.BorderSize = 0;
            this.sysCmdMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sysCmdMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sysCmdMaximize.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysCmdMaximize.Location = new System.Drawing.Point(316, 0);
            this.sysCmdMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.sysCmdMaximize.Name = "sysCmdMaximize";
            this.sysCmdMaximize.Size = new System.Drawing.Size(19, 23);
            this.sysCmdMaximize.TabIndex = 1;
            this.sysCmdMaximize.Text = "*";
            this.sysCmdMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sysCmdMaximize.UseVisualStyleBackColor = true;
            // 
            // sysCmdMinimize
            // 
            this.sysCmdMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sysCmdMinimize.FlatAppearance.BorderSize = 0;
            this.sysCmdMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sysCmdMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sysCmdMinimize.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysCmdMinimize.Location = new System.Drawing.Point(297, 0);
            this.sysCmdMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.sysCmdMinimize.Name = "sysCmdMinimize";
            this.sysCmdMinimize.Size = new System.Drawing.Size(19, 23);
            this.sysCmdMinimize.TabIndex = 2;
            this.sysCmdMinimize.Text = "-";
            this.sysCmdMinimize.UseVisualStyleBackColor = true;
            // 
            // sysCmdPin
            // 
            this.sysCmdPin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sysCmdPin.FlatAppearance.BorderSize = 0;
            this.sysCmdPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.sysCmdPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sysCmdPin.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysCmdPin.Location = new System.Drawing.Point(278, 0);
            this.sysCmdPin.Margin = new System.Windows.Forms.Padding(0);
            this.sysCmdPin.Name = "sysCmdPin";
            this.sysCmdPin.Size = new System.Drawing.Size(19, 23);
            this.sysCmdPin.TabIndex = 3;
            this.sysCmdPin.Text = "`";
            this.sysCmdPin.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.Location = new System.Drawing.Point(3, 23);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(348, 34);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelConversation
            // 
            this.tableLayoutPanelConversation.ColumnCount = 1;
            this.tableLayoutPanelConversation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelConversation.Controls.Add(this.lvConversations, 0, 1);
            this.tableLayoutPanelConversation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelConversation.Location = new System.Drawing.Point(75, 4);
            this.tableLayoutPanelConversation.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tableLayoutPanelConversation.Name = "tableLayoutPanelConversation";
            this.tableLayoutPanelConversation.RowCount = 2;
            this.tableLayoutPanelConversation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanelConversation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelConversation.Size = new System.Drawing.Size(299, 653);
            this.tableLayoutPanelConversation.TabIndex = 3;
            // 
            // lvConversations
            // 
            this.lvConversations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvConversations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvConversations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConversations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvConversations.Location = new System.Drawing.Point(0, 57);
            this.lvConversations.Margin = new System.Windows.Forms.Padding(0);
            this.lvConversations.MultiSelect = false;
            this.lvConversations.Name = "lvConversations";
            this.lvConversations.OwnerDraw = true;
            this.lvConversations.Size = new System.Drawing.Size(299, 596);
            this.lvConversations.TabIndex = 0;
            this.lvConversations.TileSize = new System.Drawing.Size(220, 48);
            this.lvConversations.UseCompatibleStateImageBehavior = false;
            this.lvConversations.View = System.Windows.Forms.View.Tile;
            // 
            // imgContainer16x16
            // 
            this.imgContainer16x16.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgContainer16x16.ImageSize = new System.Drawing.Size(16, 16);
            this.imgContainer16x16.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgContainer32x32
            // 
            this.imgContainer32x32.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgContainer32x32.ImageSize = new System.Drawing.Size(32, 32);
            this.imgContainer32x32.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgContainer64x64
            // 
            this.imgContainer64x64.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgContainer64x64.ImageSize = new System.Drawing.Size(64, 64);
            this.imgContainer64x64.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgContainer48x48
            // 
            this.imgContainer48x48.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgContainer48x48.ImageSize = new System.Drawing.Size(48, 48);
            this.imgContainer48x48.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // rtxInput
            // 
            this.rtxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxInput.EnableAutoDragDrop = true;
            this.rtxInput.Location = new System.Drawing.Point(0, 32);
            this.rtxInput.Margin = new System.Windows.Forms.Padding(0);
            this.rtxInput.Name = "rtxInput";
            this.rtxInput.Size = new System.Drawing.Size(346, 62);
            this.rtxInput.TabIndex = 2;
            this.rtxInput.Text = "";
            // 
            // OCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 657);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OCForm";
            this.Text = "雅言";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.toolStripLeftPanel.ResumeLayout(false);
            this.toolStripLeftPanel.PerformLayout();
            this.tableLayoutPanelChatArea.ResumeLayout(false);
            this.tableLayoutPanelChatArea.PerformLayout();
            this.splitContainerChat.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChat)).EndInit();
            this.splitContainerChat.ResumeLayout(false);
            this.tableLayoutInputPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanelSysmenu.ResumeLayout(false);
            this.tableLayoutPanelConversation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.ToolStrip toolStripLeftPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChatArea;
        private System.Windows.Forms.SplitContainer splitContainerChat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConversation;
        private System.Windows.Forms.ListView lvConversations;
        private System.Windows.Forms.ToolStripButton cmdPortrait;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSysmenu;
        private System.Windows.Forms.Button sysCmdClose;
        private System.Windows.Forms.Button sysCmdMaximize;
        private System.Windows.Forms.Button sysCmdMinimize;
        private System.Windows.Forms.Button sysCmdPin;
        private System.Windows.Forms.ImageList imgContainer16x16;
        private System.Windows.Forms.ImageList imgContainer32x32;
        private System.Windows.Forms.ImageList imgContainer64x64;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInputPanel;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.ToolStripButton cmdChatUI;
        private System.Windows.Forms.ToolStripButton cmdNull;
        private System.Windows.Forms.ToolStripButton cmdSettings;
        private System.Windows.Forms.ImageList imgContainer48x48;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStripButton cmdContacts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtxInput;
    }
}

