using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitBotChatProject
{
    public partial class CreateRoomForm : Form
    {
        public CreateRoomForm()
        {
            InitializeComponent();
        }

        private void bCreateRoom_Click(object sender, EventArgs e)
        {
            RoomHandler.PublicCreateRoom(tbRoomName.Text);
            this.Close();
        }
    }
}
