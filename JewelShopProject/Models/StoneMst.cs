using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class StoneMst
    {
        [Key]
        public int Style_Code { get; set; }

        [ForeignKey("StoneQltyMst")]
        public int StoneQlty_ID { get; set; }

        public StoneQltyMst stoneQltyMst { get; set; }

        [Required]
        public int Stone_Gm { get; set; }

        [Required]
        public int Stone_Pcs { get; set; }

        [Required]
        public int Stone_Crt { get; set; }

        [Required]
        public int Stone_Rate { get; set; }

        [Required]
        public int Stone_Amt { get; set; }

        // Other properties...

        public StoneQltyMst StoneQltyMst { get; set; } // Navigation property for the foreign key
    }


}
