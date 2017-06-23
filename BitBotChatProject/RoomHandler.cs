using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBotChatProject
{
    public static class RoomHandler
    {
        public static Room PublicGetRoom(string roomName, User currentUser)
        {
            return JoinRoom(roomName, currentUser);
        }
        private static Room JoinRoom(string roomName, User currentUser)
        {
            using (BitBotChatDatabaseEntities1 roomDB = new BitBotChatDatabaseEntities1())
            {

                Room currentRoom = roomDB.Rooms.FirstOrDefault(r => r.RoomName == roomName);
                if (currentRoom == null)
                {
                    return null;
                }
                else
                {
                    var updatedUser = roomDB.Users.Where(user => user.Id == currentUser.Id).ToList().Select(user => { user.RoomInside = currentRoom.Id; return user; }).First();
                    roomDB.Users.Attach(updatedUser);
                    var entry = roomDB.Entry(updatedUser);
                    entry.Property(e => e.RoomInside).IsModified = true;
                    roomDB.SaveChanges();
                    return currentRoom;
                }
            }
        }
        public static List<User> PublicGetRoomUsers(Room currentRoom)
        {
            return (GetRoomUsers(currentRoom));
        }
        private static List<User> GetRoomUsers(Room currentRoom)
        {
            using (BitBotChatDatabaseEntities1 usersDB = new BitBotChatDatabaseEntities1())
            {
                List<User> currentRoomUsers = usersDB.Users.Where(user => user.RoomInside == currentRoom.Id).ToList();
                return currentRoomUsers;
            }
        }
        public static void PublicRemoveUser( User currentUser)
        {
            RemoveUser(currentUser);
        }
        private static void RemoveUser(User currentUser)
        {
            using (BitBotChatDatabaseEntities1 usersDB = new BitBotChatDatabaseEntities1())
            {
                currentUser.RoomInside = null;
                var updatedUser = currentUser;
                usersDB.Users.Attach(updatedUser);
                var entry = usersDB.Entry(updatedUser);
                entry.Property(e => e.RoomInside).IsModified = true;
            }
        }
        public static void PublicCreateRoom(string roomName)
        {
            CreateRoom(roomName);
        }
        private static void CreateRoom(string roomName)
        {
            using (BitBotChatDatabaseEntities1 myDB = new BitBotChatDatabaseEntities1())
            {
                Room newRoom = new Room()
                {
                    RoomName = roomName,
                };
                if (myDB.Rooms.Where(room=>room.RoomName == roomName).Count() == 0)
                {
                    myDB.Rooms.Add(newRoom);
                    myDB.SaveChanges();
                }
            }
        }
        public static List<Room> PublicGetPopularRooms()
        {
            return GetPopularRooms();
        }
        private static List<Room> GetPopularRooms()
        {
            using (BitBotChatDatabaseEntities1 roomDB = new BitBotChatDatabaseEntities1())
            {
                List<Room> allRooms  = roomDB.Rooms.ToList();
                List<List<User>> usersInRooms = new List<List<User>>();
                foreach(Room room in allRooms)
                {
                    List<User> usersInRoom = roomDB.Users.Where(user => user.RoomInside == room.Id).ToList();
                    usersInRooms.Add(usersInRoom);
                }
                var sorted = usersInRooms.OrderByDescending(list => list.Count);
                List<Room> popularRooms = new List<Room>();
                foreach(List<User> list in usersInRooms)
                {
                    User roomUser = list.FirstOrDefault();
                    if (roomUser != null)
                    {
                        popularRooms.Add(roomDB.Rooms.Where(room => room.Id == roomUser.RoomInside).First());
                    }
                }
                return popularRooms;
            }
        }
    }
}
