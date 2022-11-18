using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserRegisteration.DataLayer;

public partial class User
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "User Name")]
    public string? UserName { get; set; }

    [Required]
    [Display(Name = "Email Id")]
    public string? EmailId { get; set; }
    [Required]
    [Display(Name = "Mobile Number")]
    public string? MobileNumber { get; set; }

    public string? Address { get; set; }

    
}
