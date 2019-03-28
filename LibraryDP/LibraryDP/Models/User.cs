using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDP.Models
{
    /// <summary>
    /// Class for creating a user
    /// </summary>
    public class User
    {
        public int? Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        /// <summary>
        /// Constructor for user object.
        /// </summary>
        /// <param name="inputUsername"></param>
        /// <param name="inputPassword"></param>

        public User(int userId, string inputUsername, string inputPassword)
        {
            Id = userId;
            Username = inputUsername;
            Password = inputPassword;
        }


        public class CreateUserModel
        {
            [Required]
            [Key]
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            public string Username { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

        }
    }
}
