using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "ISBN")]
        public int ISBN { get; set; }

        [Required]
        [Display(Name = "title")]
        public string Title { get; set; }

        [NotMapped]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }

        [Required]
        [Display(Name = "AuthorId")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }
        public ApplicationUser Owner { get; set; }
    }
}
