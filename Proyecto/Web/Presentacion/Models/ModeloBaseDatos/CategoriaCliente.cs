﻿using System;
using System.Collections.Generic;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class CategoriaCliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Descuento { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
