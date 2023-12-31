using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class DimInfoMst
    {
        [Key]
        public int DimID { get; set; }

        [Required]
        [StringLength(50)]
        public string DimType { get; set; }

        [Required]
        [StringLength(50)]
        public string DimSubType { get; set; }

        [Required]
        [StringLength(50)]
        public string DimCrt { get; set; }

        [Required]
        [StringLength(50)]
        public string DimPrice { get; set; }
    
        public string DimImgPath { get; set; } // This property holds the path to the saved image
    }

}
