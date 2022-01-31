using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { set; get; }
        [Required(ErrorMessage ="Please enter a first name.")]
        public string? Firstname { set; get; }
        [Required(ErrorMessage = "Please enter a last name.")]
        public string? Lastname { set; get; }
        [Required(ErrorMessage = "Please enter a phone number.")]
        public string? Phone { set; get; }
        [Required(ErrorMessage = "Please enter an email.")]
        public string? Email { set; get; }
        public string? Organisation{ set; get; }
        public DateTime DateAdded { set; get; }
        [Range(1, 10, ErrorMessage ="Please select a category.")]
        public int CategoryId { set; get; }
        public Category? Category { set; get; }
        public String Slug => Firstname?.Replace(" ", "-").ToLower() + "-" 
            + Lastname?.Replace(" ", "-").ToLower();
    }
}
