﻿using System.ComponentModel.DataAnnotations;

namespace JewelShopProject.Models
{
    public class CertifyMst
    {
        [Key]
        public int Certify_ID { get; set; }

        [Required]
        public string Certify_Type { get; set; }
    }
}
