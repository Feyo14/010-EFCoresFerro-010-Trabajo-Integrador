using System.ComponentModel.DataAnnotations;


namespace EFCore3.Entidades
{
    // [Table("Sports")]

    // [Index(nameof(SportName), nameof(Sports.SportName), IsUnique = true)]

    public  class Sports
    {

        public int SportId { get; set; }
        [StringLength(20)]
        public string SportName { get; set; } = null!;
        public ICollection<Shoes> shoes { get; set; } = new List<Shoes>();
    }
}
