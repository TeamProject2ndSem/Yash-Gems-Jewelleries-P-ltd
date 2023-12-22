using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class AdminLoginMst
    {
        [Key]
        public int AdId { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }

    }
}
