using System.ComponentModel.DataAnnotations;

public class DimQltyMst
{
    [Key]
    public int DimQltyMst_ID { get; set; }

    [Required]
    [StringLength(50)]
    public string DimQlty { get; set; }
}
