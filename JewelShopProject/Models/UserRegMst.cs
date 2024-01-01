using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class UserRegMst
    {
        [Key]
        public int userID { get; set; }

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
        public UserRegMst()
        {
            // Set cdate to the current date when an instance is created
            cdate  = DateTime.Now.ToString("yyyy-MM-dd"); // Adjust the format as needed
        }
    }

}
