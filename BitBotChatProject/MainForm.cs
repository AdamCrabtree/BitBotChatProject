using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Main part of the project. This handles allowing users to join rooms and send messages in those rooms the majority of the time is spent here*/
namespace BitBotChatProject
{
    public partial class MainForm : Form
    {
        bool initialRoom = true;
        bool run = true;
        ThreadStart updateTextBoxRef;
        Thread updateTextBoxThread;
        List<UserMessage> myMessages;
        private User currentUser;
        private Room currentRoom;
        List<User> usersInRoom;
#region startup
        //starts the current form and adds all the necessary threads and initializes the user into the database and gets everything from the database 
        public MainForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            StartMainForm();
        }
        private void StartMainForm()
        {
            JoinNewRoom();
            GetPopularRooms();
            updateTextBoxRef = new ThreadStart(UpdateMessageBox);
            updateTextBoxThread = new Thread(updateTextBoxRef);
            updateTextBoxThread.Start();
        }
#endregion
#region RoomRegion
        //handles joining room through either selecting room or through searching for a room when joining a new room 
        // JoinNewRoom stops updating the message box by aborting updateTextBoxThread until the new room is totally loaded in
        //Create room just launches a create room dialogue
        //get popular rooms gets a list of the most popular rooms in decending order and puts it into the list box
        private void bJoinRoom_Click(object sender, EventArgs e)
        {
            JoinNewRoom(lbPopularRooms.SelectedItem.ToString());
        }
        private void bFindRoom_Click(object sender, EventArgs e)
        {
            JoinNewRoom(tbFindRoom.Text);
        }
        private void JoinNewRoom(string roomName = "Welcome Room")
        {
            if (!initialRoom) //on joining the first initial room, welcome room, the thread to abort hasn't been created yet so it can't be aborted
            {
                updateTextBoxThread.Abort();
            }
            currentRoom = RoomHandler.PublicGetRoom(roomName, currentUser);
            if (currentRoom != null)
            {
                usersInRoom = RoomHandler.PublicGetRoomUsers(currentRoom);
                lbCurrentUsers.Items.Clear();
                foreach (User user in usersInRoom)
                {
                    lbCurrentUsers.Items.Add(user.Username);
                }
                myMessages = null;
            }
            rtbMessages.Clear();
            if (!initialRoom) //same reasoning as on the if above
            {
                updateTextBoxThread = new Thread(updateTextBoxRef);
                updateTextBoxThread.Start();
                GetPopularRooms();
            }
            initialRoom = false;
        }
        private void bCreateRoom_Click(object sender, EventArgs e)
        {
            CreateRoomForm createRoomForm = new CreateRoomForm();
            createRoomForm.ShowDialog();
        }
        private void GetPopularRooms()
        {
            List<Room> popularRooms = RoomHandler.PublicGetPopularRooms();
            foreach (var room in popularRooms)
            {
                lbPopularRooms.Items.Add(room.RoomName);
            }
        }
#endregion RoomRegion
#region MessagingRegion 
        //handles user messaging sends data to MessagesHandler which then sends it to database Update message box runs in its own thread and then updates 
        //from the database every 1 second and posts a message to the message rich text box if it's a new message for the current run 
        //thread gets reset on every room join so messageIdList then redefaults to 0


        private void bSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }


        private void tbUserMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendMessage();
            }
        }

        private void SendMessage()
        {
            if (String.IsNullOrWhiteSpace(tbUserMessage.Text))
            {
                MessagesHandler.PublicPostMessage(tbUserMessage.Text, currentUser, currentRoom);
            }
        }
        private void UpdateMessageBox()
        {
            List<int> messageIdList = new List<int>();
            while (run)
            {
                myMessages = MessagesHandler.PublicGetMessages(currentRoom);
                foreach (var messageToBox in myMessages)
                {
                    if (!messageIdList.Contains(messageToBox.Id))
                    {
                        rtbMessages.Invoke((MethodInvoker)delegate
                        {
                            rtbMessages.AppendText(messageToBox.MessageText + "\n");
                        });
                        messageIdList.Add(messageToBox.Id);
                    }
                }
                Thread.Sleep(100);
            }
        }
        #endregion MessagingRegion
#region ClosingRegion
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RoomHandler.PublicRemoveUser(currentUser);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
#endregion ClosingRegion
    }
}
