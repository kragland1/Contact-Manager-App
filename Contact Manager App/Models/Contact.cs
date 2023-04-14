using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Contact_Manager_App.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]

        public string Firstname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name.")]

        public string Lastname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a phone number.")]

        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a first name.")]

        public string Email { get; set; } = string.Empty;

        public DateTime DateAdded { get; set; }

        [Range(1, 100000000, ErrorMessage = "Please select a category.")]

        public int CategoryId { get; set; }
        [ValidateNever]

        public Category Category { get; set; } = null!;

        public string Slug => Firstname?.Replace(' ', '-').ToLower() + '-' + Lastname?.Replace(' ', '-').ToLower();

    }
}
