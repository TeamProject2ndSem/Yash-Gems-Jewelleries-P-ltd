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
        public string Product_Name { get; set; }

        [Required]
        public string MRP { get; set; }
    }

}
