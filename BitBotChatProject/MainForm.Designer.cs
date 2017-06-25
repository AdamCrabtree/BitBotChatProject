namespace BitBotChatProject
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
            this.bSend = new System.Windows.Forms.Button();
            this.tbUserMessage = new System.Windows.Forms.TextBox();
            this.bCreateRoom = new System.Windows.Forms.Button();
            this.lbPopularRooms = new System.Windows.Forms.ListBox();
            this.tbFindRoom = new System.Windows.Forms.TextBox();
            this.bFindRoom = new System.Windows.Forms.Button();
            this.tCurrentRoom = new System.Windows.Forms.Label();
            this.bJoinRoom = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.tabRooms = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbCurrentUsers = new System.Windows.Forms.ListBox();
            this.tabRooms.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(1485, 806);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(99, 23);
            this.bSend.TabIndex = 0;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tbUserMessage
            // 
            this.tbUserMessage.Location = new System.Drawing.Point(153, 809);
            this.tbUserMessage.Name = "tbUserMessage";
            this.tbUserMessage.Size = new System.Drawing.Size(1326, 20);
            this.tbUserMessage.TabIndex = 1;
            this.tbUserMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserMessage_KeyPress);
            // 
            // bCreateRoom
            // 
            this.bCreateRoom.Location = new System.Drawing.Point(1505, 7);
            this.bCreateRoom.Name = "bCreateRoom";
            this.bCreateRoom.Size = new System.Drawing.Size(79, 23);
            this.bCreateRoom.TabIndex = 3;
            this.bCreateRoom.Text = "Create Room";
            this.bCreateRoom.UseVisualStyleBackColor = true;
            this.bCreateRoom.Click += new System.EventHandler(this.bCreateRoom_Click);
            // 
            // lbPopularRooms
            // 
            this.lbPopularRooms.FormattingEnabled = true;
            this.lbPopularRooms.Location = new System.Drawing.Point(-4, 3);
            this.lbPopularRooms.Name = "lbPopularRooms";
            this.lbPopularRooms.Size = new System.Drawing.Size(128, 784);
            this.lbPopularRooms.TabIndex = 4;
            // 
            // tbFindRoom
            // 
            this.tbFindRoom.Location = new System.Drawing.Point(685, 15);
            this.tbFindRoom.Name = "tbFindRoom";
            this.tbFindRoom.Size = new System.Drawing.Size(204, 20);
            this.tbFindRoom.TabIndex = 6;
            // 
            // bFindRoom
            // 
            this.bFindRoom.Location = new System.Drawing.Point(895, 12);
            this.bFindRoom.Name = "bFindRoom";
            this.bFindRoom.Size = new System.Drawing.Size(75, 23);
            this.bFindRoom.TabIndex = 7;
            this.bFindRoom.Text = "Find Room";
            this.bFindRoom.UseVisualStyleBackColor = true;
            this.bFindRoom.Click += new System.EventHandler(this.bFindRoom_Click);
            // 
            // tCurrentRoom
            // 
            this.tCurrentRoom.AutoSize = true;
            this.tCurrentRoom.Location = new System.Drawing.Point(682, 50);
            this.tCurrentRoom.Name = "tCurrentRoom";
            this.tCurrentRoom.Size = new System.Drawing.Size(75, 13);
            this.tCurrentRoom.TabIndex = 8;
            this.tCurrentRoom.Text = "Current Room:";
            // 
            // bJoinRoom
            // 
            this.bJoinRoom.Location = new System.Drawing.Point(12, 806);
            this.bJoinRoom.Name = "bJoinRoom";
            this.bJoinRoom.Size = new System.Drawing.Size(79, 23);
            this.bJoinRoom.TabIndex = 9;
            this.bJoinRoom.Text = "Join Room";
            this.bJoinRoom.UseVisualStyleBackColor = true;
            this.bJoinRoom.Click += new System.EventHandler(this.bJoinRoom_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(153, 66);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(1326, 734);
            this.rtbMessages.TabIndex = 10;
            this.rtbMessages.Text = "";
            // 
            // tabRooms
            // 
            this.tabRooms.Controls.Add(this.tabPage1);
            this.tabRooms.Controls.Add(this.tabPage2);
            this.tabRooms.Location = new System.Drawing.Point(12, 66);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.SelectedIndex = 0;
            this.tabRooms.Size = new System.Drawing.Size(135, 734);
            this.tabRooms.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbPopularRooms);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(120, 708);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Popular Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbCurrentUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(127, 708);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbCurrentUsers
            // 
            this.lbCurrentUsers.FormattingEnabled = true;
            this.lbCurrentUsers.Location = new System.Drawing.Point(0, 0);
            this.lbCurrentUsers.Name = "lbCurrentUsers";
            this.lbCurrentUsers.Size = new System.Drawing.Size(304, 706);
            this.lbCurrentUsers.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tabRooms);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.bJoinRoom);
            this.Controls.Add(this.tCurrentRoom);
            this.Controls.Add(this.bFindRoom);
            this.Controls.Add(this.tbFindRoom);
            this.Controls.Add(this.bCreateRoom);
            this.Controls.Add(this.tbUserMessage);
            this.Controls.Add(this.bSend);
            this.Name = "MainForm";
            this.Text = "MainFormcs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabRooms.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tbUserMessage;
        private System.Windows.Forms.Button bCreateRoom;
        private System.Windows.Forms.ListBox lbPopularRooms;
        private System.Windows.Forms.TextBox tbFindRoom;
        private System.Windows.Forms.Button bFindRoom;
        private System.Windows.Forms.Label tCurrentRoom;
        private System.Windows.Forms.Button bJoinRoom;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.TabControl tabRooms;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbCurrentUsers;
    }
}