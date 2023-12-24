using JewelShopProject.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class ItemMst
{
    [Key]
    [StringLength(50)]
    public string Style_Code { get; set; }

    [Required]
    [Range(0, 999)] // Adjust range as needed
    public int Pairs { get; set; }

    [StringLength(10)]
    public string Brand_ID { get; set; }

    public BrandMst Brand { get; set; } // Navigation property for BrandMst

    [Required]
    [Range(0, 999999999999999999)] // Adjust range as needed
    public decimal Quantity { get; set; }

    [StringLength(10)]
    public string Cat_ID { get; set; }

    public CatMst Category { get; set; } // Navigation property for CatMst

    [Required]
    [StringLength(50)]
    public string Prod_Quality { get; set; }

    [StringLength(10)]
    public string Certify_ID { get; set; }

    public CertifyMst Certification { get; set; } // Navigation property for CertifyMst

    [StringLength(10)]
    public string Prod_ID { get; set; }

    [StringLength(10)]
    public string GoldType_ID { get; set; }

    public GoldKrtMst GoldType { get; set; } // Navigation property for GoldKrtMst

    [Required]
    [Column(TypeName = "numeric(10,3)")]
    public decimal Gold_Wt { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Stone_Wt { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,3)")]
    public decimal Net_Gold { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,3)")]
    public decimal Wstg_Per { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,3)")]
    public decimal Wstg { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,3)")]
    public decimal Tot_Gross_Wt { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Gold_Rate { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Gold_Amt { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Gold_Making { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Stone_Making { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Other_Making { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Tot_Making { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal MRP { get; set; }
}
