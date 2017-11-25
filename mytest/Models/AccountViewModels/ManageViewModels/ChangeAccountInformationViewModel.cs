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
        [Display(Name = "First Name")]
        public string NewFirstName { get; set; }


        [Display(Name = "Last Name")]
        public string NewLastName { get; set; }


      
        [Display(Name = "UserName")]
        public string NewUserName { get; set; }

     
        [EmailAddress]
        [Display(Name = "Email")]
        public string NewEmail { get; set; }

      

      

    
        [StringLength(100, ErrorMessage = "Please enter your Bill to Address.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Bill To Address:")]
        public string NewBilltoAdd { get; set; }

       
        [StringLength(100, ErrorMessage = "Please enter a city.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "City:")]
        public string NewBilltoCity { get; set; }

       
        [StringLength(100, ErrorMessage = "Please enter a state.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "State:")]
        public string NewBilltoState { get; set; }

        
        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip:")]
        [MaxLength(5)]
        [MinLength(5)]
        public string NewBilltoZip { get; set; }






        [StringLength(100, ErrorMessage = "Please enter your Bill to Address.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Ship To Address:")]
        public string NewShiptoAdd { get; set; }

       
        [StringLength(100, ErrorMessage = "Please enter a city.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "City:")]
        public string NewShiptoCity { get; set; }

      
        [StringLength(100, ErrorMessage = "Please enter a state.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "State:")]
        public string NewShiptoState { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip:")]
        [MaxLength(5)]
        [MinLength(5)]
        public string NewShiptoZip { get; set; }



        [DataType(DataType.CreditCard)]
        [Display(Name = "Credit Card:")]
        [MaxLength(16)]
        [MinLength(16)]
        public string NewCreditCard { get; set; }






    }
}
