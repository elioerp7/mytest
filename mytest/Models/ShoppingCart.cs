using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mytest.Models
{
    public class ShoppingCart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShoppingCartID{ get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string BookISBN { get; set; }
        
        [MinLength (0)]
        public int Quantity { get; set; }

        public double Total { get; set; }
    }
}
