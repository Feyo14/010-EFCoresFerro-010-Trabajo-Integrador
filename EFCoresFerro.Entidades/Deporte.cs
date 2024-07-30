using System;
using System.Collections.Generic;

namespace EFCoreFerro2.Datos;

public partial class Deporte
{
    public int DeporteId { get; set; }

    public string DeporteName { get; set; } = null!;

    public virtual ICollection<Zapatilla> Zapatillas { get; set; } = new List<Zapatilla>();
}
