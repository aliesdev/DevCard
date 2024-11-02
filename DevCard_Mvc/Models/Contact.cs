using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace DevCard_Mvc.Models;

public class Contact
{
    [Required(ErrorMessage = "Please enter a contact name")]
    [MinLength(3, ErrorMessage = "First name must be at least 3 characters long.")]
    [MaxLength(50, ErrorMessage = "First name cannot be longer than 10 characters.")] 
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Please enter a contact email")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; }

    public int Service { get; set; }
    public string Message { get; set; }
    
    public SelectList Services { get; set; }
}