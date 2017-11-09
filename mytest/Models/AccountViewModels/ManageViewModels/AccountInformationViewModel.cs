using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Identity;


namespace mytest.Models.ManageViewModels
{
    public class AccountInformationViewModel
    {
        
        public string FirstName { get; set; }

        public string LastName { get; set; }


      
        [Display(Name = "UserName")]
        public string UserName { get; set; }

     
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

      
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


      

    
        [StringLength(100, ErrorMessage = "Please enter your Bill to Address.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Bill To Address:")]
        public string BilltoAdd { get; set; }

       
        [StringLength(100, ErrorMessage = "Please enter a city.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "City:")]
        public string BilltoCity { get; set; }

       
        [StringLength(100, ErrorMessage = "Please enter a state.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "State:")]
        public string BilltoState { get; set; }

       




      
        [StringLength(100, ErrorMessage = "Please enter your Bill to Address.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Ship To Address:")]
        public string ShiptoAdd { get; set; }

       
        [StringLength(100, ErrorMessage = "Please enter a city.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "City:")]
        public string ShiptoCity { get; set; }

      
        [StringLength(100, ErrorMessage = "Please enter a state.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "State:")]
        public string ShiptoState { get; set; }

        
        



    }
}
