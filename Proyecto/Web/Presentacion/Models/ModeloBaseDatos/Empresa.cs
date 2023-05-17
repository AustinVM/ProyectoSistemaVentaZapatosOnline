using System;
using System.Collections.Generic;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class Empresa
{
    public string NumIdCliente { get; set; } = null!;

    public string Nit { get; set; } = null!;

    public string NombreEmpresa { get; set; } = null!;

    public string DirBodega { get; set; } = null!;

    public bool? Estado { get; set; }

    public virtual Cliente NumIdClienteNavigation { get; set; } = null!;
}
