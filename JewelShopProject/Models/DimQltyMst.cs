using System.ComponentModel.DataAnnotations;

public class DimQltyMst
{
    [Key]
    public int DimQltyMst_ID { get; set; }

    [Required]
    public string DimQlty { get; set; }
}
