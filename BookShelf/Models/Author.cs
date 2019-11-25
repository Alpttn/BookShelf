using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(1)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(30)]
        [MinLength(1)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        
        [Display(Name = "Penn Name")]
        public string PennName { get; set; }
        
        
        [Display(Name = "Preferred Genre")]
        public string PreferredGenre { get; set; }

        public virtual ICollection<Book> BooksAuthored { get; set; }
        public ApplicationUser User { get; set; }

        
    }
}
