using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;
using WebGrease.Css.Ast.Selectors;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int? GenreId { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1, 20, ErrorMessage = "Number in stock should be between 1 and 20")]
        public int? NumberInStock { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                {
                    return "Edit Movie";
                }
                else
                {
                    return "New Movie";
                }
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            GenreId = movie.GenreId;
            Name = movie.Name;
            NumberInStock = movie.NumberInStock;
            ReleaseDate = movie.ReleaseDate;

        }
    }
}