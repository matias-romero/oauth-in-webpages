using System;
using System.Collections.Generic;
using System.Linq;

namespace WebPagesWithOwinAuth.Storage
{
    /// <summary>
    /// Sample repository for users (In Memory)
    /// </summary>
    public class UsersRepository
    {
        private readonly List<User> _allowedUsers = new List<User>();

        public UsersRepository()
        {
            //Seed with sample users. This could be any kind of repository
            _allowedUsers.Add(new User{ Username = "Jane", Password = "password123"});
            _allowedUsers.Add(new User { Username = "Jack", Password = "password123" });
        }

        public User FindUserForAuthentication(string username, string password)
        {
            //Authentication only based in username/password credentials matching
            return _allowedUsers
                .SingleOrDefault(user => user.Username.Equals(username) && user.Password.Equals(password));
        }
    }
}