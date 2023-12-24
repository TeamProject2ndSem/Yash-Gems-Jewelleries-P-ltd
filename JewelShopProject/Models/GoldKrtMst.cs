using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class GoldKrtMst
    {
        [Key]
        [StringLength(10)]
        public string GoldType_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Gold_Crt { get; set; }
    }

}
