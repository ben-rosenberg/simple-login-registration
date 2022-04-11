using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SimpleLoginRegistration.Models
{

public class UserLogin
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string LEmail { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LPassword { get; set; }
}

}