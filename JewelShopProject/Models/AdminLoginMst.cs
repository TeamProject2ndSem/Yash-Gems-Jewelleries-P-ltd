﻿using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class AdminLoginMst
    {
        [Key]
        public int AdId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string UserRole { get; set; }

        public AdminLoginMst()
        {
            // Set default value for UserRole
            UserRole = "Admin";
            Username = "Demo";
            Password = "123";

        }
    }
}
