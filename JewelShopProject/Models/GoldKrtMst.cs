using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class GoldKrtMst
    {
        [Key]
        public int GoldType_ID { get; set; }

        [Required]
        public string Gold_Crt { get; set; }
    }

}
