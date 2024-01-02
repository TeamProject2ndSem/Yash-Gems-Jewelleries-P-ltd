using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class CatMst
    {
        [Key]
        public int Cat_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Cat_Name { get; set; }
    }
}
