using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDP.Models
{
    /// <summary>
    /// Class for creating a user
    /// </summary>
    public class User
    {
        string username { get; set; }
        string password { get; set; }

        /// <summary>
        /// Constructor for user object.
        /// </summary>
        /// <param name="inputUsername"></param>
        /// <param name="inputPassword"></param>
        public User(string inputUsername, string inputPassword)
        {
            username = inputUsername;
            password = inputPassword;
        }
    }
}
