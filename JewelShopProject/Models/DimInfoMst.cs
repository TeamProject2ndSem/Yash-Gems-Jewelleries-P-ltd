using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class DimInfoMst
    {
        [Key]
        [StringLength(10)]
        public string DimID { get; set; }

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

        [NotMapped] // This field will not be mapped to the database
        public IFormFile DimImgFile { get; set; } // This property holds the uploaded image file

        
        [StringLength(255)] // Adjust the length as needed
        public string DimImgPath { get; set; } // This property holds the path to the saved image
    }

}
