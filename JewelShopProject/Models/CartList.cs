using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class CartList
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Product_Name { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal MRP { get; set; }
    }

}
