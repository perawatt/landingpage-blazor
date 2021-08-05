using System;
using System.ComponentModel.DataAnnotations;

public class AddressInfo
{
    [Required(ErrorMessage = "ใส่ชื่อ นะจ๊ะ")]
    public string Name { get; set; }

    [Required(ErrorMessage = "ที่อยู่ จ๊ะ")]
    public string Add { get; set; }

    [Required]
    public string Subdistrict { get; set; }

    [Required]
    public string District { get; set; }

    [Required]
    public string Provice { get; set; }

    [Required]
    public string ZipCode { get; set; }

    [Required(ErrorMessage = "ใส่เบอมาสิ")]
    public string Tel { get; set; }

    [Required(ErrorMessage = "อีเมล หยัง?")]
    public string Email { get; set; }
}

