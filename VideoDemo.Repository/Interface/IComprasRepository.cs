using System;
using System.Collections.Generic;
using System.Text;
using VideoDemo.Models;

namespace VideoDemo.Repository.Interface
{
  public interface IComprasRepository
  {
    Carrito Find(int id);
    List<Carrito> FindByClienteId(int clienteId);
    int CreateCarrito(Carrito carrito);
    int CreateItem(ItemCarrito item);
  }
}
