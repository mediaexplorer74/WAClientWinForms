using System;
using System.Collections.Generic;
using System.Windows.Forms;

using WhatsAppNETAPI;
//using ConceptCave.WaitCursor;
using System.IO;

// 
namespace WAClientWinForms
{
    // FrmMain
    public partial class FrmMain : Form
    {
        private IWhatsAppNETAPI _wa; // WA object
        private Group _selectedGroup; // Selected group


        // constructor
        public FrmMain()
        {
            InitializeComponent();

            // initialize WA
            _wa = new WhatsAppNETAPI.WhatsAppNETAPI();

        }//FrmMain


        // btnStart_Click
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocateWhatsAppNETAPINodeJs.Text))
            {
                MessageBox.Show("Sorry, 'WhatsApp NET API NodeJs' folder location was not found.", 
                    "Houston, we have a problem",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                txtLocateWhatsAppNETAPINodeJs.Focus();
                return;
            }

            _wa.WaNetApiNodeJsPath = txtLocateWhatsAppNETAPINodeJs.Text;

            // TODO: enable this code to be able to send files in video format
            // _wa.ChromePath = "C:/Program Files (x86)/Google/Chrome/Application/chrome.exe";

            //check WA Api NodeJs path...
            if (!_wa.IsWaNetApiNodeJsPathExists)
            {
                MessageBox.Show("Sorry, 'WhatsApp NET API NodeJs' folder location was not found.", 
                    "Warning: WA API not found", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                txtLocateWhatsAppNETAPINodeJs.Focus();
                return;
            }

            // try to connect...
            Connect();

        }//btnStart_Click


        // btnStop_Click
        private void btnStop_Click(object sender, EventArgs e)
        {
            Disconnect();
        }//btnStop_Click


        //  btnLogout_Click
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var msg = "This function will DELETE the connection session to Whatsapp Web.\n" +
                      "So you have to re-scan the qrcode.\n\n" +
                      "Do you want to continue?";

            if 
            (
                MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes
            )
            {
                Disconnect(true);
            }

        }//btnLogout_Click


        // Connect
        private void Connect()
        {
            this.UseWaitCursor = true;

            _wa.ImageAndDocumentPath = txtFileStorageLocation.Text;

            // subscribe event
            _wa.OnStartup += OnStartupHandler;
            _wa.OnChangeState += OnChangeStateHandler;
            _wa.OnReceiveMessages += OnReceiveMessagesHandler;
            _wa.OnClientConnected += OnClientConnectedHandler;
            
            _wa.Connect();

            using (var frm = new FrmStartUp())
            {
                // subscribe event
                _wa.OnStartup += frm.OnStartupHandler;
                _wa.OnScanMe += frm.OnScanMeHandler;

                frm.UseWaitCursor = true;
                frm.ShowDialog();

                // unsubscribe event
                _wa.OnStartup -= frm.OnStartupHandler;
                _wa.OnScanMe -= frm.OnScanMeHandler;
            }
        }//


        // Disconnect
        private void Disconnect(bool isLogout = false)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnLogout.Enabled = false;
            btnGrabContacts.Enabled = false;
            btnGrabGroupAndMembers.Enabled = false;
            btnUnreadMessages.Enabled = false;
            btnArchiveChat.Enabled = false;
            btnDeleteChat.Enabled = false;
            btnSend.Enabled = false;

            chkGroup.Checked = false;
            chkGroup.Enabled = false;

            txtFileDocument.Clear();
            txtFilePicture.Clear();

            chkSubscribe.Checked = false;
            chkSubscribe.Enabled = false;

            chkMessageSentSubscribe.Checked = false;
            chkMessageSentSubscribe.Enabled = false;

            chkAutoReplay.Checked = false;
            chkAutoReplay.Enabled = false;

            MessageLog.Items.Clear();

            //using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            //{

            // unsubscribe event
            _wa.OnStartup -= OnStartupHandler;
            _wa.OnChangeState -= OnChangeStateHandler;
            _wa.OnScanMe -= OnScanMeHandler;
            _wa.OnReceiveMessage -= OnReceiveMessageHandler;
            _wa.OnReceiveMessages -= OnReceiveMessagesHandler;
            _wa.OnReceiveMessageStatus -= OnReceiveMessageStatusHandler;
            _wa.OnClientConnected -= OnClientConnectedHandler;

            // check if not logout yet...
            if (isLogout)
            {
                _wa.Logout();
            }
            else
            {
                _wa.Disconnect();
            }
            
            //}

        }//Disconnect



        // btnKirim_Click (Send)
        private void btnKirim_Click(object sender, EventArgs e)
        {
            var jumlahPesan = int.Parse(txtAmountOfMessages.Text);

            if (jumlahPesan > 1) // broadcast
            {
                var list = new List<MsgArgs>();

                var contact = string.Empty;

                if (chkGroup.Checked)
                {
                    if (_selectedGroup != null)
                        contact = _selectedGroup.id;
                    else
                        MessageBox.Show("Sorry, the group has not been selected", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    contact = txtContact.Text;

                for (int i = 0; i < jumlahPesan; i++)
                {
                    MsgArgs msgArgs = null;

                    if (chkSendMessageDgPicture.Checked)
                        msgArgs = new MsgArgs(contact, txtMessage.Text, MsgArgsType.Image, txtFilePicture.Text);
                    else if (chkSendImageFromUrl.Checked)
                        msgArgs = new MsgArgs(contact, txtMessage.Text, MsgArgsType.Url, txtUrl.Text);
                    else if (chkSelectFileAja.Checked)
                        msgArgs = new MsgArgs(contact, txtMessage.Text, MsgArgsType.File, txtFileDocument.Text);
                    else if (chkSendLocation.Checked)
                    {
                        var location = new Location
                        {
                            latitude = txtLatitude.Text,
                            longitude = txtLongitude.Text,
                            description = txtDescription.Text
                        };

                        msgArgs = new MsgArgs(contact, location);
                    }
                    else
                        msgArgs = new MsgArgs(contact, txtMessage.Text, MsgArgsType.Text);

                    list.Add(msgArgs);
                }

                _wa.BroadcastMessage(list);
            }
            else
            {
                MsgArgs msgArgs = null;

                var contact = string.Empty;

                if (chkGroup.Checked)
                {
                    if (_selectedGroup != null)
                        contact = _selectedGroup.id;
                    else
                        MessageBox.Show("Sorry, the group has not been selected", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    contact = txtContact.Text;

                if (chkSendMessageDgPicture.Checked)
                {
                    msgArgs = new MsgArgs(contact, txtMessage.Text, MsgArgsType.Image, txtFilePicture.Text);
                }
                else if (chkSendImageFromUrl.Checked)
                {
                    msgArgs = new MsgArgs(contact, txtMessage.Text, MsgArgsType.Url, txtUrl.Text);
                }
                else if (chkSelectFileAja.Checked)
                {
                    msgArgs = new MsgArgs(contact, txtMessage.Text, MsgArgsType.File, txtFileDocument.Text);
                }
                else if (chkSendLocation.Checked)
                {
                    var location = new Location
                    {
                        latitude = txtLatitude.Text,
                        longitude = txtLongitude.Text,
                        description = txtDescription.Text
                    };

                    msgArgs = new MsgArgs(contact, location);
                }
                else
                {
                    msgArgs = new MsgArgs(contact, txtMessage.Text, MsgArgsType.Text);
                }
                
                _wa.SendMessage(msgArgs);
            }

        }//btnKirim_Click


        // chkSubscribe_CheckedChanged
        private void chkSubscribe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubscribe.Checked)
            {
                _wa.OnReceiveMessage += OnReceiveMessageHandler; // subscribe event
            }
            else
            {
                _wa.OnReceiveMessage -= OnReceiveMessageHandler; // unsubscribe event

                MessageLog.Items.Clear();
            }

            chkAutoReplay.Enabled = chkSubscribe.Checked;

        }//chkSubscribe_CheckedChanged


        // btnCariGambar_Click (Choose Picture)
        private void btnCariGambar_Click(object sender, EventArgs e)
        {
            var fileName = ShowDialogOpen("Image file location", true);
            
            if (!string.IsNullOrEmpty(fileName)) txtFilePicture.Text = fileName;
        }//btnCariGambar_Click


        // btnCariDokumen_Click (Choose Document)
        private void btnCariDokumen_Click(object sender, EventArgs e)
        {
            var fileName = ShowDialogOpen("Document file location");
            
            if (!string.IsNullOrEmpty(fileName)) txtFileDocument.Text = fileName;

        }//btnCariDokumen_Click


        // ShowDialogOpen
        private string ShowDialogOpen(string title, bool fileImageOnly = false)
        {
            var fileName = string.Empty;

            using (var dlgOpen = new OpenFileDialog())
            {
                dlgOpen.Filter = fileImageOnly ? "Image File (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png"
                                               : "Document File (*.*)|*.*";
                dlgOpen.Title = title;

                var result = dlgOpen.ShowDialog();
                if (result == DialogResult.OK) fileName = dlgOpen.FileName;
            }

            return fileName;

        }//ShowDialogOpen


        // ShowDialogOpenFolder 
        private string ShowDialogOpenFolder()
        {
            var folderName = string.Empty;

            using (var dlgOpen = new FolderBrowserDialog())
            {
                var result = dlgOpen.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dlgOpen.SelectedPath))
                {
                    folderName = dlgOpen.SelectedPath;
                }
            }

            return folderName;

        }//ShowDialogOpenFolder


        // chkKirimPesanDgGambar_CheckedChanged
        private void chkKirimPesanDgGambar_CheckedChanged(object sender, EventArgs e)
        {
            btnChooseImage.Enabled = chkSendMessageDgPicture.Checked;
            if (chkSendMessageDgPicture.Checked)
            {
                chkSelectFileAja.Checked = false;
                chkSendImageFromUrl.Checked = false;
                chkSendLocation.Checked = false;
                txtFileDocument.Clear();

                txtLatitude.Enabled = false;
                txtLongitude.Enabled = false;
                txtDescription.Enabled = false;
            }
            else
            {
                txtFilePicture.Clear();
            }

        }//chkKirimPesanDgGambar_CheckedChanged


        // chkKirimGambarDariUrl_CheckedChanged
        private void chkKirimGambarDariUrl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSendImageFromUrl.Checked)
            {
                chkSendMessageDgPicture.Checked = false;
                chkSelectFileAja.Checked = false;
                chkSendLocation.Checked = false;
                txtFilePicture.Clear();
                txtFileDocument.Clear();

                txtLatitude.Enabled = false;
                txtLongitude.Enabled = false;
                txtDescription.Enabled = false;
            }

        }//chkKirimGambarDariUrl_CheckedChanged


        // chkKirimFileAja_CheckedChanged
        private void chkKirimFileAja_CheckedChanged(object sender, EventArgs e)
        {
            btnChooseDocument.Enabled = chkSelectFileAja.Checked;

            if (chkSelectFileAja.Checked)
            {
                chkSendMessageDgPicture.Checked = false;
                chkSendImageFromUrl.Checked = false;
                chkSendLocation.Checked = false;
                txtFilePicture.Clear();

                txtLatitude.Enabled = false;
                txtLongitude.Enabled = false;
                txtDescription.Enabled = false;
            }
            else
            {
                txtFileDocument.Clear();
            }

        }//chkKirimFileAja_CheckedChanged


        // chkKirimLokasi_CheckedChanged
        private void chkKirimLokasi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSendLocation.Checked)
            {
                chkSendMessageDgPicture.Checked = false;
                chkSendImageFromUrl.Checked = false;
                chkSelectFileAja.Checked = false;
                
                txtFilePicture.Clear();
                txtFileDocument.Clear();

                txtLatitude.Enabled = true;
                txtLongitude.Enabled = true;
                txtDescription.Enabled = true;
            }

        }//chkKirimLokasi_CheckedChanged


        // btnGrabContacts_Click
        private void btnGrabContacts_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmContactOrGroup("Contacts"))
            {                
                _wa.OnReceiveContacts += frm.OnReceiveContactsHandler; // subscribe event
                _wa.GetContacts();

                frm.ShowDialog();
                _wa.OnReceiveContacts -= frm.OnReceiveContactsHandler; // unsubscribe event
            }

        }//btnGrabContacts_Click


        // btnGrabGroupAndMembers_Click
        private void btnGrabGroupAndMembers_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmContactOrGroup("Groups and Members"))
            {
                _wa.OnReceiveGroups += frm.OnReceiveGroupsHandler; // subscribe event
                _wa.GetGroups();

                frm.ShowDialog();
                _wa.OnReceiveGroups -= frm.OnReceiveGroupsHandler; // unsubscribe event
            }
        }//btnGrabGroupAndMembers_Click



        // chkMessageSentSubscribe_CheckedChanged
        private void chkMessageSentSubscribe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMessageSentSubscribe.Checked)
            {
                _wa.OnReceiveMessageStatus += OnReceiveMessageStatusHandler; // subscribe event
            }
            else
            {
                _wa.OnReceiveMessageStatus -= OnReceiveMessageStatusHandler; // unsubscribe event
                lstMessageOut.Items.Clear();
            }

        }//chkMessageSentSubscribe_CheckedChanged


        // btnDeleteChat_Click
        private void btnDeleteChat_Click(object sender, EventArgs e)
        {
            var msg = "This function will DELETE all messages.\n" +
                      "Do you want to continue?";

            if (MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _wa.DeleteChat();
            }
        }//btnDeleteChat_Click

        // btnArchiveChat_Click
        private void btnArchiveChat_Click(object sender, EventArgs e)
        {
            var msg = "This function will DELETE all messages.\n" +
                      "Do you want to continue?";

            if (MessageBox.Show(msg, "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _wa.ArchiveChat();
            }
        }//btnArchiveChat_Click


        // btnUnreadMessages_Click
        private void btnUnreadMessages_Click(object sender, EventArgs e)
        {
            _wa.GetUnreadMessage();

        }//btnUnreadMessages_Click



        # region event handler


        // OnStartupHandler
        private void OnStartupHandler(string message, string sessionId)
        {
            // koneksi ke WA berhasil
            if (message.IndexOf("Ready") >= 0)
            {
                btnStart.Invoke(new MethodInvoker(() => btnStart.Enabled = false));

                btnStop.Invoke(new MethodInvoker(() => btnStop.Enabled = true));
                btnLogout.Invoke(new MethodInvoker(() => btnLogout.Enabled = true));

                btnGrabContacts.Invoke(new MethodInvoker(() => btnGrabContacts.Enabled = true));
                btnGrabGroupAndMembers.Invoke(new MethodInvoker(() => btnGrabGroupAndMembers.Enabled = true));

                btnUnreadMessages.Invoke(new MethodInvoker(() => btnUnreadMessages.Enabled = true));
                btnArchiveChat.Invoke(new MethodInvoker(() => btnArchiveChat.Enabled = true));
                btnDeleteChat.Invoke(new MethodInvoker(() => btnDeleteChat.Enabled = true));

                chkGroup.Invoke(new MethodInvoker(() => chkGroup.Enabled = true));
                btnSend.Invoke(new MethodInvoker(() => btnSend.Enabled = true));
                chkSubscribe.Invoke(new MethodInvoker(() => chkSubscribe.Enabled = true));
                chkMessageSentSubscribe.Invoke(new MethodInvoker(() => chkMessageSentSubscribe.Enabled = true));                

                this.UseWaitCursor = false;
            }

            // koneksi ke WA GAGAL, bisa dicoba lagi
            if (message.IndexOf("Failure") >= 0 || message.IndexOf("Timeout") >= 0
                || message.IndexOf("ERR_NAME") >= 0)
            {
                // unsubscribe event
                _wa.OnStartup -= OnStartupHandler;
                _wa.OnScanMe -= OnScanMeHandler;
                _wa.OnReceiveMessage -= OnReceiveMessageHandler;
                _wa.OnReceiveMessages -= OnReceiveMessagesHandler;
                _wa.OnReceiveMessageStatus -= OnReceiveMessageStatusHandler;
                _wa.OnClientConnected -= OnClientConnectedHandler;

                _wa.Disconnect();

                this.UseWaitCursor = false;

                var msg = string.Format("{0}\n\nConnection to WA failed, please check your internet connection", 
                    message);
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }//OnStartupHandler


        // OnChangeStateHandler 
        private void OnChangeStateHandler(WhatsAppNETAPI.WAState state, string sessionId)
        {
            lblState.Invoke(new MethodInvoker(() => lblState.Text = string.Format("State: {0}", state.ToString())));
        }//OnChangeStateHandler


        // OnScanMeHandler
        private void OnScanMeHandler(string qrcodePath, string sessionId)
        {
            // future
        }//OnScanMeHandler


        // OnReceiveMessageHandler
        private void OnReceiveMessageHandler(WhatsAppNETAPI.Message message, string sessionId)
        {
            var msg = message.content;

            var msender = string.Empty;
            var group = string.Empty;

            var isGroup = message.group != null;

            if (isGroup) // message from group
            {
                group = string.IsNullOrEmpty(message.group.name) ? message.from : message.group.name;

                var sender = message.group.sender;
                msender = string.IsNullOrEmpty(sender.name) ? message.from : sender.name;
            }
            else
                msender = string.IsNullOrEmpty(message.sender.name) ? message.from : message.sender.name;

            var fileName = message.filename;

            var data = string.Empty;

            if (isGroup)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    data = string.Format
                    (
                        "[{0}] Group: {1}, Text Message: {2}, Sender: {3}",
                        message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), group, msg, msender
                    );
                }
                else
                {
                    data = string.Format
                    (
                        "[{0}] Group: {1}, Picture/Document message: {2}, Sender: {3}, File Name: {4}",
                        message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), group, msg, msender, fileName
                    );
                }
            }
            else
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    data = string.Format("[{0}] Sender: {1}, Text Message: {2}",
                        message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), msender, msg);
                }
                else
                {
                    data = string.Format("[{0}] Sender: {1}, Picture/Document message: {2}, File Name: {3}",
                        message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), msender, msg, fileName);
                }
            }

            // UI update from different thread
            MessageLog.Invoke(() =>
            {
                MessageLog.Items.Add(data);

                if (message.type == MessageType.Location)
                {
                    var location = message.location;
                    var dataLocation = string.Format("--> latitude: {0}, longitude: {1}, description: {2}",
                        location.latitude, location.longitude, location.description);

                    System.Diagnostics.Debug.Print(dataLocation);

                    MessageLog.Items.Add(dataLocation);
                }
                else if (message.type == MessageType.VCard || message.type == MessageType.MultiVCard)
                {
                    var vcards = message.vcards;
                    var vcardFilenames = message.vcardFilenames;

                    var index = 0;
                    foreach (var vcard in vcards)
                    {
                        var dataVCard = string.Format("--> N: {0}, FN: {1}, WA Id: {2}, File Name: {3}",
                            vcard.n, vcard.fn, vcard.waId, vcardFilenames[index]);

                        MessageLog.Items.Add(dataVCard);
                        index++;
                    }
                }

                MessageLog.SelectedIndex = MessageLog.Items.Count - 1;
            });

            if (chkAutoReplay.Checked)
            {
                if (chkSendLocation.Checked)
                {
                    var location = new Location
                    {
                        latitude = txtLatitude.Text,
                        longitude = txtLongitude.Text,
                        description = txtDescription.Text
                    };

                    _wa.ReplyMessage(new ReplyMsgArgs(message.from, location, message.id));
                }
                else
                {
                    var msgReplay = string.Format
                    (
                        "Bpk/Ibu *{0}*, We have received *{1}* message(s). Please wait.",
                        msender, 
                        msg
                    );

                    _wa.ReplyMessage(new ReplyMsgArgs(message.from, msgReplay, message.id));
                }                               
            }

        }//OnReceiveMessageHandler



        // OnReceiveMessagesHandler
        private void OnReceiveMessagesHandler(IList<WhatsAppNETAPI.Message> messages, string sessionId)
        {
            foreach (var message in messages)
            {
                var msg = message.content;

                var pengirim = string.Empty;
                var group = string.Empty;

                var isGroup = message.group != null;

                if (isGroup) // message from group
                {
                    group = string.IsNullOrEmpty(message.group.name) ? message.from : message.group.name;

                    var sender = message.group.sender;
                    pengirim = string.IsNullOrEmpty(sender.name) ? message.from : sender.name;
                }
                else
                    pengirim = string.IsNullOrEmpty(message.sender.name) ? message.from : message.sender.name;

                var data = string.Empty;

                if (isGroup)
                {
                    data = string.Format("[{0}] Group: {1}, Text Message: {2}, Sender: {3}",
                        message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), group, msg, pengirim);
                }
                else
                {
                    data = string.Format("[{0}] Sender: {1}, Message content: {2}",
                        message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), pengirim, msg);
                }

                // update the UI from a different thread
                MessageLog.Invoke(() =>
                {
                    MessageLog.Items.Add(data);
                    MessageLog.SelectedIndex = MessageLog.Items.Count - 1;
                });

                if (chkAutoReplay.Checked)
                {
                    var senderName = string.IsNullOrEmpty(message.sender.name) ? message.from : message.sender.name;

                    var msgReplay = string.Format("Bpk/Ibu *{0}*, Message(s) *{1}* was recieved. Please wait.",
                            senderName, msg);

                    _wa.ReplyMessage(new ReplyMsgArgs(message.from, msgReplay, message.id));
                }

            }
        }//OnReceiveMessagesHandler


        // OnReceiveMessageStatusHandler
        private void OnReceiveMessageStatusHandler(WhatsAppNETAPI.MessageStatus msgStatus, string sessionId)
        {
            var status = msgStatus.status == "true" ? "SUCCEED" : "FAIL";

            var msg = string.Format("Message delivery status to {0}, {1}",
                msgStatus.send_to, status);

            // UI update from different thread
            lstMessageOut.Invoke(() =>
            {
                lstMessageOut.Items.Add(msg);
                lstMessageOut.SelectedIndex = lstMessageOut.Items.Count - 1;
            });

        }//OnReceiveMessageStatusHandler



        // OnClientConnectedHandler
        private void OnClientConnectedHandler(string sessionId)
        {
            System.Diagnostics.Debug.Print("ClientConnected on {0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
        }//OnClientConnectedHandler

        #endregion


        // btnLokasiWAAutomateNodejs_Click (Locate NodeJS API folder)
        private void btnLokasiWAAutomateNodejs_Click(object sender, EventArgs e)
        {
            var folderName = ShowDialogOpenFolder();

            if (!string.IsNullOrEmpty(folderName)) txtLocateWhatsAppNETAPINodeJs.Text = folderName;
        }//btnLokasiWAAutomateNodejs_Click


        // btnLokasiPenyimpananFileAtauGambar_Click (Locate File Storage folder)
        private void btnLokasiPenyimpananFileAtauGambar_Click(object sender, EventArgs e)
        {
            var folderName = ShowDialogOpenFolder();

            if (!string.IsNullOrEmpty(folderName)) txtFileStorageLocation.Text = folderName;

        }//btnLokasiPenyimpananFileAtauGambar_Click


        // FrmMain_FormClosing
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();

        }//FrmMain_FormClosing


        // btnPilihGroup_Click (SelectGroup)
        private void btnPilihGroup_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmPilihGroup("Select Group"))
            {
                _wa.OnReceiveGroups += frm.OnReceiveGroupsHandler; // subscribe event
                _wa.GetGroups(false);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _selectedGroup = frm.Group;

                    if (_selectedGroup != null) txtContact.Text = _selectedGroup.name;
                }

                _wa.OnReceiveGroups -= frm.OnReceiveGroupsHandler; // unsubscribe event
            }
        }//btnPilihGroup_Click


        // chkGroup_CheckedChanged
        private void chkGroup_CheckedChanged(object sender, EventArgs e)
        {
            _selectedGroup = null;
            txtContact.Clear();

            btnSelectGroup.Enabled = chkGroup.Checked;
            txtContact.Enabled = !chkGroup.Checked;

        }//chkGroup_CheckedChanged

         
    }//FrmMain class end

}//namespace end 
