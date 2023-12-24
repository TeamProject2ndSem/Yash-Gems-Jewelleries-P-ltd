using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class UserRegMst
    {
        [Key]
        [StringLength(10)]
        public string userID { get; set; }

        [Required]
        [MaxLength]
        public string userFname { get; set; }

        [Required]
        [MaxLength]
        public string userLname { get; set; }

        [Required]
        [MaxLength]
        public string address { get; set; }

        [Required]
        [StringLength(50)]
        public string city { get; set; }

        [Required]
        [StringLength(50)]
        public string state { get; set; }

        [Required]
        [StringLength(50)]
        public string mobNo { get; set; }

        [Required]
        [StringLength(50)]
        public string emailID { get; set; }

        [Required]
        [StringLength(50)]
        public string dob { get; set; }

        [Required]
        [StringLength(50)]
        public string cdate { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }
    }

}
