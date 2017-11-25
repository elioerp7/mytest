using System.ComponentModel.DataAnnotations;

namespace mytest.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string RegFirstName { get; set; }

        [Required]
        public string RegLastName { get; set; }


        [Required]
        [Display(Name = "UserName")]
        public string RegUserName { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string RegEmail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        
        [Display(Name = "Credit Card")]
        [DataType(DataType.CreditCard)]
        [MaxLength(16)]
        [MinLength(16)]
        public string RegCCnum { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter your Bill to Address.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Bill To Address:")]
        public string RegBilltoAdd { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter a city.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "City:")]
        public string RegBilltoCity { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter a state.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "State:")]
        public string RegBilltoState { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "ZipCode :")]
       [MaxLength(5)]
        [MinLength(5)]
        public string RegBilltoZip { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "Please enter your Bill to Address.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Ship To Address:")]
        public string RegShiptoAdd { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter a city.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "City:")]
        public string RegShiptoCity { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter a state.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "State:")]
        public string RegShiptoState { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "ZipCode :")]
        [MaxLength(5)]
        [MinLength(5)]
        public string RegShiptoZip { get; set; }



    }
}
