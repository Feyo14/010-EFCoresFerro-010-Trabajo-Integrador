using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EFCore3.Entidades
{
  //  [Index(nameof(BrandName), nameof(Brands.BrandName), IsUnique = true)]

    public  class Brands
    {
      
        public int BrandId { get; set; }
        [StringLength(50)]
        public string BrandName { get; set; } = null!;
             public ICollection<Shoes> shoes { get; set; } = new List<Shoes>();



    }
}
