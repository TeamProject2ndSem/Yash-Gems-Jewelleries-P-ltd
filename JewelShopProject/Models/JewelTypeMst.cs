using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class JewelTypeMst
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string JewelType { get; set; }
    }

}
