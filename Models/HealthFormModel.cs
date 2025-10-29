using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class HealthFormModel
    {
        
    
        // Personal Details
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime? DateOfBirth { get; set; }

        public string BloodGroup { get; set; }

        [Required(ErrorMessage = "Marital Status is required")]
        public string MaritalStatus { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        // Contact Information
        [Required(ErrorMessage = "Mobile Number is required")]
        [StringLength(10, ErrorMessage = "Mobile Number must be 10 digits")]
        public string MobileNumber { get; set; }

        public string AlternateContact { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public string Address { get; set; }

        // Identification Details
        [StringLength(12, ErrorMessage = "Aadhar Number must be 12 digits")]
        public string AadharNumber { get; set; }

        public string HealthCardNumber { get; set; }

        // Medical Information
        public string Height { get; set; }

        public decimal? Weight { get; set; }

        public string Allergies { get; set; }

        // Emergency Contact
        public string EmergencyName { get; set; }

        public string EmergencyRelationship { get; set; }

        public string EmergencyNumber { get; set; }

        // Documents
        public string Signature { get; set; }

        public string DeclarationSignature { get; set; }

        public DateTime? DeclarationDate { get; set; }
    }
}
 

