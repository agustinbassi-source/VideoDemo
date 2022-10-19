using System;
using System.Collections.Generic;
using System.Text;

namespace VideoDemo.Models.Models
{
  public class Proveedor : BaseEntity
  {
    public string NombreProveedor { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
  }
}
