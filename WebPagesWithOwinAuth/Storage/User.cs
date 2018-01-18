using System;

namespace WebPagesWithOwinAuth.Storage
{
    /// <summary>
    /// Sample domain user with minimun fields required
    /// </summary>
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}