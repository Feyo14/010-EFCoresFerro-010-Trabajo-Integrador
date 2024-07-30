using System.ComponentModel.DataAnnotations;

namespace EFCore3.Entidades
{
    //  [Table("Genre")]

    // [Index(nameof(GenreName), nameof(Genre.GenreName), IsUnique = true)]

    public  class Genre
    {
        public int GenreId { get; set; }
        [StringLength(10)]
        public string GenreName { get; set; } = null!;
        public ICollection<Shoes> shoes { get; set; } = new List<Shoes>();

    }
}
