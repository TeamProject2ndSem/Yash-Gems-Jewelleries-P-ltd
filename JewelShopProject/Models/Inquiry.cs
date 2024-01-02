using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class Inquiry
    {
        [Key]
        
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(10)]
        public string Contact { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailID { get; set; }

        [Required]
        [MaxLength]
        public string Comment { get; set; }

        [Required]
        public DateTime Cdate { get; set; }
    }

}
