using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class StoneQltyMst
    {
        [Key]
        [StringLength(10)]
        public int StoneQlty_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string StoneQlty { get; set; }
    }

}
