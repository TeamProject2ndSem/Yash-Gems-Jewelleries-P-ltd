﻿using System.ComponentModel.DataAnnotations;

public class DimQltySubMst
{
    [Key]
    [StringLength(10)]
    public int DimSubType_ID { get; set; }

    [Required]
    [StringLength(50)]
    public string DimQlty { get; set; }
}
