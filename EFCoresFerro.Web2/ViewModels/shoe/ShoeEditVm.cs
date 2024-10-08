﻿using EFCore3.Entidades;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EFCoresFerro.Web2.ViewModels.Shoe.ShoeEditVm
{
    public class ShoeEditVm
    {
        public int ShoeId { get; set; }
       
        [Required(ErrorMessage ="{0} is required")]
        [StringLength(200,ErrorMessage ="{0} must have between {2} and {1} characters", MinimumLength =3)]
        [DisplayName("Descripcion")]
        [MaxLength(256, ErrorMessage = "{0} must have less than 257 characters")]
        public string Descripcion { get; set; } = null!;
        public int BrandId { get; set; }
        public int GenreId { get; set; }
        public int SportId { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> Brands { get; set; } = null!;
        [ValidateNever]

        //  public Brands? brand { get; set; }
        public IEnumerable<SelectListItem> Genre { get; set; } = null!;
        [ValidateNever]

        public IEnumerable<SelectListItem> Sport { get; set; } = null!;




        [StringLength(10)]
        public string Model { get; set; } = null!;
        //   [StringLength(int.MaxValue)]
        public decimal Price { get; set; }

    }
}
