using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        
        [Required]
        public DateTime ReleaseDate { get; set; }

        
        [Required]
        public int GenreId { get; set; }

        public GenreDTO Genre { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Number in stock should be between 1 and 20")]
        public int NumberInStock { get; set; }
    }
}