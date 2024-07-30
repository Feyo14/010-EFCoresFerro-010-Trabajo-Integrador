using System;
using System.Collections.Generic;

namespace EFCoreFerro2.Datos;

public partial class Zapatilla
{
    public int ZapatillaId { get; set; }

    public string NombreZapatilla { get; set; } = null!;

    public int DeporteId { get; set; }

    public int GeneroId { get; set; }

    public int MarcaId { get; set; }

    public decimal Price { get; set; }

    public virtual Deporte Deporte { get; set; } = null!;

    public virtual Genero Genero { get; set; } = null!;

    public virtual Marca Marca { get; set; } = null!;
}
