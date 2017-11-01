using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mytest.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }

        public string Name { get; set; }

        public DateTime? DateofBirth { get; set; }

        public DateTime? DateofDeath { get; set; }

        public string BirthCountry { get; set; }

        public string BirthCity { get; set; }

        public string Bio { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }
    }
}
