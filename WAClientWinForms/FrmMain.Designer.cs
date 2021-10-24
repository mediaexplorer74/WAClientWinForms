namespace WAClientWinForms
{
    partial class FrmMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGrabContacts = new System.Windows.Forms.Button();
            this.btnGrabGroupAndMembers = new System.Windows.Forms.Button();
            this.btnUnreadMessages = new System.Windows.Forms.Button();
            this.btnArchiveChat = new System.Windows.Forms.Button();
            this.btnDeleteChat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSelectFileAja = new System.Windows.Forms.CheckBox();
            this.txtFileDocument = new System.Windows.Forms.TextBox();
            this.btnChooseDocument = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtAmountOfMessages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSendMessageDgPicture = new System.Windows.Forms.CheckBox();
            this.txtFilePicture = new System.Windows.Forms.TextBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSendImageFromUrl = new System.Windows.Forms.CheckBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.chkGroup = new System.Windows.Forms.CheckBox();
            this.btnSelectGroup = new System.Windows.Forms.Button();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSendLocation = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSubscribe = new System.Windows.Forms.CheckBox();
            this.chkAutoReplay = new System.Windows.Forms.CheckBox();
            this.MessageLog = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chkMessageSentSubscribe = new System.Windows.Forms.CheckBox();
            this.lstMessageOut = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChooseFileStorageLocation = new System.Windows.Forms.Button();
            this.btnLocateWAAutomateNodejs = new System.Windows.Forms.Button();
            this.txtFileStorageLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocateWhatsAppNETAPINodeJs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblState, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 587);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnStart);
            this.flowLayoutPanel1.Controls.Add(this.btnStop);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Controls.Add(this.btnGrabContacts);
            this.flowLayoutPanel1.Controls.Add(this.btnGrabGroupAndMembers);
            this.flowLayoutPanel1.Controls.Add(this.btnUnreadMessages);
            this.flowLayoutPanel1.Controls.Add(this.btnArchiveChat);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteChat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(847, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(84, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(165, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGrabContacts
            // 
            this.btnGrabContacts.Enabled = false;
            this.btnGrabContacts.Location = new System.Drawing.Point(246, 3);
            this.btnGrabContacts.Name = "btnGrabContacts";
            this.btnGrabContacts.Size = new System.Drawing.Size(97, 23);
            this.btnGrabContacts.TabIndex = 3;
            this.btnGrabContacts.Text = "Contacts";
            this.btnGrabContacts.UseVisualStyleBackColor = true;
            this.btnGrabContacts.Click += new System.EventHandler(this.btnGrabContacts_Click);
            // 
            // btnGrabGroupAndMembers
            // 
            this.btnGrabGroupAndMembers.Enabled = false;
            this.btnGrabGroupAndMembers.Location = new System.Drawing.Point(349, 3);
            this.btnGrabGroupAndMembers.Name = "btnGrabGroupAndMembers";
            this.btnGrabGroupAndMembers.Size = new System.Drawing.Size(155, 23);
            this.btnGrabGroupAndMembers.TabIndex = 5;
            this.btnGrabGroupAndMembers.Text = "Group and members";
            this.btnGrabGroupAndMembers.UseVisualStyleBackColor = true;
            this.btnGrabGroupAndMembers.Click += new System.EventHandler(this.btnGrabGroupAndMembers_Click);
            // 
            // btnUnreadMessages
            // 
            this.btnUnreadMessages.Enabled = false;
            this.btnUnreadMessages.Location = new System.Drawing.Point(510, 3);
            this.btnUnreadMessages.Name = "btnUnreadMessages";
            this.btnUnreadMessages.Size = new System.Drawing.Size(116, 23);
            this.btnUnreadMessages.TabIndex = 4;
            this.btnUnreadMessages.Text = "Unread Messages";
            this.btnUnreadMessages.UseVisualStyleBackColor = true;
            this.btnUnreadMessages.Click += new System.EventHandler(this.btnUnreadMessages_Click);
            // 
            // btnArchiveChat
            // 
            this.btnArchiveChat.Enabled = false;
            this.btnArchiveChat.Location = new System.Drawing.Point(632, 3);
            this.btnArchiveChat.Name = "btnArchiveChat";
            this.btnArchiveChat.Size = new System.Drawing.Size(109, 23);
            this.btnArchiveChat.TabIndex = 4;
            this.btnArchiveChat.Text = "Archive Chat";
            this.btnArchiveChat.UseVisualStyleBackColor = true;
            this.btnArchiveChat.Click += new System.EventHandler(this.btnArchiveChat_Click);
            // 
            // btnDeleteChat
            // 
            this.btnDeleteChat.Enabled = false;
            this.btnDeleteChat.Location = new System.Drawing.Point(747, 3);
            this.btnDeleteChat.Name = "btnDeleteChat";
            this.btnDeleteChat.Size = new System.Drawing.Size(92, 23);
            this.btnDeleteChat.TabIndex = 4;
            this.btnDeleteChat.Text = "Delete Chat";
            this.btnDeleteChat.UseVisualStyleBackColor = true;
            this.btnDeleteChat.Click += new System.EventHandler(this.btnDeleteChat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " [ Send Message ] ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtMessage, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel6, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel8, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(841, 235);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 64);
            this.label3.TabIndex = 0;
            this.label3.Text = "Message";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.chkSelectFileAja);
            this.flowLayoutPanel5.Controls.Add(this.txtFileDocument);
            this.flowLayoutPanel5.Controls.Add(this.btnChooseDocument);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(56, 145);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(785, 28);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // chkSelectFileAja
            // 
            this.chkSelectFileAja.AutoSize = true;
            this.chkSelectFileAja.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkSelectFileAja.Location = new System.Drawing.Point(3, 3);
            this.chkSelectFileAja.Name = "chkSelectFileAja";
            this.chkSelectFileAja.Size = new System.Drawing.Size(119, 23);
            this.chkSelectFileAja.TabIndex = 0;
            this.chkSelectFileAja.Text = "Send the document";
            this.chkSelectFileAja.UseVisualStyleBackColor = true;
            this.chkSelectFileAja.CheckedChanged += new System.EventHandler(this.chkKirimFileAja_CheckedChanged);
            // 
            // txtFileDocument
            // 
            this.txtFileDocument.Location = new System.Drawing.Point(128, 3);
            this.txtFileDocument.Name = "txtFileDocument";
            this.txtFileDocument.ReadOnly = true;
            this.txtFileDocument.Size = new System.Drawing.Size(563, 20);
            this.txtFileDocument.TabIndex = 1;
            // 
            // btnChooseDocument
            // 
            this.btnChooseDocument.Enabled = false;
            this.btnChooseDocument.Location = new System.Drawing.Point(697, 3);
            this.btnChooseDocument.Name = "btnChooseDocument";
            this.btnChooseDocument.Size = new System.Drawing.Size(34, 23);
            this.btnChooseDocument.TabIndex = 2;
            this.btnChooseDocument.Text = "...";
            this.btnChooseDocument.UseVisualStyleBackColor = true;
            this.btnChooseDocument.Click += new System.EventHandler(this.btnCariDokumen_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(59, 28);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(779, 58);
            this.txtMessage.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnSend);
            this.flowLayoutPanel2.Controls.Add(this.txtAmountOfMessages);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(59, 204);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(779, 28);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(701, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // txtAmountOfMessages
            // 
            this.txtAmountOfMessages.Location = new System.Drawing.Point(670, 3);
            this.txtAmountOfMessages.Name = "txtAmountOfMessages";
            this.txtAmountOfMessages.Size = new System.Drawing.Size(25, 20);
            this.txtAmountOfMessages.TabIndex = 1;
            this.txtAmountOfMessages.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(502, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Broadcast (number of Messages)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.chkSendMessageDgPicture);
            this.flowLayoutPanel4.Controls.Add(this.txtFilePicture);
            this.flowLayoutPanel4.Controls.Add(this.btnChooseImage);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(56, 89);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(785, 28);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // chkSendMessageDgPicture
            // 
            this.chkSendMessageDgPicture.AutoSize = true;
            this.chkSendMessageDgPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkSendMessageDgPicture.Location = new System.Drawing.Point(3, 3);
            this.chkSendMessageDgPicture.Name = "chkSendMessageDgPicture";
            this.chkSendMessageDgPicture.Size = new System.Drawing.Size(171, 23);
            this.chkSendMessageDgPicture.TabIndex = 0;
            this.chkSendMessageDgPicture.Text = "Send a message with a picture";
            this.chkSendMessageDgPicture.UseVisualStyleBackColor = true;
            this.chkSendMessageDgPicture.CheckedChanged += new System.EventHandler(this.chkKirimPesanDgGambar_CheckedChanged);
            // 
            // txtFilePicture
            // 
            this.txtFilePicture.Location = new System.Drawing.Point(180, 3);
            this.txtFilePicture.Name = "txtFilePicture";
            this.txtFilePicture.ReadOnly = true;
            this.txtFilePicture.Size = new System.Drawing.Size(525, 20);
            this.txtFilePicture.TabIndex = 1;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Enabled = false;
            this.btnChooseImage.Location = new System.Drawing.Point(711, 3);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(34, 23);
            this.btnChooseImage.TabIndex = 2;
            this.btnChooseImage.Text = "...";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnCariGambar_Click);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.chkSendImageFromUrl);
            this.flowLayoutPanel6.Controls.Add(this.txtUrl);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(56, 117);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(785, 28);
            this.flowLayoutPanel6.TabIndex = 4;
            // 
            // chkSendImageFromUrl
            // 
            this.chkSendImageFromUrl.AutoSize = true;
            this.chkSendImageFromUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSendImageFromUrl.Location = new System.Drawing.Point(3, 3);
            this.chkSendImageFromUrl.Name = "chkSendImageFromUrl";
            this.chkSendImageFromUrl.Size = new System.Drawing.Size(169, 20);
            this.chkSendImageFromUrl.TabIndex = 0;
            this.chkSendImageFromUrl.Text = "Send message with image (url)";
            this.chkSendImageFromUrl.UseVisualStyleBackColor = true;
            this.chkSendImageFromUrl.CheckedChanged += new System.EventHandler(this.chkKirimGambarDariUrl_CheckedChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUrl.Location = new System.Drawing.Point(178, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(521, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://coding4ever.net/assets/images/avatar.png";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.txtContact);
            this.flowLayoutPanel7.Controls.Add(this.chkGroup);
            this.flowLayoutPanel7.Controls.Add(this.btnSelectGroup);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(56, 0);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(785, 25);
            this.flowLayoutPanel7.TabIndex = 5;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(3, 3);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(133, 20);
            this.txtContact.TabIndex = 0;
            // 
            // chkGroup
            // 
            this.chkGroup.AutoSize = true;
            this.chkGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkGroup.Enabled = false;
            this.chkGroup.Location = new System.Drawing.Point(142, 3);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Size = new System.Drawing.Size(55, 23);
            this.chkGroup.TabIndex = 1;
            this.chkGroup.Text = "Group";
            this.chkGroup.UseVisualStyleBackColor = true;
            this.chkGroup.CheckedChanged += new System.EventHandler(this.chkGroup_CheckedChanged);
            // 
            // btnSelectGroup
            // 
            this.btnSelectGroup.Enabled = false;
            this.btnSelectGroup.Location = new System.Drawing.Point(203, 3);
            this.btnSelectGroup.Name = "btnSelectGroup";
            this.btnSelectGroup.Size = new System.Drawing.Size(97, 23);
            this.btnSelectGroup.TabIndex = 2;
            this.btnSelectGroup.Text = "Select Group";
            this.btnSelectGroup.UseVisualStyleBackColor = true;
            this.btnSelectGroup.Click += new System.EventHandler(this.btnPilihGroup_Click);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.chkSendLocation);
            this.flowLayoutPanel8.Controls.Add(this.label6);
            this.flowLayoutPanel8.Controls.Add(this.txtLatitude);
            this.flowLayoutPanel8.Controls.Add(this.label7);
            this.flowLayoutPanel8.Controls.Add(this.txtLongitude);
            this.flowLayoutPanel8.Controls.Add(this.label8);
            this.flowLayoutPanel8.Controls.Add(this.txtDescription);
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(56, 173);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(785, 28);
            this.flowLayoutPanel8.TabIndex = 6;
            // 
            // chkSendLocation
            // 
            this.chkSendLocation.AutoSize = true;
            this.chkSendLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkSendLocation.Location = new System.Drawing.Point(3, 3);
            this.chkSendLocation.Name = "chkSendLocation";
            this.chkSendLocation.Size = new System.Drawing.Size(91, 20);
            this.chkSendLocation.TabIndex = 0;
            this.chkSendLocation.Text = "Send location";
            this.chkSendLocation.UseVisualStyleBackColor = true;
            this.chkSendLocation.CheckedChanged += new System.EventHandler(this.chkKirimLokasi_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(100, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Latitude";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Enabled = false;
            this.txtLatitude.Location = new System.Drawing.Point(151, 3);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(79, 20);
            this.txtLatitude.TabIndex = 2;
            this.txtLatitude.Text = "-7.759866";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(236, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Longitude";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Enabled = false;
            this.txtLongitude.Location = new System.Drawing.Point(296, 3);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(79, 20);
            this.txtLongitude.TabIndex = 2;
            this.txtLongitude.Text = "110.409012";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(381, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Description";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(447, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(233, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 374);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 185);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 159);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incoming messages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MessageLog, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(833, 153);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.chkSubscribe);
            this.flowLayoutPanel3.Controls.Add(this.chkAutoReplay);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(827, 20);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.AutoSize = true;
            this.chkSubscribe.Enabled = false;
            this.chkSubscribe.Location = new System.Drawing.Point(3, 3);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Size = new System.Drawing.Size(73, 17);
            this.chkSubscribe.TabIndex = 0;
            this.chkSubscribe.Text = "Subscribe";
            this.chkSubscribe.UseVisualStyleBackColor = true;
            this.chkSubscribe.CheckedChanged += new System.EventHandler(this.chkSubscribe_CheckedChanged);
            // 
            // chkAutoReplay
            // 
            this.chkAutoReplay.AutoSize = true;
            this.chkAutoReplay.Enabled = false;
            this.chkAutoReplay.Location = new System.Drawing.Point(82, 3);
            this.chkAutoReplay.Name = "chkAutoReplay";
            this.chkAutoReplay.Size = new System.Drawing.Size(84, 17);
            this.chkAutoReplay.TabIndex = 1;
            this.chkAutoReplay.Text = "Auto Replay";
            this.chkAutoReplay.UseVisualStyleBackColor = true;
            // 
            // MessageLog
            // 
            this.MessageLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLog.FormattingEnabled = true;
            this.MessageLog.Location = new System.Drawing.Point(3, 29);
            this.MessageLog.Name = "MessageLog";
            this.MessageLog.Size = new System.Drawing.Size(827, 121);
            this.MessageLog.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 159);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Outgouing message(s)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.chkMessageSentSubscribe, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lstMessageOut, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(833, 153);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // chkMessageSentSubscribe
            // 
            this.chkMessageSentSubscribe.AutoSize = true;
            this.chkMessageSentSubscribe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkMessageSentSubscribe.Enabled = false;
            this.chkMessageSentSubscribe.Location = new System.Drawing.Point(3, 3);
            this.chkMessageSentSubscribe.Name = "chkMessageSentSubscribe";
            this.chkMessageSentSubscribe.Size = new System.Drawing.Size(827, 20);
            this.chkMessageSentSubscribe.TabIndex = 0;
            this.chkMessageSentSubscribe.Text = "Subscribe";
            this.chkMessageSentSubscribe.UseVisualStyleBackColor = true;
            this.chkMessageSentSubscribe.CheckedChanged += new System.EventHandler(this.chkMessageSentSubscribe_CheckedChanged);
            // 
            // lstMessageOut
            // 
            this.lstMessageOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMessageOut.FormattingEnabled = true;
            this.lstMessageOut.Location = new System.Drawing.Point(3, 29);
            this.lstMessageOut.Name = "lstMessageOut";
            this.lstMessageOut.Size = new System.Drawing.Size(827, 121);
            this.lstMessageOut.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChooseFileStorageLocation);
            this.groupBox2.Controls.Add(this.btnLocateWAAutomateNodejs);
            this.groupBox2.Controls.Add(this.txtFileStorageLocation);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLocateWhatsAppNETAPINodeJs);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 69);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " [ Configuration ] ";
            // 
            // btnChooseFileStorageLocation
            // 
            this.btnChooseFileStorageLocation.Location = new System.Drawing.Point(723, 41);
            this.btnChooseFileStorageLocation.Name = "btnChooseFileStorageLocation";
            this.btnChooseFileStorageLocation.Size = new System.Drawing.Size(34, 23);
            this.btnChooseFileStorageLocation.TabIndex = 2;
            this.btnChooseFileStorageLocation.Text = "...";
            this.btnChooseFileStorageLocation.UseVisualStyleBackColor = true;
            this.btnChooseFileStorageLocation.Click += new System.EventHandler(this.btnLokasiPenyimpananFileAtauGambar_Click);
            // 
            // btnLocateWAAutomateNodejs
            // 
            this.btnLocateWAAutomateNodejs.Location = new System.Drawing.Point(723, 14);
            this.btnLocateWAAutomateNodejs.Name = "btnLocateWAAutomateNodejs";
            this.btnLocateWAAutomateNodejs.Size = new System.Drawing.Size(34, 23);
            this.btnLocateWAAutomateNodejs.TabIndex = 2;
            this.btnLocateWAAutomateNodejs.Text = "...";
            this.btnLocateWAAutomateNodejs.UseVisualStyleBackColor = true;
            this.btnLocateWAAutomateNodejs.Click += new System.EventHandler(this.btnLokasiWAAutomateNodejs_Click);
            // 
            // txtFileStorageLocation
            // 
            this.txtFileStorageLocation.Location = new System.Drawing.Point(269, 43);
            this.txtFileStorageLocation.Name = "txtFileStorageLocation";
            this.txtFileStorageLocation.ReadOnly = true;
            this.txtFileStorageLocation.Size = new System.Drawing.Size(448, 20);
            this.txtFileStorageLocation.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "File or image storage location (incoming message)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLocateWhatsAppNETAPINodeJs
            // 
            this.txtLocateWhatsAppNETAPINodeJs.Location = new System.Drawing.Point(269, 17);
            this.txtLocateWhatsAppNETAPINodeJs.Name = "txtLocateWhatsAppNETAPINodeJs";
            this.txtLocateWhatsAppNETAPINodeJs.ReadOnly = true;
            this.txtLocateWhatsAppNETAPINodeJs.Size = new System.Drawing.Size(448, 20);
            this.txtLocateWhatsAppNETAPINodeJs.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "WhatsApp NET API NodeJs folder (location)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblState.Location = new System.Drawing.Point(3, 562);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(847, 25);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo WhatsAppAPI untuk .NET Developer (C#)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtAmountOfMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox chkSubscribe;
        private System.Windows.Forms.CheckBox chkAutoReplay;
        private System.Windows.Forms.ListBox MessageLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.CheckBox chkSendMessageDgPicture;
        private System.Windows.Forms.TextBox txtFilePicture;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.CheckBox chkSelectFileAja;
        private System.Windows.Forms.TextBox txtFileDocument;
        private System.Windows.Forms.Button btnChooseDocument;
        private System.Windows.Forms.Button btnGrabContacts;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox chkMessageSentSubscribe;
        private System.Windows.Forms.ListBox lstMessageOut;
        private System.Windows.Forms.Button btnUnreadMessages;
        private System.Windows.Forms.Button btnArchiveChat;
        private System.Windows.Forms.Button btnDeleteChat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocateWhatsAppNETAPINodeJs;
        private System.Windows.Forms.Button btnLocateWAAutomateNodejs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChooseFileStorageLocation;
        private System.Windows.Forms.TextBox txtFileStorageLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGrabGroupAndMembers;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.CheckBox chkSendImageFromUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.CheckBox chkGroup;
        private System.Windows.Forms.Button btnSelectGroup;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.CheckBox chkSendLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

