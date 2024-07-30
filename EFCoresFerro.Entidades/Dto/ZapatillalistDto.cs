using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFerro2.Entidades.Dto
{
    public class ZapatillalistDto
    {
        public int ZapatillaId { get; set; }

        public string NombreZapatilla { get; set; }

        public string Marcan { get; set; }

        public string Generon { get; set; }
        public string Deporten { get; set; }
        public decimal Precion { get; set; }
    }
}
