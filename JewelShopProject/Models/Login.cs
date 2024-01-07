using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
