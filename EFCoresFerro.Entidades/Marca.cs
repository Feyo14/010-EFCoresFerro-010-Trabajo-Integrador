using System;
using System.Collections.Generic;

namespace EFCoreFerro2.Datos;

public partial class Marca
{
    public int MarcaId { get; set; }

    public string MarcaName { get; set; } = null!;

    public virtual ICollection<Zapatilla> Zapatillas { get; set; } = new List<Zapatilla>();
}
