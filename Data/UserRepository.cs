using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TPL_Store.Models;

namespace TPL_Store.Data
{
    public class UserRepository
    {
        private List<UserInformation> _users;
        
      
        public UserRepository()
        {
            // Establishing user list
            _users = new List<UserInformation>();
        
            // Sample user to be used
            var user = new UserInformation { Username = "admin" };
            user.SetPassword("password123");
            _users.Add(user);
        }
        
        public bool ValidateUser(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.Username == username);
            return user != null && user.ValidatePassword(password);
        }
        
        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte t in bytes)
            {
                builder.Append(t.ToString("x2"));
            }
            return builder.ToString();
        }


   
    }
}
