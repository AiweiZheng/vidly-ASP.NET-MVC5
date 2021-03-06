﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vidly.Models;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
        
        public MovieGenre MovieGenre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte MovieGenreId { get; set; }

        [Required]
        [Range(0, 20)]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

    }
}