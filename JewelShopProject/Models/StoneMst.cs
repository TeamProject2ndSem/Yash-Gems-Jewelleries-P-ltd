using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class StoneMst
    {
        [Key]
        [StringLength(50)]
        public string Style_Code { get; set; }

        [ForeignKey("StoneQltyMst")]
        [StringLength(10)]
        public string StoneQlty_ID { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Stone_Gm { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Stone_Pcs { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Stone_Crt { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Stone_Rate { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Stone_Amt { get; set; }

        // Other properties...

        public StoneQltyMst StoneQltyMst { get; set; } // Navigation property for the foreign key
    }


}
