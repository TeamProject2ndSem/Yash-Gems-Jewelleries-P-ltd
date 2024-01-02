using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class ProdMst
    {
        [Key]
        public int Prod_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Prod_Type { get; set; }
    }

}
