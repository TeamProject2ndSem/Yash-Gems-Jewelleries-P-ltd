using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


  
namespace JewelShopProject.Models
{
    public class ItemMst
    {
        [Key]
        public int Style_Code { get; set; } // Code Of Style

        [System.ComponentModel.DataAnnotations.Required]
        public int Pairs { get; set; } // Pairs Of Product

        [StringLength(10)]
        [ForeignKey("Brand")]
        public int Brand_ID { get; set; } // ID Of Particular Brand

        public BrandMst BrandMst { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public int Quantity { get; set; } // Available Quantity

        [ForeignKey("CatMst")]
        public int Cat_ID { get; set; } // ID Of Category

        public CatMst CatMst { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Prod_Quality { get; set; } // Quality Of Product

        [ForeignKey("CertifyMst")]
        public int Certify_ID { get; set; } // ID Of Certification

        public CertifyMst CertifyMst { get; set; }

        [ForeignKey("ProdMst")]
        public int Prod_ID { get; set; } // Product ID


        public ProdMst ProdMst { get; set; }

        [ForeignKey("GoldKrtMst")]
        public int GoldType_ID { get; set; } // ID Of Gold Type

        public GoldKrtMst GoldKrtMst { get; set; }
        
        [System.ComponentModel.DataAnnotations.Required]
        public int Gold_Wt { get; set; } // Weight Of Gold

                [System.ComponentModel.DataAnnotations.Required]
        public string Stone_Wt { get; set; } // Weight Of Stone

                [System.ComponentModel.DataAnnotations.Required]
        public string Net_Gold { get; set; } // Net Gold

                [System.ComponentModel.DataAnnotations.Required]
        public string Wstg_Per { get; set; } // Wastage In Percentage

                [System.ComponentModel.DataAnnotations.Required]
        public string Wstg { get; set; } // Wastage

                [System.ComponentModel.DataAnnotations.Required]
        public string Tot_Gross_Wt { get; set; } // Total Gross Weight

                [System.ComponentModel.DataAnnotations.Required]
        public string Gold_Rate { get; set; } // Rate Of Gold

                [System.ComponentModel.DataAnnotations.Required]
        public string Gold_Amt { get; set; } // Amount Of Gold In Item

        [System.ComponentModel.DataAnnotations.Required]
        public string Gold_Making { get; set; } // Gold Making Charges

      
        public string Stone_Making { get; set; } // Stone Making Charges

        [System.ComponentModel.DataAnnotations.Required]
        public string Other_Making { get; set; } // Other Making Charges

        [System.ComponentModel.DataAnnotations.Required]
        public string Tot_Making { get; set; } // Total Making Charges

        [System.ComponentModel.DataAnnotations.Required]
        public string MRP { get; set; } // MRP Of Product
    }


}
