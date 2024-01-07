using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class UserRegMst
    {
        [Key]
        public int userID { get; set; }

        public string Username { get; set; }

        [Required]
        public string userFname { get; set; }

        [Required]
        public string userLname { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string state { get; set; }

        [Required]
        public string mobNo { get; set; }

        [Required]
        public string emailID { get; set; }

        [Required]
        public string dob { get; set; }

        [Required]
        public string cdate { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string UserRole { get; set; }
        public UserRegMst()
        {
            // Set cdate to the current date when an instance is created
            cdate  = DateTime.Now.ToString("yyyy-MM-dd"); // Adjust the format as needed
            UserRole = "User";
        }
    }

}
