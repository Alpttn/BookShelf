using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class CollectibleCreateViewModel
    {
        public Book Book { get; set; }
        public List<Author> Authors { get; set; }
        public List<SelectListItem> AuthorOptions
        {
            get
            {
                return Authors?.Select(c => new SelectListItem(c.FullName, c.Id.ToString())).ToList();
            }
        }
    }
}
