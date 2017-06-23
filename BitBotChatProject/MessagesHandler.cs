using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*handles all user messaging including posting and recieving.*/
namespace BitBotChatProject
{
    class MessagesHandler
    {
        public static void PublicPostMessage(String messageText, User sendingUser, Room currentRoom)
        {
            PostMessage(sendingUser.Username + ": " + messageText, sendingUser, currentRoom);
        }
        //creates a new message with a roomId associated with it and adds it to database
        private static void PostMessage(String messageText, User sendingUser, Room currentRoom)
        {
            using (BitBotChatDatabaseEntities1 myDB = new BitBotChatDatabaseEntities1())
            {
                UserMessage message = new UserMessage()
                {
                    MessageText = messageText,
                    SendingUser = sendingUser.Id,
                    RoomSentTo = currentRoom.Id
                };
                myDB.UserMessages.Add(message);
                myDB.SaveChanges();
            }
        }
        public static List<UserMessage> PublicGetMessages(Room currentRoom)
        {
            return GetMessages(currentRoom);
        }
        //gets all messages from the current room you're in. Runs in it's own thread. Queries database every 1 second so that needs to be fixed
        private static List<UserMessage> GetMessages(Room currentRoom)
        {
            using (BitBotChatDatabaseEntities1 myDB = new BitBotChatDatabaseEntities1())
            {
                Console.Write(currentRoom.RoomName);
                List<UserMessage> myMessages = myDB.UserMessages.Where(message=>message.RoomSentTo == currentRoom.Id).ToList();
                return myMessages;
            }
        }
    }
}
