using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class DimMst
{
    [Key]
    public int Style_Code { get; set; }

    [ForeignKey("DimQltyMst")]
    public int DimQlty_ID { get; set; }
  
    public DimQltyMst DimQltyMst { get; set; }

    [Required]
    public int Dim_Crt { get; set; }

    [Required]
    public int Dim_Pcs { get; set; }

    [Required]
    public int Dim_Gm { get; set; }

    [Required]
    public int Dim_Size { get; set; }

    [Required]
    public int Dim_Rate { get; set; }

    [Required]
    public int Dim_Amt { get; set; }

    // Other properties...
}
