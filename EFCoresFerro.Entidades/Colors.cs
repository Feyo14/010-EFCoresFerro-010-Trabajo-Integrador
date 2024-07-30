using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore3.Entidades
{
     [Table("Colors")]

    //    [Index(nameof(ColorName), nameof(Colors.ColorName), IsUnique = true)]
    public class Colors
    {
        public int ColorId { get; set; }
        [StringLength(50)]
        public string ColorName { get; set; } = null!;
    }
}
