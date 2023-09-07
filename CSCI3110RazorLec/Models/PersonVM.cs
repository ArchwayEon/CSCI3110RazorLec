using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CSCI3110RazorLec.Models;

public class PersonVM
{
    [Required(ErrorMessage = "The name cannot be blank.")]
    public string Name { get; set; } = String.Empty;

    [StringLength(20, MinimumLength = 3, ErrorMessage = "Must be at least 3 and at most 20 characters!")]
    public string Occupation { get; set; } = String.Empty;

    [Range(18, 100)]
    public int Age { get; set; }

    [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Invalid Phone Number!")]
    public string Phone { get; set; } = String.Empty;

    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [DataType(DataType.Currency)]
    public decimal PayPerHour { get; set; }

    [EmailAddress(ErrorMessage = "Invalid Email")]
    public string Email { get; set; } = String.Empty;
}
