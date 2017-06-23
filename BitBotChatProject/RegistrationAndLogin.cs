using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBotChatProject
{
    public class RegistrationAndLogin
    {
        public static User PublicLoginUser(string username, string password)
        {
            return LoginUser(username, password);
        }
        public static int  PublicRegisterUser(String username, String password, String email) //return 1 if success, return 0 if login failure due to duplicate username
        {
            return(RegisterUser(username, password, email));
        }
        private static int RegisterUser(String username, String password, String email) 
        {
            password = encryptPassword(password);
            User newUser = new User()
            {
                Username = username,
                Password = password,
                Email = email,
            };
            using (BitBotChatDatabaseEntities1 registerModel = new BitBotChatDatabaseEntities1())
            {
                if (registerModel.Users.Where(u=>u.Username==username).Count()==0)
                {
                    registerModel.Users.Add(newUser);
                    registerModel.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        private static User LoginUser(String username, String password)
        {
            password = encryptPassword(password);
            using (BitBotChatDatabaseEntities1 loginModel = new BitBotChatDatabaseEntities1())
            {
                User newUser;
                try
                {
                    if ((newUser = loginModel.Users.Where(user => user.Username == username && user.Password == password).First()) != null)
                    {
                        return newUser;
                    }
                    else
                    {
                        return null;
                    }
                } catch(Exception e)
                {
                    return null;
                }
            }
        }
        private static String encryptPassword(string password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}
