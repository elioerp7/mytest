using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mytest.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mytest.Models
{
    public class ShoppingCart
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int ShoppingCartId { get; set; }

        public string UserId { get; set; }

        public string BookISBN { get; set; }

        public int Quantity { get; set; }

        public double Total { get; set; }
    }
}
