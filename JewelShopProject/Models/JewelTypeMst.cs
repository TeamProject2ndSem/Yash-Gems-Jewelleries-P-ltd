using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class JewelTypeMst
    {
        [Key]
        [StringLength(10)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string JewelType { get; set; }
    }

}
