using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mytest.Models
{
    public class BookComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }

        public string Comments { get; set; }

        public DateTime? ThisDateTime { get; set; }

        public string BookISBN { get; set; }

        public int? Rating { get; set; }
    }
}
