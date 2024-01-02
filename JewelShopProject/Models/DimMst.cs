using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class DimMst
{
    [Key]
    public int Style_Code { get; set; }

    [ForeignKey("DimQltyMst")]
    [StringLength(10)]
    public string DimQlty_ID { get; set; }

    [ForeignKey("DimQltyMst_ID")]
    [StringLength(10)]
    public string DimQltyMst_ID { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Dim_Crt { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Dim_Pcs { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Dim_Gm { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Dim_Size { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Dim_Rate { get; set; }

    [Required]
    [Column(TypeName = "numeric(10,2)")]
    public decimal Dim_Amt { get; set; }

    // Other properties...
}
