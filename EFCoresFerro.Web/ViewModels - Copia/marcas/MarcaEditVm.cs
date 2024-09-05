using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EFCoresFerro.Web.ViewModels.Categories
{
    public class MarcaEditVm
    {
        public int MarcaId { get; set; }
        [Required(ErrorMessage ="{0} is required")]
        [StringLength(200,ErrorMessage ="{0} must have between {2} and {1} characters", MinimumLength =3)]
        [DisplayName("Category Name")]
        [MaxLength(256, ErrorMessage = "{0} must have less than 257 characters")]
        public string MarcaName { get; set; } = null!;
       
    }
}
