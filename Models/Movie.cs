using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovies.Models
{
    public class Movie
    {
        public int ID {get; set;}
        public string Title { get; set; } = string.Empty;
        [Display(Name = "Date of Release")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Display(Name = "Audience Rating")]
        public decimal Rating {get; set; }
        [Display(Name = "Motion Picture Academy Rating")]
        public string MPAARating {get; set;} = string.Empty;
        public string Synopsis {get; set;} = string.Empty;
    }
}