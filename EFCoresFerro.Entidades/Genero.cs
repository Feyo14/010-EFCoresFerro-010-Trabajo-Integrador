using System;
using System.Collections.Generic;

namespace EFCoreFerro2.Datos;

public partial class Genero
{
    public int GeneroId { get; set; }

    public string GeneroName { get; set; } = null!;

    public virtual ICollection<Zapatilla> Zapatillas { get; set; } = new List<Zapatilla>();
}
