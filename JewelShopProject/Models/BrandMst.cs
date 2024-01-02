using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class BrandMst
    {
        [Key]
        public int Brand_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand_Type { get; set; }
    }
}
