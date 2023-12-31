using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models.Image
{
    public class ImageDim
    {
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

        public IFormFile DimImgPath { get; set; } // This property holds the path to the saved image
    }
}
