using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using VideoDemo.Models;
using VideoDemo.Repository.Interface;

namespace VideoDemo.Repository
{
  public class ComprasRepository : IComprasRepository
  {
    private readonly VideoDemoContext _context;

    public ComprasRepository(VideoDemoContext context)
    {
      _context = context;
    }

    public int CreateCarrito(Carrito carrito)
    {
      // Esto no se hace!
      var cliente = _context.Cliente.Where(x => x.Id == 1).FirstOrDefault();

      if (cliente == null)
      {
        _context.Cliente.Add(new Cliente { NombreApellido = "Juan Perez" });
        _context.SaveChanges();
      }

      _context.Carrito.Add(carrito);
      _context.SaveChanges();

      return carrito.Id;
    }

    public int CreateItem(ItemCarrito item)
    {
      _context.ItemCarrito.Add(item);
      _context.SaveChanges();

      return item.Id;
    }

    public Carrito Find(int id)
    {
      return _context.Carrito
          .Include(x => x.Cliente)
          .Include(x => x.Detalle).ThenInclude(d => d.Producto)
          .Where(x => x.Id == id)
          .FirstOrDefault();
    }

    public List<Carrito> FindByClienteId(int clienteId)
    {
      return _context.Carrito
          .Include(x => x.Cliente)
          .Include(x => x.Detalle).ThenInclude(d => d.Producto)
          .Where(x => x.ClienteId == clienteId)
          .ToList();
    }


  }
}
