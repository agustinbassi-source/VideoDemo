namespace VideoDemo.Models
{
  public class ItemCarrito : BaseEntity
  {
    public string Notas { get; set; }
    public Producto Producto { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public int CarritoId { get; set; }
  }
}
