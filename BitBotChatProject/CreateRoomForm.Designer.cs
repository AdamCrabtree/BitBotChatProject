namespace BitBotChatProject
{
    partial class CreateRoomForm
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
            this.bCreateRoom = new System.Windows.Forms.Button();
            this.tbRoomName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCreateRoom
            // 
            this.bCreateRoom.Location = new System.Drawing.Point(84, 226);
            this.bCreateRoom.Name = "bCreateRoom";
            this.bCreateRoom.Size = new System.Drawing.Size(100, 23);
            this.bCreateRoom.TabIndex = 0;
            this.bCreateRoom.Text = "Create Room";
            this.bCreateRoom.UseVisualStyleBackColor = true;
            this.bCreateRoom.Click += new System.EventHandler(this.bCreateRoom_Click);
            // 
            // tbRoomName
            // 
            this.tbRoomName.Location = new System.Drawing.Point(84, 119);
            this.tbRoomName.Name = "tbRoomName";
            this.tbRoomName.Size = new System.Drawing.Size(100, 20);
            this.tbRoomName.TabIndex = 1;
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbRoomName);
            this.Controls.Add(this.bCreateRoom);
            this.Name = "CreateRoomForm";
            this.Text = "CreateRoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCreateRoom;
        private System.Windows.Forms.TextBox tbRoomName;
    }
}