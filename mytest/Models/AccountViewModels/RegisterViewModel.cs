using System.ComponentModel.DataAnnotations;

namespace mytest.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [DataType(DataType.CreditCard)]
        [Display(Name = "Credit Card")]
        public long CCnum { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter your Bill to Address.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Bill To Address:")]
        public string BilltoAdd { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter a city.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "City:")]
        public string BilltoCity { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter a state.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "State:")]
        public string BilltoState { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "ZipCode :")]
        public int BilltoZip { get; set; }





        [Required]
        [StringLength(100, ErrorMessage = "Please enter your Bill to Address.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Ship To Address:")]
        public string ShiptoAdd { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter a city.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "City:")]
        public string ShiptoCity { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter a state.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "State:")]
        public string ShiptoState { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "ZipCode :")]
        public int ShiptoZip { get; set; }



    }
}
