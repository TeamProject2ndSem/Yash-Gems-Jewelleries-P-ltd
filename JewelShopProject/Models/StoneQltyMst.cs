using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class StoneQltyMst
    {
        [Key]
        public int StoneQlty_ID { get; set; }

        [Required]
        public string StoneQlty { get; set; }
    }

}
