using System;
using System.Collections.Generic;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class Usuario
{
    public int Id { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Contrasenia { get; set; } = null!;

    public int IdRol { get; set; }

    public bool? Estado { get; set; }

    public virtual Rol IdRolNavigation { get; set; } = null!;
}
