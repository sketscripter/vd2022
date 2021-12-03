using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vd2022.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public Genre Genre { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Number In Stock")]
        public int Stock { get; set; }
    }
}