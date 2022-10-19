using VideoDemo.Models.Models;

namespace VideoDemo.Models
{
  public class Producto : BaseEntity
  {
    public string Nombre { get; set; }
    public int Precio { get; set; }
    public int ProveedorId { get; set; }
    public Proveedor Proveedor { get; set; }
  }
}
